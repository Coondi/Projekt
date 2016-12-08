using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;


namespace Projekt
{
    public partial class Form1 : Form
    {
        List<Instrument> instrumenty = new List<Instrument>();
        List<Instrument> wybrane = new List<Instrument>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var instrumenty = PobierzInstrumenty();
            foreach (var item in instrumenty)
            {
                listaInstrumentów.Items.Add(item);
                listaInstrumentów.DisplayMember = "Name";

                var instrument = (Instrument)Activator.CreateInstance(item);
                

                var tmp = Instrument.Deserialization(instrument.Name);
                this.instrumenty.Add(tmp != null ? tmp : instrument);
           }

        }

        public static Type[] PobierzInstrumenty()
        {
            return Assembly.GetExecutingAssembly().GetTypes().Where(t => t.IsSubclassOf(typeof(Instrument))).ToArray();
        }

        private void listaInstrumentów_SelectedIndexChanged(object sender, EventArgs e)
        {
            var lista = sender as CheckedListBox;
            if (lista == null)
                return;

            int index = lista.SelectedIndex;
            lista.SetItemChecked(index, !lista.GetItemChecked(index));
        }

        private void btnDodajDźwięki_Click(object sender, EventArgs e)  //po kliknieciu przycisku dodaj dzwieki wyswietli sie drugie okienko
        {
            var noweOkienko = new Form2();
            noweOkienko.instrumenty = this.instrumenty;
            noweOkienko.ShowDialog();   
        }

        private void btnZapiszDzwieki_Click(object sender, EventArgs e)
        {
            foreach (var instrument in this.instrumenty)
                instrument.Serialization();
        }

        public void wybierzInstrument()
        {
            foreach (Type item in listaInstrumentów.SelectedItems)
            {
                foreach (var item2 in this.instrumenty)
                {
                    if (item.Name == item2.Name)
                    {
                        this.wybrane.Add(item2);
                    }
                }
            }
        }

        private void btnGraj_Click(object sender, EventArgs e)
        {
            wybierzInstrument();

            var melodia = Instrument.zamiana(tbMelodia.Text);

            foreach (var nazwaDzwieku in melodia)
            {
                Parallel.ForEach(this.wybrane, instrument => instrument.Graj(nazwaDzwieku));
                System.Threading.Thread.Sleep(1000); // w milisekundach            
            }

        }
    }
}
