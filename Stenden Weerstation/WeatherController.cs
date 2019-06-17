using System;
using System.IO;
using System.Net.Http;
using System.Net;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Stenden_Weerstation
{
	class WeatherController
	{
		private const string APIKEY = "0a03d77b213b8ea8fff7162343e65639";
		//private static readonly HttpClient client = new HttpClient();

		//public delegate Forecast MyDel(int City_Id);

		//public event MyDel GetDataFromDb;

		public string BuildRequestUrl(int CityId, string language)
		{
			language = language.ToLower();
			string url = "https://api.openweathermap.org/data/2.5/weather?id=" + 
				CityId + "&lang=" + language + "&appid=" + APIKEY;
			return url;
		}

		public void SendWeatherRequest(int City_Id, string language)
		{
			try
			{
				string url = BuildRequestUrl(City_Id, language);
				//string responseBody = await client.GetStringAsync(url);
				WebClient client = new WebClient();
				string responseBody = client.DownloadString(url);
				ParseForecastResponse(responseBody);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		public void ParseForecastResponse(string responseBody)
		{
			using (JsonTextReader reader = new JsonTextReader(new StringReader(responseBody)))
			{
				JsonSerializer serializer = new JsonSerializer();
				Forecast forecast = (Forecast) serializer.Deserialize(reader, typeof(Forecast));
				WriteForecastToDatabase(forecast);
			}
		}

		public void WriteForecastToDatabase(Forecast forecast)
		{
			try
			{
				string connectionString = "Data Source=.;Initial Catalog=StendenWeerstation;Integrated Security=True";
				using (SqlConnection connection = new SqlConnection(connectionString))
				{
					using (SqlCommand command = connection.CreateCommand())
					{
						command.CommandType = CommandType.StoredProcedure;
						command.CommandText = "InsertForecast";
						command.Parameters.AddWithValue("@Weather_Desc", forecast.weather.First().description);
						command.Parameters.AddWithValue("@Weather_Icon", forecast.weather.First().icon);
						command.Parameters.AddWithValue("@City_Id", forecast.id);
						command.Parameters.AddWithValue("@Datetime", forecast.dt);
						command.Parameters.AddWithValue("@Temp", forecast.main.temp);
						command.Parameters.AddWithValue("@Humidity", forecast.main.humidity);
						command.Parameters.AddWithValue("@Wind_Speed", forecast.wind.speed);
						command.Parameters.AddWithValue("@Wind_Deg", forecast.wind.deg);
						connection.Open();
						command.ExecuteNonQuery();
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		public int GetMaxDatetimeFromDatabase()
		{
			int MaxDatetime = -1;
			try
			{
				string connectionString = "Data Source=.;Initial Catalog=StendenWeerstation;Integrated Security=True";
				using (SqlConnection connection = new SqlConnection(connectionString))
				{
					using (SqlCommand command = connection.CreateCommand())
					{
						command.CommandType = CommandType.StoredProcedure;
						command.CommandText = "GetMaxDatetime";

						command.Parameters.AddWithValue("@MaxDatetime", null);
						command.Parameters[ "@MaxDatetime" ].DbType = DbType.Int32;
						command.Parameters[ "@MaxDatetime" ].Direction = ParameterDirection.Output;

						connection.Open();
						command.ExecuteNonQuery();

						MaxDatetime = Int32.Parse(command.Parameters[ "@MaxDatetime" ].Value.ToString());
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			return MaxDatetime;
		}

		public Forecast GetLatestForecastFromDatabase(int City_Id, int MaxDatetime)
		{
			Forecast forecast = new Forecast();
			try
			{
				string connectionString = "Data Source=.;Initial Catalog=StendenWeerstation;Integrated Security=True";
				using (SqlConnection connection = new SqlConnection(connectionString))
				{
					using (SqlCommand command = connection.CreateCommand())
					{
						command.CommandType = CommandType.StoredProcedure;
						command.CommandText = "GetForecastByCityIdAndDateTime";

						//Add input parameters
						command.Parameters.AddWithValue("@City_Id", City_Id);
						command.Parameters.AddWithValue("@MaxDatetime", MaxDatetime);

						//Add output parameters
						command.Parameters.AddWithValue("@Weather_Desc", null);
						command.Parameters[ "@Weather_Desc" ].DbType = DbType.Int32;
						command.Parameters[ "@Weather_Desc" ].Direction = ParameterDirection.Output;

						command.Parameters.AddWithValue("@Weather_Icon", null);
						command.Parameters[ "@Weather_Icon" ].DbType = DbType.String;
						command.Parameters[ "@Weather_Icon" ].Direction = ParameterDirection.Output;

						command.Parameters.AddWithValue("@Datetime", null);
						command.Parameters[ "@Datetime" ].DbType = DbType.Int32;
						command.Parameters[ "@Datetime" ].Direction = ParameterDirection.Output;

						command.Parameters.AddWithValue("@Temp", null);
						command.Parameters[ "@Temp" ].DbType = DbType.Decimal;
						command.Parameters[ "@Temp" ].Direction = ParameterDirection.Output;

						command.Parameters.AddWithValue("@Humidity", null);
						command.Parameters[ "@Humidity" ].DbType = DbType.Int32;
						command.Parameters[ "@Humidity" ].Direction = ParameterDirection.Output;

						command.Parameters.AddWithValue("@Wind_Speed", null);
						command.Parameters[ "@Wind_Speed" ].DbType = DbType.Decimal;
						command.Parameters[ "@Wind_Speed" ].Direction = ParameterDirection.Output;

						command.Parameters.AddWithValue("@Wind_Deg", null);
						command.Parameters[ "@Wind_Deg" ].DbType = DbType.Decimal;
						command.Parameters[ "@Wind_Deg" ].Direction = ParameterDirection.Output;

						connection.Open();
						command.ExecuteNonQuery();

						MessageBox.Show(command.Parameters[ "@Weather_Desc" ].Value.ToString());
						MessageBox.Show(command.Parameters[ "@Weather_Icon" ].Value.ToString());
						MessageBox.Show(command.Parameters[ "@Datetime" ].Value.ToString());
						MessageBox.Show(command.Parameters[ "@Temp" ].Value.ToString());
						MessageBox.Show(command.Parameters[ "@Humidity" ].Value.ToString());
						MessageBox.Show(command.Parameters[ "@Wind_Speed" ].Value.ToString());
						MessageBox.Show(command.Parameters[ "@Wind_Deg" ].Value.ToString());

						forecast.weather.Add(new Weather {
							description = command.Parameters[ "@Weather_Desc" ].Value.ToString(),
							icon = command.Parameters[ "@Weather_Icon" ].Value.ToString()
						});
						forecast.dt = Int32.Parse(command.Parameters[ "@Datetime" ].Value.ToString());
						forecast.main = new Main {
							temp = Double.Parse(command.Parameters[ "@Temp" ].Value.ToString()),
							humidity = Int32.Parse(command.Parameters[ "@Humidity" ].Value.ToString())
						};
						forecast.wind = new Wind {
							speed = Double.Parse(command.Parameters[ "@Wind_Speed" ].Value.ToString()),
							deg = Double.Parse(command.Parameters[ "@Wind_Deg" ].Value.ToString())
						};
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			return forecast;
		}
	}
}
