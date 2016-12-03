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
                this.instrumenty.Add(instrument);
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

        private void btnDodajDźwięki_Click(object sender, EventArgs e)
        {
            
        }
    }
}
