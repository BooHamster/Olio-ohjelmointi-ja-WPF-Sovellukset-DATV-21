using System;
using System.Collections.Generic;
using System.Text;

namespace Harjoitus5
{
    class Laskin //Laskin luokka
    {
        public float ValueA { get; set; } //Laskin luokan muuttujat
        public float ValueB { get; set; }
        public float Summa1;
        public float Erotus1;
        public float KertoLasku1;
        public float JakoLasku1;


        public void Summa() //metodi summan laskemiseen käyttäen kahta muuttujaa
        {
            Summa1 = ValueA + ValueB;
            Console.WriteLine("Tulokseksi tuli {0}", Summa1);
        }

        public void Erotus() //metodi erotuksen laskemiseen käyttäen kahta muuttujaa
        {
            Erotus1 = ValueA - ValueB;
            Console.WriteLine("Tulokseksi tuli {0}", Erotus1);
        }
        public void KertoLasku() //metodi kertomisen laskemiseen käyttäen kahta muuttujaa
        {
            KertoLasku1 = ValueA * ValueB;
            Console.WriteLine("Tulokseksi tuli {0}", KertoLasku1);
        }

        public void JakoLasku() //metodi jaon laskemiseen käyttäen kahta muuttujaa
        {
            JakoLasku1 = ValueA / ValueB;
            Console.WriteLine("Tulokseksi tuli {0}", JakoLasku1);
        }

    }
}
