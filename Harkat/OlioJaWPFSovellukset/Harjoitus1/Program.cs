using System;
//Robert Kajanti
namespace Harjoitus1
{
    class Program
    {
        static void Main(string[] args)
        {
            Ajoneuvo auto = new Ajoneuvo(); // Olio Ajoneuvo luokasta
            //Asetetaan oliolle "auto" arvot
            auto.Nimi = "Toyta";
            auto.Nopeus = 160;
            auto.Renkaat = 4;

            // Käytetään Ajoneuvo luokan toimintoja
            auto.TulostaData();

            //Noudetaan auton tiedot ToString() metodilla
            string autontiedot = auto.ToString();
            Console.WriteLine(autontiedot);

            //Tyhjä rivi konsoliin
            Console.WriteLine();

            //Luodaan toinen olio luokasta Ajoneuvo

            Ajoneuvo mopo = new Ajoneuvo(); // Olio ajoneuvo luokasta
            mopo.Nimi = "Yamaha";
            mopo.Nopeus = 200;
            mopo.Renkaat = 2;

            // Käytetään Ajoneuvo luokan toimintoja
            mopo.TulostaData();

           
            Console.WriteLine(mopo.ToString());

            /*
            Koira mopsi = new Koira("Höpö", 15, "Mopsi"); //Luo Uuden Olion
            Koira Mäyrä = new Koira("Töpö", 10, "MäyräKoira");
            Koira Kultainen = new Koira("Löpö", 5, "KultainenNoutaja");
            mopsi.Nimi = "Höpö";
            mopsi.Ikä = 15;
            mopsi.Rotu = "Mopsi";

            Mäyrä.Nimi = "Töpö";
            Mäyrä.Ikä = 10;
            Mäyrä.Rotu = "Mäyräkoira";


            Console.WriteLine(mopsi.HaeTiedot());
            mopsi.Hauku();
            mopsi.Hauku();
            mopsi.Hauku();

            Console.WriteLine(Mäyrä.HaeTiedot());
            Mäyrä.Hauku();
            Mäyrä.Hauku();
            Mäyrä.Hauku();
            */

        }

    }
}
