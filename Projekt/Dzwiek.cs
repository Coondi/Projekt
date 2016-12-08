using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WMPLib;

namespace Projekt
{
    public class Dzwiek
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

        public void Graj()
        {
            if (!System.IO.File.Exists(this.Value))
            {
                Debug.WriteLine(string.Format("Klasa {0} nie ma zapisanego dźwięku {1}", this.GetType().Name, this.Key));
                return;
            }


            Thread newThread = new Thread(DoWork);
            newThread.Start(this);
        }

        public static void DoWork(object data)
        {
            Dzwiek dzwiek = data as Dzwiek;
            WindowsMediaPlayer wmp = new WindowsMediaPlayer();
            wmp.URL = dzwiek.Value;
            wmp.controls.play();

        }
    }
}
