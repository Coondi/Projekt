using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Projekt
{
    public class Instrument
    {
        public List<Dzwiek> dzwieki { get; set; }

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
            this.dzwieki = new List<Dzwiek>();
            dzwieki.Add(new Dzwiek("C", ""));
            dzwieki.Add(new Dzwiek("D", ""));
            dzwieki.Add(new Dzwiek("E", ""));
            dzwieki.Add(new Dzwiek("F", ""));
            dzwieki.Add(new Dzwiek("G", ""));
            dzwieki.Add(new Dzwiek("A", ""));
            dzwieki.Add(new Dzwiek("H", ""));
            dzwieki.Add(new Dzwiek("C2", ""));
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

        public static Instrument Deserialization(string name)
        {
            if (!File.Exists(name + ".xml"))
            {
                return null;
            }

            var typ = Assembly.GetExecutingAssembly().GetTypes().First(t => t.Name == name);

            XmlSerializer xml = new XmlSerializer(typ);
            XmlReader reader = XmlReader.Create(name + ".xml");

            var wynik = xml.Deserialize(reader) as Instrument;
            wynik.dzwieki = wynik.dzwieki.Skip(8).ToList();

            reader.Close();
            return wynik;
        }
    }
}
