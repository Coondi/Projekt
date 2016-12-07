using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Projekt
{
    public class Instrument
    {
        public Dictionary<string, string> dzwieki = new Dictionary<string, string>();

        [System.Xml.Serialization.XmlIgnoreAttribute]
        public string Name
        {
            get
            {
                return this.GetType().Name;
            }
        }

        protected Instrument()
        {
            dzwieki.Add("C", "");
            dzwieki.Add("D", "");
            dzwieki.Add("E", "");
            dzwieki.Add("F", "");
            dzwieki.Add("G", "");
            dzwieki.Add("A", "");
            dzwieki.Add("H", "");
            dzwieki.Add("C2", "");
        }

        public void Serialization()
        {
            XmlSerializer xml = new XmlSerializer(this.GetType());

            TextWriter writer = new StreamWriter(this.GetType().Name + ".xml");
            xml.Serialize(writer, this);
            writer.Close();
            xml = null;
            writer = null;
        }
    }
}
