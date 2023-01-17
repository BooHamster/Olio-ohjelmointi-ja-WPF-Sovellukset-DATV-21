using System;
using System.Collections.Generic;
using System.Text;

namespace VahvistinTesti
{
    class Vahvistin
    {
        private int äänenvoimakkuus;

        public int Äänenvoimakkuus {
            get => äänenvoimakkuus; // Sama kuin { return äänenvoimakkuus; }
            set
            {
                //kun äänen voimakkuutta vaihdetaan, käydään alla oleva koodi läpi

                if(value > 100) // Jos arvo on suurempi kuin sata tämän if lauseen sisältö palautetaan
                {
                    Console.WriteLine("Annettu arvo oli suurempi kuin 100");
                    value = 100; //value arvo asetetaan 100 arvoon
                }
                else if(value <0) // Jos arvo on alempi kuin sata tämän if lauseen sisältö palautetaan
                {
                    Console.WriteLine("Annettu arvo oli pienempi kuin 0");
                    value = 0; //value arvo asetetaan 0 arvoon
                }
                Console.WriteLine("Äänenvoimakkuus asetettu, uusi arvo on: " + value); //Tämä rivi käydään joka tapauksessa aina läpi vaikka arvo olisi suurempi kuink 100 tai pienempi kuin 0

                äänenvoimakkuus = value; //private int äänenvoimakkuus arvo määritellään samaksi kuin value arvo
            }
    }
    }
}
