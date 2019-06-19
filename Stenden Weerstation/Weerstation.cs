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
using System.Globalization;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Stenden_Weerstation
{
	public partial class Weerstation : Form
	{
		private WeatherController WController { get; set; }
		private string Plaatsnaam { get; set; }
		private int Interval { get; set; }
		private bool MetricSystem { get; set; }
		private int City_Id { get; set; }
		private string Language { get; set; }

		private const int DefaultCityId = 2756136;
		private const string DefaultPlaatsnaam = "Emmen";
		private const int DefaultInterval = 60;

		public Weerstation()
		{
			Thread T = new Thread(new ThreadStart(StartSplashScreen));
			T.Start();
			Thread.Sleep(2000);
			InitializeComponent();

			WController = new WeatherController();
			City_Id = DefaultCityId;
			Plaatsnaam = DefaultPlaatsnaam;
			Interval = DefaultInterval;
			MetricSystem = true;
			Language = CultureInfo.CurrentCulture.ToString().Substring(3);

			T.Abort();
		}

		private void Timer_Tick(object sender, EventArgs e)
		{
			Timer.Interval = Interval * 1000;
			UpdateApiAndForm();
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
			WController.QueryWeatherApi(City_Id, Language);

			// get latest forecast from DB, indepent of connection
			// if request was succesfull, latest forecast is already written to DB
			int MaxPK = WController.GetMaxPKFromDatabase(City_Id);
			WController.GetLatestForecastFromDatabase(MaxPK);
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
			PlaatsTextBox.Text = Plaatsnaam;
			IntervalTextBox.Text = Interval.ToString();
			LocationLabel.Text = Plaatsnaam;
			DescriptionLabel.Text = forecast.weather.First().description;
			WeatherIconPictureBox.ImageLocation = "http://openweathermap.org/img/w/" + forecast.weather.First().icon + ".png";
			TemperatuurLabel.Text = BuildTemperatureString(forecast.main.temp);
			LuchtvochtigheidLabel.Text = String.Format("Luchtvochtigheid: {0}%", forecast.main.humidity);
			WindLabel.Text = BuildWindString(forecast.wind.speed, forecast.wind.deg);
			DateTime LatestUpdate = forecast.datetime;
			LatestUpdateLabel.Text = String.Format("[Laatste update: {0}]", LatestUpdate);
			FillChart(WController.GetAvgTempPerDayByCity(City_Id));
			TempToolStripTextBox.Text = BuildContextMenuTemperature(CalculateTemperature(forecast.main.temp, MetricSystem), MetricSystem);
		}

		private string BuildContextMenuTemperature(double Temp, bool MetricSystem)
		{
			if (MetricSystem)
			{
				return "Huidige temperatuur: " + Temp + " °C";
			}
			else
			{
				return "Huidige temperatuur: " + Temp + " °F";
			}
		}

		private double CalculateTemperature(double Temp, bool MetricSystem)
		{
			if (MetricSystem)
			{
				return Math.Round(Temp - 273, 1);
			}
			else
			{
				return Math.Round((1.8 * (Temp - 273)) + 32, 1);
			}
		}

		private string BuildTemperatureString(double temp)
		{
			string TemperatureString = String.Format("Temperature: {0}", CalculateTemperature(temp, MetricSystem));
			if (MetricSystem)
			{
				TemperatureString += " °C";
			}
			else
			{
				TemperatureString += " °F";
			}
			return TemperatureString;
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
				WindString += "Noordoosterwind";
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
				Timer.Interval = Interval * 1000;
				MetricSystem = CelciusRadioButton.Checked;
				if (PlaatsTextBox.Text.Length > 0)
				{
					if (!PlaatsTextBox.Text.Equals(Plaatsnaam))
					{
						Plaatsnaam = PlaatsTextBox.Text;
						City_Id = GetIdByPlaatsnaam(Plaatsnaam).First().Key;
						UpdateApiAndForm();
					}
					else
					{
						if (WController.forecast != null)
						{
							UpdateForm(WController.forecast);
						}
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
				Matches.Add(DefaultCityId, DefaultPlaatsnaam);
				MessageBox.Show("Niet gevonden. Locatie staat op de standaardwaarde: " + DefaultPlaatsnaam);
			}
			return Matches;
		}

		private void FillChart(Temps Temps)
		{
			int Length = Temps.AvgTemps.Count();
			for (int i = 0; i < Length; i++)
			{
				if (Temps.AvgTemps[ i ] != 0)
				{
					Temps.AvgTemps[ i ] = CalculateTemperature(Temps.AvgTemps[ i ], MetricSystem);
				}
			}

			WeatherTrendChart.Series[ 0 ].Points.Clear();
			
			WeatherTrendChart.Series[ "Gemiddelde Temperatuur" ].Points.AddXY(Temps.PastDays.ElementAt(4), Temps.AvgTemps[ 4 ]);
			WeatherTrendChart.Series[ "Gemiddelde Temperatuur" ].Points.AddXY(Temps.PastDays.ElementAt(3), Temps.AvgTemps[ 3 ]);
			WeatherTrendChart.Series[ "Gemiddelde Temperatuur" ].Points.AddXY(Temps.PastDays.ElementAt(2), Temps.AvgTemps[ 2 ]);
			WeatherTrendChart.Series[ "Gemiddelde Temperatuur" ].Points.AddXY(Temps.PastDays.ElementAt(1), Temps.AvgTemps[ 1 ]);
			WeatherTrendChart.Series[ "Gemiddelde Temperatuur" ].Points.AddXY(Temps.PastDays.ElementAt(0), Temps.AvgTemps[ 0 ]);
		}

		private void overToolStripMenuItem_Click(object sender, EventArgs e)
		{
			AboutBox Box = new AboutBox();
			Box.ShowDialog();
		}

		private void verversenToolStripMenuItem_Click(object sender, EventArgs e)
		{
			UpdateApiAndForm();
		}

		private void Weerstation_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (e.CloseReason == CloseReason.UserClosing)
			{
				e.Cancel = true;
				this.Hide();
			}
		}

		private void toolStripMenuItem1_Click(object sender, EventArgs e)
		{
			this.Show();
		}

		private void NotifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			this.Show();
		}

		private void sluitenToolStripMenuItem_Click(object sender, EventArgs e)
		{
			NotifyIcon.Dispose();
			Application.Exit();
		}

		private void optiesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MainTabControl.SelectTab("OptiesTabPage");
			Show();
		}
	}
}
