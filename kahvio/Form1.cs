using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kahvio
{
    public partial class RuokalistaForm : Form
    {
        public RuokalistaForm()
        {
            InitializeComponent();
            meistaPL.Visible = true;
        }

        private void koriPL_Paint(object sender, PaintEventArgs e)
        {

        }

        private void RuokalistaForm_Load(object sender, EventArgs e)
        {
            meistaLB.Text = "Ollin Kahvila palvelee luokassa 209 välituntisin \n";
            meistaLB.Text += "8:00 - 15:00 joka arkipäivä! \n";
            meistaLB.Text += "9:00 - 12:00.\n\n Ollin Kahvilasta saa lämpimien";
            meistaLB.Text += "juomien lisäksi virvokkeita sekä purtavaa ja makeisia\n";
            meistaLB.Text += "Tervetuloa tutustumaan!\n";
            meistaLB.Font = new Font("Arial", 12);
        }

        private void meistaBT_Click(object sender, EventArgs e)
        {
            meistaPL.Visible = true;
            ruoatPL.Visible = false;
            juomatPL.Visible = false;
            herkutPL.Visible = false;
            koriPL.Visible = false;

        }

        private void ruoatBT_Click(object sender, EventArgs e)
        {
            meistaPL.Visible = false;
            ruoatPL.Visible = true;
            juomatPL.Visible = false;
            herkutPL.Visible = false;
            koriPL.Visible = false;

        }

        private void juomatBT_Click(object sender, EventArgs e)
        {
            meistaPL.Visible = false;
            ruoatPL.Visible = false;
            juomatPL.Visible = true;
            herkutPL.Visible = false;
            koriPL.Visible = false;

        }

        private void herkutBT_Click(object sender, EventArgs e)
        {
            meistaPL.Visible = false;
            ruoatPL.Visible = false;
            juomatPL.Visible = false;
            herkutPL.Visible = true;
            koriPL.Visible = false;

        }

        private void koriBT_Click(object sender, EventArgs e)
        {
            meistaPL.Visible = false;
            ruoatPL.Visible = false;
            juomatPL.Visible = false;
            herkutPL.Visible = false;
            koriPL.Visible = true;

        }
    }
}