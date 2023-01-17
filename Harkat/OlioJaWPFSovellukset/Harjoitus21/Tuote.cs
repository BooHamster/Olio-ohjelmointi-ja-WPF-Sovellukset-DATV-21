using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus21
{
    class Tuote //Tuote luokka
    {
        //Muuttujat
        public string Nimi { get; set; }
        public decimal Hinta { get; set; }
        public bool Valittuna { get; set; }

        public Tuote(string nimi, decimal hinta) //Konstruktori
        {
            Nimi = nimi;
            Hinta = hinta;
            Valittuna = false;
        }
       public string HaeData() //Tietojen tulostus metodi
       {
           return Nimi + " " + Hinta + " Euroa";
       }
    }
}
