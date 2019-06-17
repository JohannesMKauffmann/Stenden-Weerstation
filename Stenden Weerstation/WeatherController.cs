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

		public bool SendWeatherRequest(int City_Id, string language)
		{
			try
			{
				string url = BuildRequestUrl(City_Id, language);
				//string responseBody = await client.GetStringAsync(url);
				WebClient client = new WebClient();
				string responseBody = client.DownloadString(url);
				ParseForecastResponse(responseBody);
				return true;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				return false;
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
				GetLatestForecastFromDatabase(forecast.id);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		public Forecast GetLatestForecastFromDatabase(int City_Id)
		{
			Forecast forecast = new Forecast();
			try
			{
				int MaxDatetime;
				string connectionString = "Data Source=.;Initial Catalog=StendenWeerstation;Integrated Security=True";
				using (SqlConnection connection = new SqlConnection(connectionString))
				{
					connection.Open();
					using (SqlCommand MaxCommand = connection.CreateCommand())
					{
						MaxCommand.CommandType = CommandType.StoredProcedure;
						MaxCommand.CommandText = "GetMaxDatetime";
						MaxCommand.Parameters.AddWithValue("@MaxDatetime", null);
						MaxCommand.Parameters[ "@MaxDatetime" ].DbType = DbType.Int32;
						MaxCommand.Parameters[ "@MaxDatetime" ].Direction = ParameterDirection.Output;
						MaxCommand.ExecuteNonQuery();
						MaxDatetime = Int32.Parse(MaxCommand.Parameters[ "@MaxDatetime" ].Value.ToString());

						SqlCommand GetForecast = connection.CreateCommand();
						GetForecast.CommandType = CommandType.StoredProcedure;
						GetForecast.CommandText = "GetLatestForecastByCityId";
					//}

					//using (SqlCommand GetForecast = connection.CreateCommand())
					//{
						GetForecast.CommandType = CommandType.StoredProcedure;
						GetForecast.CommandText = "GetLatestForecastByCityId";

						GetForecast.Parameters.AddWithValue("@City_Id", City_Id);
						GetForecast.Parameters.AddWithValue("@MaxDatetime", MaxDatetime);

						GetForecast.Parameters.AddWithValue("@Weather_Desc", null);
						GetForecast.Parameters[ "@Weather_Desc" ].DbType = DbType.Int32;
						GetForecast.Parameters[ "@Weather_Desc" ].Direction = ParameterDirection.Output;

						GetForecast.Parameters.AddWithValue("@Weather_Icon", null);
						GetForecast.Parameters[ "@Weather_Icon" ].DbType = DbType.String;
						GetForecast.Parameters[ "@Weather_Icon" ].Direction = ParameterDirection.Output;

						GetForecast.Parameters.AddWithValue("@Datetime", null);
						GetForecast.Parameters[ "@Datetime" ].DbType = DbType.Int32;
						GetForecast.Parameters[ "@Datetime" ].Direction = ParameterDirection.Output;

						GetForecast.Parameters.AddWithValue("@Temp", null);
						GetForecast.Parameters[ "@Temp" ].DbType = DbType.Decimal;
						GetForecast.Parameters[ "@Temp" ].Direction = ParameterDirection.Output;

						GetForecast.Parameters.AddWithValue("@Humidity", null);
						GetForecast.Parameters[ "@Humidity" ].DbType = DbType.Int32;
						GetForecast.Parameters[ "@Humidity" ].Direction = ParameterDirection.Output;

						GetForecast.Parameters.AddWithValue("@Wind_Speed", null);
						GetForecast.Parameters[ "@Wind_Speed" ].DbType = DbType.Decimal;
						GetForecast.Parameters[ "@Wind_Speed" ].Direction = ParameterDirection.Output;

						GetForecast.Parameters.AddWithValue("@Wind_Deg", null);
						GetForecast.Parameters[ "@Wind_Deg" ].DbType = DbType.Decimal;
						GetForecast.Parameters[ "@Wind_Deg" ].Direction = ParameterDirection.Output;

						GetForecast.ExecuteNonQuery();

						MessageBox.Show(GetForecast.Parameters[ "@Weather_Desc" ].Value.ToString());
						MessageBox.Show(GetForecast.Parameters[ "@Weather_Icon" ].Value.ToString());
						MessageBox.Show(GetForecast.Parameters[ "@Datetime" ].Value.ToString());
						MessageBox.Show(GetForecast.Parameters[ "@Temp" ].Value.ToString());
						MessageBox.Show(GetForecast.Parameters[ "@Humidity" ].Value.ToString());
						MessageBox.Show(GetForecast.Parameters[ "@Wind_Speed" ].Value.ToString());
						MessageBox.Show(GetForecast.Parameters[ "@Wind_Deg" ].Value.ToString());

						forecast.weather.Add(new Weather {
							description = GetForecast.Parameters[ "@Weather_Desc" ].Value.ToString(),
							icon = GetForecast.Parameters[ "@Weather_Icon" ].Value.ToString()
						});
						forecast.dt = Int32.Parse(GetForecast.Parameters[ "@Datetime" ].Value.ToString());
						forecast.main = new Main {
							temp = Double.Parse(GetForecast.Parameters[ "@Temp" ].Value.ToString()),
							humidity = Int32.Parse(GetForecast.Parameters[ "@Humidity" ].Value.ToString())
						};
						forecast.wind = new Wind {
							speed = Double.Parse(GetForecast.Parameters[ "@Wind_Speed" ].Value.ToString()),
							deg = Double.Parse(GetForecast.Parameters[ "@Wind_Deg" ].Value.ToString())
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

		//public int GetMaxDatetimeFromDatabase()
		//{
		//	int MaxDatetime = -1;
		//	try
		//	{
		//		string connectionString = "Data Source=.;Initial Catalog=StendenWeerstation;Integrated Security=True";
		//		SqlConnection connection = new SqlConnection(connectionString);
		//		// Get the maximum value of Datetime, so we can select the most recent weather repor
		//	}
		//	catch (Exception ex)
		//	{
		//		MessageBox.Show(ex.Message);
		//	}
		//	return MaxDatetime;
		//}
	}
}
