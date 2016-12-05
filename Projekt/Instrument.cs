using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    public class Instrument
    {
        public Dictionary<string, string> dzwieki = new Dictionary<string, string>();

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
    }
}
