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
           
        }

        public static Type[] PobierzInstrumenty()
        {
            return Assembly.GetExecutingAssembly().GetTypes().Where(t => t.IsSubclassOf(typeof(Instrument))).ToArray();
        }



    }
}
