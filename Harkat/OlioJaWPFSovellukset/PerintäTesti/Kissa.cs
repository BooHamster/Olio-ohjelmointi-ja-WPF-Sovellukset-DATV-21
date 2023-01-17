using System;
using System.Collections.Generic;
using System.Text;

namespace PerintäTesti
{
    class Kissa : Eläin //Kissa aliluokka, perii Eläin yliluokan : Eläin toiminnolla
    {
        private static int instanssit = 0;

        public Kissa()
        {
            instanssit++;
        }

        public static new void KuinkaMonta()
        {
            Console.WriteLine("Kissoja luotu " + instanssit);
        }
        public override void Ääntele() //ylikirjoitetaan Eläin luokan metodi
        {
            Console.WriteLine("Miau!");
        }

    }
}
