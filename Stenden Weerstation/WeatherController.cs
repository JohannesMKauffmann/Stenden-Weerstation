using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stenden_Weerstation
{
	class WeatherController
	{
		public const string APIKEY = "0a03d77b213b8ea8fff7162343e65639";

		private static readonly HttpClient client = new HttpClient();

		public string GetRequestUrl(int CityId, bool metricSystem, string language)
		{
			language = language.ToLower();
			string units = "metric";
			if (!metricSystem)
			{
				units = "imperial";
			}
			string url = "https://api.openweathermap.org/data/2.5/weather?id=" + CityId +
				"&units=" + units + "&lang=" + language + "&appid=" + APIKEY;
			return url;
		}

		public async void SendWeatherRequest(int CityId, bool metricSystem, string language)
		{
			try
			{
				string url = GetRequestUrl(CityId, metricSystem, language);
				string responseBody = await client.GetStringAsync(url);
				WriteWeatherToDatabase(responseBody);
			}
			catch (HttpRequestException ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		public void WriteWeatherToDatabase(string responseBody)
		{
			//MessageBox.Show(responseBody);
		}
	}
}
