﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Roomalaisetnumerot
{
    public partial class Form : System.Windows.Forms.Form
    {
        private const int StartIndex = 0;

        public Form()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int luku1, luku2, luku3, luku4;
            string vastaus = "";
            if (TextBoxTB.Text.Length > 3) // 4 lukua
            {
                luku1 = Convert.ToInt32(TextBoxTB.Text.Substring(0, 1));
                luku2 = Convert.ToInt32(TextBoxTB.Text.Substring(1, 1));
                luku3 = Convert.ToInt32(TextBoxTB.Text.Substring(2, 1));
                luku4 = Convert.ToInt32(TextBoxTB.Text.Substring(3, 1));
                if (luku1 % 3 == 0)
                {
                    vastaus += "MMM";
                }
                else if (luku1 % 2 == 0)
                {
                    vastaus += "MM";
                }
                else if (luku1 % 1 == 0)
                {
                    vastaus += "M";
                }
                vastaus += sataset(luku2, vastaus);
                vastaus += kympit(luku3, vastaus);
                vastaus += ykkoset(luku4, vastaus);
                VastausLB.Text = vastaus;
                VastausLB.Visible = true;
            }
            else if (TextBoxTB.Text.Length > 2)
            {
                luku2 = Convert.ToInt32(TextBoxTB.Text.Substring(0, 1));
                luku3 = Convert.ToInt32(TextBoxTB.Text.Substring(1, 1));
                luku4 = Convert.ToInt32(TextBoxTB.Text.Substring(2, 1));
                vastaus += sataset(luku2, vastaus);
                vastaus += kympit(luku3, vastaus);
                vastaus += ykkoset(luku4, vastaus);
                VastausLB.Text = vastaus;
                VastausLB.Visible = true;
            }
            else if (TextBoxTB.Text.Length > 1)
            {
                luku3 = Convert.ToInt32(TextBoxTB.Text.Substring(0, 1));
                luku4 = Convert.ToInt32(TextBoxTB.Text.Substring(1, 1));
                vastaus += kympit(luku3, vastaus);
                vastaus += ykkoset(luku4, vastaus);
                VastausLB.Text = vastaus;
                VastausLB.Visible = true;
            }
            else
            {
                luku4 = Convert.ToInt32(TextBoxTB.Text.Substring(0, 1));
                vastaus += ykkoset(luku4, vastaus);
                VastausLB.Text = vastaus;
                VastausLB.Visible = true;
            }
        }

        private static string sataset(int luku2, string vastaus)
        {
            if (luku2 % 9 == 0 && luku2 != 0)
            {
                return "CM";
            }
            else if (luku2 % 8 == 0 && luku2 != 0)
            {
                return "DCCC";
            }
            if (luku2 % 7 == 0 && luku2 != 0)
            {
                return "DCC";
            }
            else if (luku2 % 6 == 0 && luku2 != 0)
            {
                return "DC";
            }
            else if (luku2 % 5 == 0 && luku2 != 0)
            {
                return "D";
            }
            else if (luku2 % 4 == 0 && luku2 != 0)
            {
                return "CD";
            }
            else if (luku2 % 3 == 0 && luku2 != 0)
            {
                return "CCC";
            }
            else if (luku2 % 2 == 0 && luku2 != 0)
            {
                return "CC";
            }
            else if (luku2 % 1 == 0 && luku2 != 0)
            {
                return "C";
            }
            else
            {
                return "";
            }
        }

        private static string ykkoset(int luku4, string vastaus)
        {
            if (luku4 % 9 == 0 && luku4 != 0)
            {
                return "IX";
            }
            if (luku4 % 8 == 0 && luku4 != 0)
            {
                return "VIII";
            }
            else if (luku4 % 7 == 0 && luku4 != 0)
            {
                return "VII";
            }
            else if (luku4 % 6 == 0 && luku4 != 0)
            {
                return "VI";
            }
            else if (luku4 % 5 == 0 && luku4 != 0)
            {
                return "V";
            }
            else if (luku4 % 4 == 0 && luku4 != 0)
            {
                return "IV";
            }
            else if (luku4 % 3 == 0 && luku4 != 0)
            {
                return "III";
            }
            else if (luku4 % 2 == 0 && luku4 != 0)
            {
                return "II";
            }
            else if (luku4 % 1 == 0 && luku4 != 0)
            {
                return "I";
            }
            else
            {
                return "";
            }
        }

        private static string kympit(int luku3, string vastaus)
        {
            if (luku3 % 9 == 0 && luku3 != 0)
            {
                return "XC";
            }
            if (luku3 % 8 == 0 && luku3 != 0)
            {
                return "LCCC";
            }
            else if (luku3 % 7 == 0 && luku3 != 0)
            {
                return "LCC";
            }
            else if (luku3 % 6 == 0 && luku3 != 0)
            {
                return "LC";
            }
            else if (luku3 % 5 == 0 && luku3 != 0)
            {
                return "L";
            }
            else if (luku3 % 4 == 0 && luku3 != 0)
            {
                return "LX";
            }
            else if (luku3 % 3 == 0 && luku3 != 0)
            {
                return "XXX";
            }
            else if (luku3 % 2 == 0 && luku3 != 0)
            {
                return "XX";
            }
            else if (luku3 % 1 == 0 && luku3 != 0)
            {
                return "X";
            }
            else
            {
                return "";
            }
        }
    }
}