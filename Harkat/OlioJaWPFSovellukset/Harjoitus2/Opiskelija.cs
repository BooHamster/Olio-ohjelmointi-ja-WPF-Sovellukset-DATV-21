using System;
using System.Collections.Generic;
using System.Text;

namespace Harjoitus2
{
    class Opiskelija //Opiskelija luokka
    {
        private string Nimi { get; set; } //Opiskelija luokan muuttujat
        private string OpiskelijaID { get; set; }
        private int OpintoPisteet { get; set; }


        //Konstruktori
        public Opiskelija(string _nimi, string _id, int _op) //Konstruktori, aina kun opiskelija luokan olio luodaan, konstruktorin sisältämät tiedot täytyy määritellä oliolle
        {
            Nimi = _nimi;  //Konstruktorissa voidaan nimetä määriteltäville luokan muuttujille nimikkeet
            OpiskelijaID = _id;
            OpintoPisteet = _op;
        }

        public void TulostaData() //Metodi luokan tietojen tulostukseen Console.Writelinellä eri riveille
        {
            Console.WriteLine();
            Console.WriteLine("Opiskelija: ");
            Console.WriteLine("-- Nimi:  " + Nimi);
            Console.WriteLine("-- OpiskelijaID:  " + OpiskelijaID);
            Console.WriteLine("-- OpintoPisteet:  " + OpintoPisteet);
            Console.WriteLine();
        }

        //Metodi joka ottaa parametriksi integer - arvon
        public void MuokkaaOpintopisteitä(int i)  //Kun metodia kutsutaan, täytyy samalla asettaa kokonaisluku(int) mitä metodi käyttää
        {
            OpintoPisteet = OpintoPisteet +i;
            if (OpintoPisteet < 0)
            {
                OpintoPisteet = 0;
            }
        }
    }
}
