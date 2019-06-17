using System;
using System.IO;
using System.Net;
using System.Data;
using System.Data.SqlClient;
using System.Collections;
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
		private const string ConnectionString = "Data Source=.;Initial Catalog=StendenWeerstation;Integrated Security=True";

		public Forecast forecast;

		public void QueryWeatherApi(int City_Id, string Language)
		{
			string url = String.Format("https://api.openweathermap.org/data/2.5/weather?id={0}&lang={1}&appid={2}", City_Id, Language, APIKEY);
			try
			{				
				WebClient client = new WebClient();
				string responseBody = client.DownloadString(url);

				using (JsonTextReader reader = new JsonTextReader(new StringReader(responseBody)))
				{
					JsonSerializer serializer = new JsonSerializer();
					Forecast forecast = (Forecast) serializer.Deserialize(reader, typeof(Forecast));
					WriteForecastToDatabase(forecast);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		public void WriteForecastToDatabase(Forecast forecast)
		{
			try
			{
				using (SqlConnection connection = new SqlConnection(ConnectionString))
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

		public int GetMaxPKFromDatabase()
		{
			int MaxPK = -1;
			try
			{
				using (SqlConnection connection = new SqlConnection(ConnectionString))
				{
					using (SqlCommand command = connection.CreateCommand())
					{
						command.CommandType = CommandType.StoredProcedure;
						command.CommandText = "GetMaxPK";

						command.Parameters.AddWithValue("@MaxPK", null);
						command.Parameters[ "@MaxPK" ].DbType = DbType.Int32;
						command.Parameters[ "@MaxPK" ].Direction = ParameterDirection.Output;

						connection.Open();
						command.ExecuteNonQuery();

						MaxPK = Int32.Parse(command.Parameters[ "@MaxPK" ].Value.ToString());
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			return MaxPK;
		}

		public void GetLatestForecastFromDatabase(int City_Id, int MaxPK)
		{
			try
			{
				using (SqlConnection connection = new SqlConnection(ConnectionString))
				{
					using (SqlCommand command = connection.CreateCommand())
					{
						command.CommandType = CommandType.StoredProcedure;
						command.CommandText = "GetForecastByCityIdAndPK";
						
						//Add input parameters
						command.Parameters.AddWithValue("@City_Id", City_Id);
						command.Parameters.AddWithValue("@MaxPK", MaxPK);

						//Add output parameters
						command.Parameters.AddWithValue("@Weather_Desc", null);
						command.Parameters[ "@Weather_Desc" ].DbType = DbType.String;
						command.Parameters[ "@Weather_Desc" ].Direction = ParameterDirection.Output;
						command.Parameters[ "@Weather_Desc" ].Size = 30;

						command.Parameters.AddWithValue("@Weather_Icon", null);
						command.Parameters[ "@Weather_Icon" ].DbType = DbType.String;
						command.Parameters[ "@Weather_Icon" ].Direction = ParameterDirection.Output;
						command.Parameters[ "@Weather_Icon" ].Size = 3;

						command.Parameters.AddWithValue("@Datetime", null);
						command.Parameters[ "@Datetime" ].DbType = DbType.Int32;
						command.Parameters[ "@Datetime" ].Direction = ParameterDirection.Output;

						command.Parameters.AddWithValue("@Temp", null);
						command.Parameters[ "@Temp" ].DbType = DbType.Double;
						command.Parameters[ "@Temp" ].Direction = ParameterDirection.Output;

						command.Parameters.AddWithValue("@Humidity", null);
						command.Parameters[ "@Humidity" ].DbType = DbType.Int32;
						command.Parameters[ "@Humidity" ].Direction = ParameterDirection.Output;

						command.Parameters.AddWithValue("@Wind_Speed", null);
						command.Parameters[ "@Wind_Speed" ].DbType = DbType.Double;
						command.Parameters[ "@Wind_Speed" ].Direction = ParameterDirection.Output;

						command.Parameters.AddWithValue("@Wind_Deg", null);
						command.Parameters[ "@Wind_Deg" ].DbType = DbType.Double;
						command.Parameters[ "@Wind_Deg" ].Direction = ParameterDirection.Output;

						connection.Open();
						command.ExecuteNonQuery();

						forecast = new Forecast();

						forecast.weather = new List<Weather> {
							new Weather {
								description = command.Parameters[ "@Weather_Desc" ].Value.ToString(),
								icon = command.Parameters[ "@Weather_Icon" ].Value.ToString()
							}
						};
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
		}

		public double[] GetAvgTempPerDayByCity(int City_Id)
		{
			double[] AvgTemps = new double[ 5 ];

			List<KeyValuePair<int, int>> Timestamps = GetTimestampFor5Days();

			for (int i = 0; i < 5; i++)
			{
				using (SqlConnection connection = new SqlConnection(ConnectionString))
				{
					using (SqlCommand command = connection.CreateCommand())
					{
						try
						{
							command.CommandType = CommandType.StoredProcedure;
							command.CommandText = "GetAvgTempPerDayByCity";

							command.Parameters.AddWithValue("@Ochtend", Timestamps.ElementAt(i).Key);
							command.Parameters.AddWithValue("@Avond", Timestamps.ElementAt(i).Value);
							command.Parameters.AddWithValue("@City_Id", City_Id);

							command.Parameters.AddWithValue("@AvgTemp", null);
							command.Parameters[ "@AvgTemp" ].DbType = DbType.Double;
							command.Parameters[ "@AvgTemp" ].Direction = ParameterDirection.Output;

							connection.Open();
							command.ExecuteNonQuery();

							try
							{
								AvgTemps[ i ] = Double.Parse(command.Parameters[ "@AvgTemp" ].Value.ToString());
							}
							catch (FormatException)
							{
								AvgTemps[ i ] = 0;
							}
						}
						catch (Exception ex)
						{
							MessageBox.Show(ex.Message);
						}
					}
				}
			}
			return AvgTemps;
		}

		public List<KeyValuePair<int, int>> GetTimestampFor5Days()
		{
			List<KeyValuePair<int, int>> Timestamps = new List<KeyValuePair<int, int>>();
			
			int Year = DateTime.Today.Year;
			int Month = DateTime.Today.Month;
			int Day = DateTime.Today.Day;

			for (int i = 0; i < 5; i++)
			{
				DateTime Ochtend = new DateTime(Year, Month, Day - i);
				DateTime Avond = new DateTime(Year, Month, Day - i);
				Avond = Avond.AddHours(23);
				Avond = Avond.AddMinutes(59);
				Avond = Avond.AddSeconds(59);

				Timestamps.Add(
					new KeyValuePair<int, int>(
						(int) Ochtend.Subtract(new DateTime(1970, 1, 1)).TotalSeconds,
						(int) Avond.Subtract(new DateTime(1970, 1, 1)).TotalSeconds
					)
				);
			}

			return Timestamps;
		}
	}
}
