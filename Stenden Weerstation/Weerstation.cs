using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Globalization;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Stenden_Weerstation
{
	public partial class Weerstation : Form
	{
		private WeatherController WController { get; set; }
		public new string Location { get; set; }
		public int Interval { get; set; }
		private bool MetricSystem { get; set; }
		private int City_Id { get; set; }
		public string Language { get; set; }

		private const int DefaultCityId = 2756136;
		private const string DefaultLocation = "Emmen";

		public Weerstation()
		{
			Thread T = new Thread(new ThreadStart(StartSplashScreen));
			T.Start();
			Thread.Sleep(2000);
			InitializeComponent();

			WController = new WeatherController();
			City_Id = DefaultCityId;
			Location = DefaultLocation;
			MetricSystem = true;
			Language = CultureInfo.CurrentCulture.ToString().Substring(3);

			T.Abort();
		}

		public void StartSplashScreen()
		{
			Application.Run(new SplashScreen());
		}

		private void Weerstation_Load(object sender, EventArgs e)
		{
			UpdateApiAndForm();
		}

		private void UpdateApiAndForm()
		{
			WController.SendWeatherRequest(City_Id, Language);

			// get latest forecast from DB, indepent of connection
			// if request was succesfull, latest forecast is already written to DB
			int MaxPK = WController.GetMaxPKFromDatabase();
			WController.GetLatestForecastFromDatabase(City_Id, MaxPK);
			try
			{
				UpdateForm(WController.forecast);
			}
			catch (ArgumentNullException)
			{
				MessageBox.Show("Er is iets mis gegaan :<(");
			}
		}

		private void UpdateForm(Forecast forecast)
		{
			DescriptionLabel.Text = forecast.weather.First().description;
			WeatherIconPictureBox.ImageLocation = "http://openweathermap.org/img/w/" + forecast.weather.First().icon + ".png";
			TemperatuurLabel.Text = BuildTemperatureString(forecast.main.temp);
			LuchtvochtigheidLabel.Text = BuildHumidityString(forecast.main.humidity);
			WindLabel.Text = BuildWindString(forecast.wind.speed, forecast.wind.deg);
			DateTime LatestUpdate = new DateTime(1970, 1, 1, 0, 0, 0, 0);
			LatestUpdate = LatestUpdate.AddSeconds(forecast.dt);
			LatestUpdateLabel.Text = "[Laatste update: " + LatestUpdate.ToLocalTime().ToString() + "]";
		}

		private string BuildTemperatureString(double temp)
		{
			string TemperatureString = "Temperature: ";
			if (MetricSystem)
			{
				TemperatureString += Math.Round(temp - 273, 1).ToString() + " °C";
			}
			else
			{
				TemperatureString += Math.Round(((temp - 273 * 9) / 5) + 32, 1).ToString() + " °F";
			}
			return TemperatureString;
		}

		private string BuildHumidityString(int humidity)
		{
			string HumidityString = "Luchtvochtigheid: " + humidity.ToString() + "%";
			return HumidityString;
		}

		private string BuildWindString(double speed, double deg)
		{
			string WindString = "";
			if (deg >= 336.5 && deg < 22.5)
			{
				WindString += "Noorderwind";
			}
			else if (deg >= 22.5 && deg < 67.5)
			{
				WindString += "Nooroosterwind";
			}
			else if (deg >= 67.5 && deg < 112.5)
			{
				WindString += "Oosterwind";
			}
			else if (deg >= 112.5 && deg < 157.5)
			{
				WindString += "Zuidoosterwind";
			}
			else if (deg >= 157.5 && deg < 202.5)
			{
				WindString += "Zuiderwind";
			}
			else if (deg >= 202.5 && deg < 247.5)
			{
				WindString += "Zuidwesterwind";
			}
			else if (deg >= 247.5 && deg < 292.5)
			{
				WindString += "Westerwind";
			}
			else
			{
				WindString += "Noordwesterwind";
			}
			if (MetricSystem)
			{
				WindString += " met " + Math.Round(speed * 3.6, 1).ToString() + " km/h";
			}
			else
			{
				WindString += " met " + Math.Round(speed * 2.2369, 1).ToString() + " MPH";
			}
			return WindString;
		}

		private void SaveSettingsButton_Click(object sender, EventArgs e)
		{
			if (Int32.TryParse(IntervalTextBox.Text, out int number) && number > 0)
			{
				Interval = number;
				MetricSystem = CelciusRadioButton.Checked;
				if (PlaatsTextBox.Text.Length > 0)
				{
					City_Id = GetIdByPlaatsnaam(PlaatsTextBox.Text).First().Key;
					Location = PlaatsTextBox.Text;
					if (WController.forecast != null)
					{
						UpdateForm(WController.forecast);
					}
					MessageBox.Show("De instellingen zijn succesvol toegepast.");
				}
				else
				{
					MessageBox.Show("Vul a.u.b. een plaatsnaam in.");
				}
			}
			else
			{
				MessageBox.Show("De intervalwaarde is niet geldig!");
			}
		}

		private Dictionary<int, string> GetIdByPlaatsnaam(string value)
		{
			Dictionary<int, string> Matches = new Dictionary<int, string>();
			try
			{
				using (StreamReader file = File.OpenText(@"..\..\city.list.json"))
				{
					JsonSerializer serializer = new JsonSerializer();
					List<Plaats> plaatsenLijst = (List<Plaats>) serializer.Deserialize(file, typeof(List<Plaats>));
					//TODO: dropdown met input, alle mogelijkheden, lijst van plaatsnaam + land
					//Dictionary<int, string> matches = new Dictionary<int, string>();
					bool found = false;
					int index = 0;
					int length = plaatsenLijst.Count();
					while (index < length && !found)
					{
						if (plaatsenLijst[ index ].name.Equals(value) && plaatsenLijst[ index ].country.Equals(Language))
						{
							Matches.Add(plaatsenLijst[ index ].id, plaatsenLijst[ index ].name);
							found = true;
						}
						index++;
					}
				}
			}
			catch (FileNotFoundException ex)
			{
				MessageBox.Show(ex.Message);
			}
			if (Matches.Count < 1)
			{
				Matches.Add(DefaultCityId, DefaultLocation);
				MessageBox.Show("Niet gevonden. Locatie staat op de standaardwaarde: " + DefaultLocation);
			}
			return Matches;
		}
	}
}
