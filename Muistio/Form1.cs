﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Muistio
{
    public partial class NotepadForm : Form
    {
        private OpenFileDialog openFileDialog;
        private SaveFileDialog saveFileDialog;
        private FontDialog fontDialog;

        public NotepadForm()
        {
            InitializeComponent();
        }

        private void UusiTiedosto()
        {
            try
            {
                if (!string.IsNullOrEmpty(TekstiTB.Text))
                {
                    MessageBox.Show("Sinun tulee tallentaa ensin!");

                }
                else
                {
                    TekstiTB.Text = string.Empty;
                    Text = "Nimetön";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Virhe: " + ex);
            }
        }
        private void TallennaTiedosto()
        {
            try
            {
                catch (Exception ex)
            {
                MessageBox.Show("Virhe avattaessa! " + ex);
            }
        }
            catch (Exception ex)
            {
                MessageBox.Show("Virhe: " + ex);
            }

        }

        private void AvaaTiedosto()
        {
            try
            {
                openFileDialog = new OpenFileDialog();
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    TekstiTB.Text = File.ReadAllText(openFileDialog.FileName);
                }




    }




        private void tiedostoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void NotepadForm_Load(object sender, EventArgs e)
        {

        }

        private void uusiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UusiTiedosto();
        }

        private void avaaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AvaaTiedosto();
        }

        private void tallennaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TallennaTiedosto();
        }

        private void lopetaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Virhe avattaessa! " + ex);
            }
        }

        private void kirjasinToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
