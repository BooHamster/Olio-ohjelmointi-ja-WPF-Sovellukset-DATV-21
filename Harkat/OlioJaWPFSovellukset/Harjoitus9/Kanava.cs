using System;
using System.Collections.Generic;
using System.Text;

namespace Harjoitus9
{
    class Kanava //Kanava olio
    {
        public string Nimi { get; set; } //Kanava olion muuttujat
        public string Kesto { get; set; }

        private decimal taajuus { get; set; }

        private readonly decimal MaxTaajuus = 107.9M;
        private readonly decimal MinTaajuus = 88.0M;

        public decimal Taajuus //Taajuus muuttujalle get ja set arvot, koska taajuudelle tarvitaan minimi ja maksimi arvot, ja tällä tavoin saadaan ne asetettua
        {
            get { return taajuus; }
            set
            {
                if (value > MaxTaajuus)
                {
                    value = MaxTaajuus;
                }
                else if (value < MinTaajuus)
                {
                    value = MinTaajuus;
                }
                taajuus = value;
            }
        }
        public Kanava(string _nimi, decimal _tajuus) //Konstruktori kanava oliolle
        {
            Nimi = _nimi;
            taajuus = _tajuus;
        }

        public void TulostaKanava() //Kanavan tietojen tulostamiseen metodi
        {
            Console.WriteLine();
            Console.WriteLine("--- Radio Kanava:  " + Nimi);
            Console.Write("--- Kappale soimassa:  " );
        }


        public void TulostaPopKanava() //Metodi tietyn kanavan kappaleiden tulostamiseen randomisaatiolla
        {
            int randomluku;
            Random arpa = new Random();
            randomluku = arpa.Next(1, 10);

            if (randomluku == 1)
            {
                Console.WriteLine("RocketMan - Artisti - Elton John - Kesto - 3:50");
            }

            else if(randomluku == 2)
            {
                Console.WriteLine("Beat It - Artisti - Michael Jackson - Kesto - 3:59");
            }

            else if (randomluku == 3)
            {
                Console.WriteLine("All out of love - Artisti - Air Supply - Kesto - 4:30");
            }

            else if (randomluku == 4)
            {
                Console.WriteLine("Against All Odds - Artisti - Phil Collins - Kesto - 3:40");
            }

            else if (randomluku == 5)
            {
                Console.WriteLine("Hit me one more time - Artisti - Britney Spears - Kesto - 3:20");
            }

            else if (randomluku == 6)
            {
                Console.WriteLine("Summer of 69 - Artisti - Bryan Adams - Kesto - 2:90");
            }

            else if (randomluku == 7)
            {
                Console.WriteLine("She's Always a Woman to Me - Artisti Billy Joel  - Kesto - 3:35");
            }

            else if (randomluku == 8)
            {
                Console.WriteLine("I'll always love you - Artisti - Whitney Houston - Kesto - 4:10");
            }

            else if (randomluku == 9)
            {
                Console.WriteLine("We don't need another hero - Artisti - Tina Turner - Kesto - 3:55");
            }

            else if (randomluku == 10)
            {
                Console.WriteLine("Zombie - Artisti - Cranberries - Kesto - 4:15");
            }
        }

        public void TulostaRockKanava() //Metodi tietyn kanavan kappaleiden tulostamiseen randomisaatiolla
        {
            int randomluku;
            Random arpa = new Random();
            randomluku = arpa.Next(1, 10);

            if (randomluku == 1)
            {
                Console.WriteLine("Bat out of Hell - Artisti - MeatLoaf - Kesto - 4:50");
            }

            else if (randomluku == 2)
            {
                Console.WriteLine("The Final Countdown - Artisti - Europe - Kesto - 3:45");
            }

            else if (randomluku == 3)
            {
                Console.WriteLine("Take it on the Run - Artisti - REP SpeedWagon - Kesto - 3:20");
            }

            else if (randomluku == 4)
            {
                Console.WriteLine("More than a Feeling - Artisti - Boston - Kesto - 4:10");
            }

            else if (randomluku == 5)
            {
                Console.WriteLine("Black Magic Woman - Artisti - Santana - Kesto - 3:10");
            }

            else if (randomluku == 6)
            {
                Console.WriteLine("On the Road Again - Artisti - Canned Heat - Kesto - 2:50");
            }

            else if (randomluku == 7)
            {
                Console.WriteLine("China in Your Hand - Artisti - Tpau - Kesto - 4:40");
            }

            else if (randomluku == 8)
            {
                Console.WriteLine("Carry on my Wayward Son - Artisti - Kansas - Kesto - 4:55");
            }

            else if (randomluku == 9)
            {
                Console.WriteLine("Don't stop believing - Artisti - Journey - Kesto - 3:35");
            }

            else if (randomluku == 10)
            {
                Console.WriteLine("Hold the Line - Artisti - Toto - Kesto - 5:40");
            }
        }
    }
}
