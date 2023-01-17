using System;
//Robert Kajanti
namespace Harjoitus10
{
    class Program
    {
        static void Main(string[] args)
        {
            Varis Varis1 = new Varis("Varis", 90); //Luodaan varis olio

            Varis1.MakeASound(); //Käytetään metodio varis oliolle "äänen"  tuottamiseen
            Varis1.Fly(); //Käytetään metodia varis oliolle "lentämiseen"


            Kala Kala1 = new Kala("Ahven", "Blup Blup", 50); //Luodaan kala olio

            Kala1.MakeASound();
            Kala1.Swim();

            Sorsa Sorsa1 = new Sorsa("Sorsa", 120, 30);

            Sorsa1.MakeASound();
            Sorsa1.Swim();
            Sorsa1.Fly();

        }
    }
}
