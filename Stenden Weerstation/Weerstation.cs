using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stenden_Weerstation
{
	public partial class Weerstation : Form
	{
		public Weerstation()
		{
			InitializeComponent();
			WeatherController controller = new WeatherController();
		}
	}
}
