using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BMIBT_Click(object sender, EventArgs e)
        {
            double paino = 0, pituus = 0;
            paino = Convert.ToDouble(painoTB.Text);
            pituus = Convert.ToDouble(pituusTB.Text);
            double bmi = Math.Round(paino / (pituus * pituus), 2);
            if (bmi < 18.5)
            {

                bmiLB.Text = "Painoindeksisi on: " + bmi;
                bmiLB.ForeColor = Color.Aqua;
                kuvausLB.Text = "Alipaino";
                kuvausLB.ForeColor = Color.Aqua;
                kuvausLB.Visible = true;
            }
            else if (bmi < 25)
            {
                bmiLB.Text = "Painoindeksisi on: " + bmi;
                bmiLB.ForeColor = Color.Green;
                kuvausLB.Text = "Normaalipaino";
                kuvausLB.ForeColor = Color.Green;
                kuvausLB.Visible = true;

            }
            else if (bmi < 40)
            {
                bmiLB.Text = "Painoindeksisi on: " + bmi;
                bmiLB.ForeColor = Color.Gold;
                kuvausLB.Text = "Ylipaino";
                kuvausLB.ForeColor = Color.Gold;
                kuvausLB.Visible = true;
            }
            else
            {
                bmiLB.Text = "Painoindeksisi on: " + bmi;
                bmiLB.ForeColor = Color.Red;
                kuvausLB.Text = "Huomattava ylipaino";
                kuvausLB.ForeColor = Color.Red;
                kuvausLB.Visible = true;

            }
        }
    }
}
