using System;
using System.Collections.Generic;
using System.Text;

namespace PerintäTesti
{
    class Henkilö
    {
        public string Nimi { get; set; }
        public int Ikä { get; set; }

        public virtual string VirtuaalinenMerkkijono { get; set; }
        public override string ToString()
        {
            return Nimi + " Toteutti metodin Henkilö Luokassa";
        }

        public virtual void Puhu()
        {
            Console.WriteLine(Nimi+ " Puhui henkilö luokassa");
        }
    }
}
