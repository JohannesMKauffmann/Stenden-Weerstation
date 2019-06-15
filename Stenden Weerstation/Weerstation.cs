using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Stenden_Weerstation
{
	public partial class Weerstation : Form
	{
		private WeatherController wController { get; set; }
		private TrendController tController { get; set; }
		private bool metricSystem { get; set; }
		private int CityId { get; set; }

		private const int DefaultCityId = 2756136;

		public Weerstation()
		{
			InitializeComponent();
			wController = new WeatherController();
			tController = new TrendController();
			metricSystem = false;
			CityId = 2756136;
		}

		private void Weerstation_Load(object sender, EventArgs e)
		{

		}

		private void SaveSettingsButton_Click(object sender, EventArgs e)
		{
			int number;
			if (Int32.TryParse(IntervalTextBox.Text, out number) && number > 0 && number < 61)
			{
				metricSystem = CelciusRadioButton.Checked;
				if (PlaatsTextBox.Text.Length > 0)
				{
					int tmpId = GetCityByPlaatsnaam(PlaatsTextBox.Text);
					if (tmpId > 0)
					{
						CityId = tmpId;
					}
					else
					{
						CityId = DefaultCityId;
					}
				}
			} else
			{
				MessageBox.Show("De intervalwaarde is niet geldig!");
			}
		}

		private int GetCityByPlaatsnaam(string value)
		{
			int id = -1;
			try
			{
				using (StreamReader file = File.OpenText(@"..\..\city.list.json"))
				{
					JsonSerializer serializer = new JsonSerializer();
					List<Plaats> plaatsenLijst = (List<Plaats>) serializer.Deserialize(file, typeof(List<Plaats>));
					//Dictionary<int, string> matches = new Dictionary<int, string>();
					string location = CultureInfo.CurrentUICulture.ToString().Substring(3);
					bool found = false;
					int index = 0;
					int length = plaatsenLijst.Count();
					while (index < length && !found)
					{
						found = (plaatsenLijst[ index ].name.Equals(value) && plaatsenLijst[ index ].country.Equals(location));
						id = plaatsenLijst[index].id;
						index++;
					}
				}
			}
			catch (FileNotFoundException ex)
			{
				MessageBox.Show(ex.Message);
			}
			return id;
		}
	}
}
