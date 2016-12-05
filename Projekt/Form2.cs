﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt
{
    public partial class Form2 : Form
    {
        public List<Instrument> instrumenty;

        public Form2()
        {
            InitializeComponent();
        }

        private void btnPrzegladaj_Click(object sender, EventArgs e) // po klikniecu przycisku przegladaj(...) wyswietla okno dialogowe do przegladania
        {
            var wynik = openFileDialog1.ShowDialog();
            if (wynik != DialogResult.OK)
                return;
            tbSciezka.Text = openFileDialog1.FileName;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            foreach (var instrument in this.instrumenty)
            {
                cbInstrumenty.Items.Add(instrument);
            }
            cbInstrumenty.DisplayMember = "Name";
        }

        private void cbInstrumenty_SelectedIndexChanged(object sender, EventArgs e)
        {
            var cb = sender as ComboBox;
            var instrument = cb.SelectedItem as Instrument;

            foreach (var dzwiek in instrument.dzwieki)
            {
                cbDzwieki.Items.Add(dzwiek);
            }
            cbDzwieki.DisplayMember = "Key";
        }

        private void cbDzwieki_SelectedIndexChanged(object sender, EventArgs e)
        {
            var cb = sender as ComboBox;
            var dzwiek = (KeyValuePair<string, string>)cb.SelectedItem;
            tbSciezka.Text = dzwiek.Value;
        }

        private void bt1Zapisz_Click(object sender, EventArgs e)
        {
            var cbI = sender as ComboBox;
            var instrument = cbI.SelectedItem as Instrument;
            var cbD = sender as ComboBox;
            var dzwiek = (KeyValuePair<string, string>)cbD.SelectedItem;

            instrument.dzwieki[dzwiek.Key] = tbSciezka.Text;
        }
    }
}
