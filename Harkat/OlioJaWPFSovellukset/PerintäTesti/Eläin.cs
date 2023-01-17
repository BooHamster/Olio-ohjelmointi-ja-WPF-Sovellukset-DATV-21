using System;
using System.Collections.Generic;
using System.Text;

namespace PerintäTesti
{
    class Eläin //Eläin yliluokka
    {
        public string Nimi { get; set; }
        private static int instanssit = 0;

        public Eläin()
            {
                instanssit++;
            }

        public static void KuinkaMonta()
        {
            Console.WriteLine("Eläimiä luotu " + instanssit);
        }
        public virtual void Ääntele() //Virtuaalinen metodi jonka voi ylikirjoitetaan aliluokissa esim.
        {
            Console.WriteLine("Eläin ääntelee");
        }
    }
}
