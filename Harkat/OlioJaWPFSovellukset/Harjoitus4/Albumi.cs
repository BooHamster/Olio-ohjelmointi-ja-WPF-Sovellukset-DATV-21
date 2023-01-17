using System;
using System.Collections.Generic;
using System.Text;

namespace Harjoitus4
{
    class Albumi
    {
        //Määritellään albumin attribuutit
        public string Artisti;
        public string Nimi;
        public string Genre;
        public string Hinta;
        public List<string> Kappaleet = new List<string>(); //Tämä luo uuden string tyyppisen listan albumin luokan sisällä
        public List<Kappale> Kappaleet2 = new List<Kappale>(); //Tämä luo uuden kappale luokan tyyppisen listan albumin sisällä

            Kappale YourSong = new Kappale("---Your Song", "3:50"); //Tämä luo Kappale olion Albumi luokan sisällä
            Kappale RocketMan = new Kappale("---Rocket Man", "2:40");
            Kappale TinyDancer = new Kappale("---Tiny Dancer", "4:15");
            Kappale Levon = new Kappale("---Levon", "3:50");
            Kappale CrocodileRock = new Kappale("---Crocodile Rock", "2:50");
            Kappale CandleInTheWind = new Kappale("---Candle In The Wind", "2:59");
            Kappale SomeoneSavedMyLifeTonight = new Kappale("---Someone saved my life Tonight", "3:30");
            Kappale MonaLisasAndMadHatters = new Kappale("---Mona Lisas and Mad Hatters", "3:20");
            Kappale CanYouFeelTheLoveTonight = new Kappale("---Can you feel the love tonight", "3:10");

        public void LisääKappale() //Tämä metodi lisää albumin string tyyppiseen listaan kappaleita, albumin sisällä
        {
            Kappaleet.Add("---RocketMan - 3:50");
            Kappaleet.Add("---TinyDancerYourSong, 2:40");
            Kappaleet.Add("---Levon, 4:15");
            Kappaleet.Add("---CrocodileRock, 2:50");
            Kappaleet.Add("---CandleInTheWind, 2:59");
            Kappaleet.Add("---SomeoneSavedMyLifeTonight, 3:30");
            Kappaleet.Add("---MonaLisasAndMadHatters, 3:20");
            Kappaleet.Add("--CanYouFeelTheLoveTonight, 3:10");
        }

        public void LisääKappale2() //Tämä metodi lisää Konsoliin itse kirjoitetun kappaleen string tyyppiseen listaan
        {
            Kappaleet.Add(Console.ReadLine());
        }


        public void TulostaAlbumi() //Tämä metodi tulostaa Albumin tiedot muuttujista
        {
            Console.WriteLine();
            Console.WriteLine("Albumi: ");
            Console.WriteLine("-- Artisti:  " + Artisti);
            Console.WriteLine("-- Nimi:  " + Nimi);
            Console.WriteLine("-- Genre:  " + Genre);
            Console.WriteLine("-- Hinta:  " + Hinta);
            Console.WriteLine();
            Console.WriteLine("Songs: ");
        }
        public void TulostaKappaleet()
        {          
            Kappaleet.ForEach(Console.WriteLine); //Tulostaa kappaleiden tiedot, tämä metodi toimii jos Lista on string tyyppinen <string>, mutta ei jos list on luokan Kappale tyyppiä <Kappale>
        }

        public void TulostaKappaleet2()
        {
            foreach (Kappale Kappale in Kappaleet2) //Tämä metodi toimii jos lista on Kappale luokan tyyppinen <Kappale>, mutta ei jos lista on string tyyppinen <string>
            {
                Console.WriteLine(Kappale.ToString());
            }
        }
    }
}
