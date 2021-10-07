using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;

namespace CRUD
{
    public partial class Form1 : Form
    {
        OPISKELIJA opiskelija = new OPISKELIJA();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TietotauluDG.DataSource = opiskelija.haeOpiskelijat();
        }





        private void TyhjennaBT_Click(object sender, EventArgs e)
        {
            IdTB.Text = "";
            EnimiTB.Text = "";
            SnimiTB.Text = "";
            PuhTB.Text = "";
            EmailTB.Text = "";
            ONroTB.Text = "";
        }

        private void TallennaBT_Click(object sender, EventArgs e)
        {
            String enimi = EnimiTB.Text;
            String snimi = SnimiTB.Text;
            String puhelin = PuhTB.Text;
            String email = EmailTB.Text;
            int oNro = Int32.Parse(ONroTB.Text);

            if (enimi.Trim().Equals("") || snimi.Trim().Equals("") || puhelin.Trim().Equals("") || email.Trim().Equals("") || oNro.Equals(""))
            {
                MessageBox.Show("VIRHE - täytä kentät", "tyhjä kenttä", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                Boolean lisaAsiakas = opiskelija.lisaaOpiskelija(enimi, snimi, puhelin, email, oNro);
                if (lisaAsiakas)
                {
                    MessageBox.Show("Uusi opiskelia lisätty", "Opiskelijan lisäys", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Uutta opiskeliaa ei pystytty lisäämään", "Opiskelijan lisäys", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            TietotauluDG.DataSource = opiskelija.haeOpiskelijat();

        }

        private void PaivitaBT_Click(object sender, EventArgs e)
        {
            String enimi = EnimiTB.Text;
            String snimi = SnimiTB.Text;
            String puhelin = PuhTB.Text;
            String email = EmailTB.Text;
            int oNro = Int32.Parse(ONroTB.Text);
            int oid = Int32.Parse(IdTB.Text);

            if (enimi.Trim().Equals("") || snimi.Trim().Equals("") || puhelin.Trim().Equals("") || email.Trim().Equals("") || oNro.Equals(""))
            {
                MessageBox.Show("VIRHE - täytä kentät", "tyhjä kenttä", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                Boolean lisaAsiakas = opiskelija.muokkaaOpiskelijaa(oid, enimi, snimi, puhelin, email, oNro);
                if (lisaAsiakas)
                {
                    MessageBox.Show(" opiskelia päivitetty", "Opiskelijan päivitys", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("opiskeliaa ei pystytty päivittämään", "Opiskelijan päivitys", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            TietotauluDG.DataSource = opiskelija.haeOpiskelijat();

        }

        private void TietotauluDG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            IdTB.Text = TietotauluDG.CurrentRow.Cells[0].Value.ToString();
            EnimiTB.Text = TietotauluDG.CurrentRow.Cells[1].Value.ToString();
            SnimiTB.Text = TietotauluDG.CurrentRow.Cells[2].Value.ToString();
            PuhTB.Text = TietotauluDG.CurrentRow.Cells[3].Value.ToString();
            EmailTB.Text = TietotauluDG.CurrentRow.Cells[4].Value.ToString();
            ONroTB.Text = TietotauluDG.CurrentRow.Cells[5].Value.ToString();
        }

        private void PoistaTB_Click(object sender, EventArgs e)
        { 
            String ktunnus = IdTB.Text;
            if (opiskelija.poistaOpiskelija(ktunnus))
            {
                TietotauluDG.DataSource = opiskelija.haeOpiskelijat();
                MessageBox.Show("Opiskelja poistettu", "Opiskelijan poisto", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Opiskelija ei pystytty poistamaan", "opiskelijan poisto", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            TyhjennaBT.PerformClick();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String enimi = EnimiTB.Text;
            String snimi = SnimiTB.Text;
            String puhelin = PuhTB.Text;
            String email = EmailTB.Text;
            int oNro = Int32.Parse(ONroTB.Text);
            int oid = Int32.Parse(IdTB.Text);

            if (enimi.Trim().Equals("") || snimi.Trim().Equals("") || puhelin.Trim().Equals("") || email.Trim().Equals("") || oNro.Equals(""))
            {
                MessageBox.Show("VIRHE - täytä kentät", "tyhjä kenttä", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                Boolean lisaAsiakas = opiskelija.muokkaaOpiskelijaa(oid, enimi, snimi, puhelin, email, oNro);
                if (lisaAsiakas)
                {
                    MessageBox.Show(" opiskelia päivitetty", "Opiskelijan päivitys", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("opiskeliaa ei pystytty päivittämään", "Opiskelijan päivitys", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            TietotauluDG.DataSource = opiskelija.haeOpiskelijat();
        }
    }
}