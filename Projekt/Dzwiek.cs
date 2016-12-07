using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    class Dzwiek
    {
        public string Key { get; set; }
        public string Value { get;  set; }

        public Dzwiek()
        {

        }

        public Dzwiek(string Key, string Value)
        {
            this.Key = Key;
            this.Value = Value;
        }
    }
}
