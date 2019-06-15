using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stenden_Weerstation
{
	class Plaats
	{
		public int id { get; set; }
		public string name { get; set; }
		public string country { get; set; }
	}
	
	class Forecast
	{
		public List<Weather> weather { get; set; }
		public Main main { get; set; }
		public Wind wind { get; set; }
		public int dt { get; set; }
		public int id { get; set; }
		public string name { get; set; }
	}

	class Weather
	{
		public string description { get; set; }
		public string icon { get; set; }
	}

	class Main
	{
		public decimal temp { get; set; }
		public int pressure { get; set; }
		public int humidity { get; set; }
	}

	class Wind
	{
		public decimal speed { get; set; }
		public int deg { get; set; }
	}
}
