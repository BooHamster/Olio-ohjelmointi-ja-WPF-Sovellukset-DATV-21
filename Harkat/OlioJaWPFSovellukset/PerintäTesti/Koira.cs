using System;
using System.Collections.Generic;
using System.Text;

namespace PerintäTesti
{
    class Koira : Eläin //Koira aliluokka, perii Eläin yliluokan : Eläin toiminnolla
    {
        private static int instanssit = 0;

        public Koira()
        {
            instanssit++;
        }

        public static new void KuinkaMonta()
        {
            Console.WriteLine("Koiria luotu " + instanssit);
        }
        public override void Ääntele() //ylikirjoitetaan Eläin luokan metodi
        {
            Console.WriteLine("Woof");
        }
    }
}
