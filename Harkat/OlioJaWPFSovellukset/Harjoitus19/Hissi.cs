using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus19
{
    class Hissi //Hissiluokka
    {
        //Muuttujat
        private readonly int MaxKerros = 6;
        private readonly int MinKerros = 1;
        private int kerros { get; set; }
        public int Kerros
        {
            get { return kerros; }
            set
            {
                if (value > MaxKerros)
                {
                    value = MaxKerros;
                }
                else if (value < MinKerros)
                {
                    value = MinKerros;
                }
                kerros = value;
            }
        }
        public Hissi(int _kerros)
        {
            Kerros = _kerros;
        }

        public void KerrosYlös() //Kerroksen nostamisen metodi
        {
            Kerros++;
        }

        public void KerrosAlas() //Kerroksen laskemisen metodi
        {
            Kerros--;
        }

        public string ToString()
        {
            return "Olet " + Kerros + " Kerroksessa";
        }

        public void AsetaKerros(int i) // Kerroksen asettamisen metodi
        {
            Kerros = i;
        }
    }
}
