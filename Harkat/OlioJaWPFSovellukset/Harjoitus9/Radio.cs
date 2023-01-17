using System;
using System.Collections.Generic;
using System.Text;

namespace Harjoitus9
{
    class Radio //Radio olio
    {
        public Radio(string _nimi, bool _on, int _ääni, decimal _taajuus) //Määritellään konstruktori Radio oliolle
        {
            Nimi = _nimi;
            Päällä = _on;
            Äänenvoimakkuus = _ääni;
            taajuus = _taajuus;
        }

        public string Nimi;
        bool Päällä;
        private readonly int ÄänenVoimaMax = 9; //Maksimi äänenvoimakkuus muuttuja privaattina, jota käytetään vain luokan sisällä itse Äänenvoimakkuus muuttujan kontrolloimiseen
        private readonly int ÄänenVoimaMin = 0; //Minimi äänenvoimakkuus muuttuja privaattina, jota käytetään vain luokan sisällä itse Äänenvoimakkuus muuttujan kontrolloimiseen
        private readonly decimal MaxTaajuus = 107.9M; //käytetään desimaali muuttujia näissä missä tarvitaan, koska double on ihan paska ja tyhmä muuttuja
        private readonly decimal MinTaajuus = 88.0M;
        private decimal taajuus;
        private int äänenvoimakkuus;
        public decimal Taajuus        //Määritetään public Taajuus muuttujalle get set sisällöt, josta pääohjelma voi hakea private taajuus muuttujan arvon
        {
            get { return taajuus; }  //Pääohjelma saa tätä käyttämällä private taajuus arvon, ja voi myös asettaa sen
            set
            {
                if (value > MaxTaajuus) //Jos taajuus arvo asetetaan yli MaxTaajuus muuttujassa määritellyn arvon, niin if lauseen sisältö asettaa taajuus arvon takaisin MaxTaajuus arvoon
                {
                    value = MaxTaajuus;
                }
                else if(value < MinTaajuus) // Jos taajuus arvo asetetaan alle MinTaajuus muuttujassa määritellyn arvon, niin if lauseen sisältö asettaa taajuus arvon takaisin MinTaajuus arvoon
                    {
                        value = MinTaajuus;
                    }
                taajuus = value;
            }
        }

        public int Äänenvoimakkuus
        {
            get { return äänenvoimakkuus; }
            set
            {
                if (value > ÄänenVoimaMax)
                {
                    value = ÄänenVoimaMax;
                    Console.WriteLine("Radio on jo maksimi äänenvoimakkuudella!");
                }
                else
                if (value < ÄänenVoimaMin)
                {
                    value = ÄänenVoimaMin;
                    Console.WriteLine("Radio on jo minimi äänenvoimakkuudella!");
                }
                äänenvoimakkuus = value;
            }
        }

        public void TulostaData()
        {
            Console.WriteLine("Radio: ");
            Console.WriteLine("-- Nimi:  " + Nimi);
            if (Päällä == true)
            {
                Console.WriteLine("-- Radion tila Päällä ");
            }
            else
            {
                Console.WriteLine("-- Radio tila: Pois Päältä ");
            }
            Console.WriteLine("-- Taajuus:  " + Taajuus);
            Console.WriteLine("-- Äänenvoimakkuus:  " + Äänenvoimakkuus);
            Console.WriteLine("Käynnistä/Sammuta radio, Paina k");
            Console.WriteLine("Nosta taajuutta paina n, laske taajuutta paina l");
            Console.WriteLine("Nosta äänenvoimakkuutta paina w, laske äänenvoimakkuutta paina s");
            Console.Write("Poistu radion luota, anna p: ");
            Console.WriteLine();
        }

        public void ONJAOFF() //Metodi radion päälle ja pois päältä laittamiseen
        {
            if (Päällä != true)
            {
                Päällä = true;
            }
            else
            {
                Päällä = false;
            }
        }
        public void NostaÄänenVoimakkuutta(int i)  //Äänenvoimakkuutta nostava metodi
        {
            if(Päällä !=false)  //Metodi ei suorita if lausekkeen sisältöä jos radio ei ole päällä
            {
                Äänenvoimakkuus = Äänenvoimakkuus + i;
            }
            else //Tämä else lauseen sisältö toteutuu jos radio ei ole päällä
            {
                Console.WriteLine("Radio ei ole päällä! Tollo!");
                Console.Beep();
            }
        }
        public void LaskeÄänenVoimakkuutta(int i)
        {
            if (Päällä != false)
            {
                Äänenvoimakkuus = Äänenvoimakkuus - i;
            }
            else
            {
                Console.WriteLine("Radio ei ole päällä! Tollo!");
                Console.Beep();
            }
        }
        public void NostaTaajuutta(decimal i)
        {
            if (Päällä != false)
            {
                Taajuus = Taajuus + i;
            }
            else
            {
                Console.WriteLine("Radio ei ole päällä! Tollo!");
                Console.Beep();
            }
        }
        public void LaskeTaajuutta(decimal i)
        {
            if (Päällä != false)
            {
                Taajuus = Taajuus - i;
            }
            else
            {
                Console.WriteLine("Radio ei ole päällä! Tollo!");
                Console.Beep();
            }
        }

    }
}
