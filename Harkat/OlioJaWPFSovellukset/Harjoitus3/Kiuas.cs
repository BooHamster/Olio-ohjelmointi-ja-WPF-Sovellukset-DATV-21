using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing.Imaging;
using System.Drawing;
using Microsoft.Win32;
using Microsoft.Azure.Amqp.Framing;

namespace Harjoitus3
{
    class Kiuas  // Kiuas luokka
    {
        private string Nimi { get; set; } //Kiuas luokan muuttujat
        private bool Päällä{ get; set; }
        private int Lämpötila { get; set; }

        private int Kosteus { get; set; }

        public bool Kuolit { get; set; }

        //Konstruktori
        public Kiuas(string _nimi, bool _on, int _läm, int _kos)
        {
            Nimi = _nimi;
            Päällä = _on;
            Lämpötila = _läm;
            Kosteus = _kos;
        }

        public void TulostaData() //Metodi kiuas olion tietojen tulostukseen
        {
            Console.WriteLine("Kiuas: ");
            Console.WriteLine("-- Nimi:  " + Nimi);
            if(Päällä == true)
            {
                Console.WriteLine("-- Kiukaan Tila: Päällä ");
            }
            else
            {
                Console.WriteLine("-- Kiukaan Tila: Pois Päältä ");
            }
            Console.WriteLine("-- Lämpötila:  " + Lämpötila);
            Console.WriteLine("-- Ilmankosteus:  " + Kosteus + "%");
            Console.WriteLine("Käynnistä/Sammuta kiuas, anna k");
            Console.WriteLine("Nosta lämpötilaa anna n, laske lämpötilaa anna l");
            Console.WriteLine("Heitä löylyä, anna h");
            Console.WriteLine("Poistu kiukaan luota, anna p");
            Console.WriteLine();
        }


        public void LisääLämpöä(int i) //Lämpötilan säätelyyn metodi
        {
            Lämpötila = Lämpötila + i;
            if (Lämpötila < 0)
            {
                Lämpötila = 0;
            }
            else if (Lämpötila > 99 && Lämpötila <120)
            {
                Console.BackgroundColor = ConsoleColor.Black;  // Lämpötilan mukaan vaihtuu konsolin värit
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Alkaapi kuumottaa hieman");
            }

            else if (Lämpötila > 119 && Lämpötila < 150)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("O-Onpas kuuma, hiki alkaa loppuu kesken");
            }

            else if (Lämpötila > 149 && Lämpötila < 180)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Uh huh, nyt alkaa karvat palamaan!");
            }

            else if (Lämpötila > 179 && Lämpötila < 200)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Pallit on tulessa! Päästäkää mut ulos täältä!");
                Console.Beep();
            }

            else if (Lämpötila > 199)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("Pitikö häslätä, nyt se on leikin loppu, kuolit mokoma löyly sankari!");
                Console.Beep();
                Console.Beep();
                Kuolit = true;
            }
        }

        public void LaskeLämpöä(int i) //Lämpötilan laskuun metodi
        {
            Lämpötila = Lämpötila - i;
            if (Lämpötila < 0)
            {
                Lämpötila = 0;
            }
        }

        public void HeitäLöylyä(int i) //Löylyn heittämiseen metodi
        {
            if (Päällä == true)
            {
                Kosteus = Kosteus + i;
                if (Kosteus < 0)
                {
                    Kosteus = 0;
                }
                else if (Kosteus > 4 && Kosteus < 25)
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Lisää löylyä oon kuiva kuin rusina");
                }

                else if (Kosteus > 24 && Kosteus < 50)
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine("Nonni hiki alkaa virtaa");
                }

                else if (Kosteus > 49 && Kosteus < 75)
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("Lääh kylläpäs täällä lähähtyy, vois ollappi vähemmän kosteaa");
                }

                else if (Kosteus > 74 && Kosteus < 100)
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Meressäkin on kuivempaa kuin täällä, nyt loppu se vedellä läträäminen!");
                    Console.Beep();
                }

                else if (Kosteus > 99)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Pitikö tulla hoppu, nyt se on leikin loppu, hukuit omaan hikeesi löylyjen sankari");
                    Console.Beep();
                    Console.Beep();
                    Kuolit = true;
                }
            }
        }

        public void ONJAOFF() //Kiukaan päälle ja pois päältä laittamiseen metodi
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

    }
}
