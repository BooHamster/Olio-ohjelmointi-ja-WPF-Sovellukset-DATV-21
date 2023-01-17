using System;
using System.Collections.Generic;
using System.Text;

namespace Harjoitus10
{
    class Varis : Eläin, ICanFly
    {
        public float WingSize { get; set; }

        public Varis(string _nimi, float _wingsize)
        {
            Nimi = _nimi;
            WingSize = _wingsize;
        }
        public void Fly()
        {
            Console.WriteLine("{0} lentää. Siipien koko on {1}", Nimi, WingSize);
        }

        public override void MakeASound()
        {
            Console.WriteLine("KaKaaw KaKaaw");
        }
    }
}
