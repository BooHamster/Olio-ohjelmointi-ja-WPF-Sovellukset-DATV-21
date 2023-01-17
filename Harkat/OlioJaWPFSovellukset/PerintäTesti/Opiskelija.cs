using System;
using System.Collections.Generic;
using System.Text;

namespace PerintäTesti
{
    class Opiskelija : Henkilö
    {
        public string OpiskelijaID { get; set; }
        public override string ToString()
        {
            return Nimi + " Toteutti metodin Opiskelija luokassa";
        }

        public override void Puhu()
        {
            Console.WriteLine(Nimi + " Puhui Opiskelija luokassa");
        }
    }
}
