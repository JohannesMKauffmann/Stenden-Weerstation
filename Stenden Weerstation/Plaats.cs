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
		public Dictionary<string, double> coord { get; set; }
	}
}
