using System;
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
            var dzwiek = (Dzwiek)cb.SelectedItem;
            

            var instrument = cbInstrumenty.SelectedItem as Instrument;

            tbSciezka.Text = instrument.pobierzDzwiek(dzwiek.Key).Value;

        }

        private void btnZapisz_Click(object sender, EventArgs e)
        {          
            var instrument = cbInstrumenty.SelectedItem as Instrument;        
            var dzwiek = (Dzwiek)cbDzwieki.SelectedItem;

            instrument.pobierzDzwiek(dzwiek.Key).Value = tbSciezka.Text;
        }


    }
}
