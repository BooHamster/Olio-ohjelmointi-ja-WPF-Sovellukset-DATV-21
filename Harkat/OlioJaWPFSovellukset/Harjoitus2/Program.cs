using System;
//Robert Kajanti
namespace Harjoitus2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Luodaan Opiskelija Olio
            Opiskelija Opiskelija1 = new Opiskelija("Pelle", "TVT123", 10); //Luodaan uusi opiskelija Olio

            Opiskelija1.TulostaData(); //Käytetään Opiskelija luokan sisäisiä metodeja luodulle Opiskelija oliolle
            Opiskelija1.MuokkaaOpintopisteitä(5);
            Opiskelija1.TulostaData();
        }
    }
}
