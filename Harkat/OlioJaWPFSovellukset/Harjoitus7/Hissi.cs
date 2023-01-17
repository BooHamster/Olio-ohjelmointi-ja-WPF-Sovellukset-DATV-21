using System;
using System.Collections.Generic;
using System.Text;

namespace Harjoitus7
{
    class Hissi //Hissi luokka
    {
        private readonly int MaxKerros = 6; //privaatti muuttuja johon ei pääse käsiksi kuin luokan sisältä, ja vain luku ominaisuudella, joten sitä ei voi muuttaa koodista muualta
        private int kerros { get; set; }
        public int Kerros
        {
            get { return kerros; } //Palauttaa set lauseen sisältämän kerros muuttujan arvon tähän
            set  //Ottaa kerros muuttujan ja asettaa sen uudestaan jos if lauseen sisältämät ehdot toteutuvat
            {
                if (value> MaxKerros) // Jos käyttäjän antama arvo kerrokselle ylittää maksimi kerroksen, niin se asetetaan maksimi kerros muuttujan arvoon
                {
                    value = MaxKerros;
                }
                kerros = value; //Jos maksimi kerrosta ei ylitetä, niin silloin kerros arvo ei muutu
            }
        }
        public void AsetaKerros()
        {
            Kerros= Convert.ToInt32(Console.ReadLine()); //Tämä vaihtaa annetun arvon Console.Readline() komennosta Int muotoon jotta loput koodista pystytään suorittamaan
            Console.WriteLine("Olet kerroksessa: " + Kerros.ToString());          
        }

    }
}
