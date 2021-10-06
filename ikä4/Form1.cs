using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ikä
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void SyntymaAikaDT_ValueChanged(object sender, EventArgs e)
		{
			DateTime synttari = SyntymaAikaDT.Value;
			DateTime nyt = DateTime.Now;
			double erotus = Math.Round((nyt - synttari).TotalDays);
			vuosinaLB.Text = Math.Ceiling(erotus / 365.25) + "vuotta";
			kuukausinaLB.Text = Math.Ceiling(erotus * 12 / 365.25) + "kuukautta";
			päivinäLB.Text = (erotus + "päivää");
			viikkoinaLB.Text = (erotus * 24 + "tuntia");
			MinuutteinaLB.Text = (erotus * 24 * 60 + "minuuttia");
			SekunteinaLB.Text = (erotus * 24 * 3600 + "sekuntia");
			vuosinaLB.Visible = true;
			kuukausinaLB.Visible = true;
			päivinäLB.Visible = true;
			viikkoinaLB.Visible = true;
		MinuutteinaLB.Visible = true;
			SekunteinaLB.Visible = true;
		}
	}
}
