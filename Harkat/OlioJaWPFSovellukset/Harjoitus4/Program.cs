using System;
using System.Collections.Generic;
//Robert Kajanti
namespace Harjoitus4
{
    class Program 
    {
        static void Main(string[] args)
        {
            Albumi GreatestHitsEltonJohn = new Albumi(); //Luodaan Albumi olio ja määritellään konstruktorin määrittelemät muuttuja arvot
            GreatestHitsEltonJohn.Artisti = "Elton John";
            GreatestHitsEltonJohn.Nimi = "Greatest Hits";
            GreatestHitsEltonJohn.Genre = "Pop";
            GreatestHitsEltonJohn.Hinta = "50 £";

            GreatestHitsEltonJohn.LisääKappale();            //Suoritetaan metodi kappaleiden lisäämiseen Albumi olioon
            GreatestHitsEltonJohn.TulostaAlbumi();          //Tulostetaan Albumin tiedot metodilla
            GreatestHitsEltonJohn.TulostaKappaleet();       //Tulostetaan Albumin Kappaleiden tiedot metodilla
            Kappale GoodByeYellowBrickRoad = new Kappale("Goodbye Yellow Brick Road", "3:80"); //Luodaan kappale olio
            Kappale DontGoBreaking = new Kappale("Don't go breaking my heart", "4:80");
            GreatestHitsEltonJohn.Kappaleet2.Add(GoodByeYellowBrickRoad); //Lisätään kappale olio albumiin kappale tyyppiseen listaan
            GreatestHitsEltonJohn.Kappaleet2.Add(DontGoBreaking);
            GreatestHitsEltonJohn.TulostaKappaleet2(); //Tulostetaan kappale tyyppisen listan kappaleet Konsoliin

            Albumi MichaelJackson = new Albumi(); 
            Kappale SpeedDemon = new Kappale("SpeedDemon", "3:00");
            MichaelJackson.Artisti = "Michael Jackson";
            MichaelJackson.Nimi = "Thriller";
            MichaelJackson.Genre = "Pop";
            MichaelJackson.Hinta = "100 £";

            MichaelJackson.Kappaleet.Add("---Thriller, 5:60");
            MichaelJackson.Kappaleet.Add("---Beat it, 3:60");
            MichaelJackson.Kappaleet.Add("---Man in the mirror, 6:40");
            MichaelJackson.Kappaleet.Add("---Smooth criminal, 3:40");
            MichaelJackson.Kappaleet.Add("---Earth Song, 5:20");
            MichaelJackson.Kappaleet2.Add(SpeedDemon);
            MichaelJackson.LisääKappale2();
            MichaelJackson.TulostaAlbumi();
            MichaelJackson.TulostaKappaleet();
            MichaelJackson.TulostaKappaleet2();





        }
    }
}
