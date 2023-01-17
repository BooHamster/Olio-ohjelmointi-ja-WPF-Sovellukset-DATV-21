using System;
using System.Collections.Generic;
using System.Text;

namespace Harjoitus13
{
    class Poikkeukset : Exception //Virhe luokka
    {
        public Poikkeukset(string message) : base(message) //Määritetään virheilmoituksessa string muuttuja mikä voidaan asettaa haluamaksi Console.WriteLinella, ja se voidaan asettaa myös itse Virheilmoitus "Otsikkoon" = base(message)
        {
            Console.WriteLine();
            Console.WriteLine("-----VIRHE-----");
            Console.WriteLine("Virhe: " + message);
            Console.WriteLine("-----VIRHE-----");
            Console.WriteLine();
        }
    }
}
