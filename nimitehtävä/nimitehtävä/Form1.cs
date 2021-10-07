using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace nimitehtävä
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TarkastaBT_Click(object sender, EventArgs e)
        {
            VastausLB.Text = "";
            VastausLB.Visible = false;
            string[] pojat = File.ReadAllLines("C:\\Users\\manni\\source\\repos\\nimitehtävä\\pojat.txt");
            string[] tytot = File.ReadAllLines("C:\\Users\\manni\\source\\repos\\nimitehtävä\\tytot.txt");
            string nimi = NimiTB.Text;
            int laskurip = 1, laskurit = 1;
            foreach (string poju in pojat)
            {
                if (nimi == poju)
                {
                    VastausLB.Text = "Nimesi on" + laskurip + ".50 suosituimman joukossa";
                    VastausLB.Visible = true;
                }
                laskurip++;
            }

            foreach (string friidu in tytot)
            {
                if (nimi == friidu)
                {
                    VastausLB.Text = "Nimesi on" + laskurit + ".50 suosituimman joukossa";
                    VastausLB.Visible = true;
                }
                laskurit++;
            }
            if (VastausLB.Visible == false)
            {
                VastausLB.Text = "Nimesi ei löytynyt suosituimpien nimien joukosta!";
                VastausLB.Visible = true;
            }
        }
    }
}
