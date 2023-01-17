using System;
//Robert Kajanti
namespace Harjoitus13
{
    class Program
    {
        static void Main(string[] args)
        {
            Joukkueet.LisääJoukkueet(); //Staattinen metodi joka lisää joukkueet listaan Joukkuuet luokan sisällä
            string lukija = "";

            while (true) //
            {
                Console.WriteLine();
                Console.WriteLine("Tämä on SM-Liigan tietokanta, voit lisätä/poistaa Joukkueita SM-Liigasta, lisätä/poistaa Pelaajia Joukkueista, näyttää Joukkueet SM-Liigassa, näyttää Pelaajat Joukkueissa ");
                Console.WriteLine();
                Console.WriteLine("Anna komento (Näytä, Lisää, Poista tai Poistu) : ");
                lukija = Console.ReadLine().ToLower();

                if (lukija.Equals("näytä")) NäytäJoukkueet();

                else if (lukija.Equals("lisää")) Lisää();
                else if (lukija.Equals("poista")) Poista();
                else if (lukija.Equals("poistu"))
                {
                    Console.WriteLine("Poistutaan sovelluksesta");
                    break;
                }
                else
                {
                    Console.WriteLine("Virheellinen syöttö, yritä uudelleen");
                }
            }
        }

        static void NäytäJoukkueet()
        {
            Joukkueet.TulostaSMLiiga();
            int joukkuemäärä = Joukkueet.SMLiiga.Count;
            if (Joukkueet.SMLiiga.Count > 0)
            {
                while (true)
                {
                    Console.WriteLine();
                    Console.WriteLine("Minkä Joukkueen Pelaajaat haluat nähdä? {0} - {1} : ", 1, joukkuemäärä);
                    string JoukkueenValinta = Console.ReadLine().ToUpper();
                    if (JoukkueenValinta.Equals("1") || JoukkueenValinta.Equals("JOKERIT"))
                    {
                        Joukkueet.Jokerit.TulostaJoukkue();
                        break;
                    }
                    else if (JoukkueenValinta.Equals("2") || JoukkueenValinta.Equals("TPS"))
                    {
                        Joukkueet.TPS.TulostaJoukkue();
                        break;
                    }
                    else if (JoukkueenValinta.Equals("3") || JoukkueenValinta.Equals("KÄRPÄT"))
                    {
                        Joukkueet.Kärpät.TulostaJoukkue();
                        break;
                    }
                    else if (JoukkueenValinta.Equals("4") || JoukkueenValinta.Equals("TAPPARA"))
                    {
                        Joukkueet.Tappara.TulostaJoukkue();
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Virheellinen valinta, anna uusi valinta");
                    }
                }
            }
        }
        static void Lisää() //Metodi pelaajien lisäämiseen joukkueisiin
        {
            {
                Joukkueet.TulostaSMLiiga(); //Tulostetaan joukkueet konsoliin tällä metodilla
                while (true)
                {
                    Console.WriteLine();
                    Console.WriteLine("Mihin Joukkueeseen haluat Lisätä Pelaajan?");
                    string JoukkueenValinta = Console.ReadLine().ToUpper();
                    if (JoukkueenValinta.Equals("1") || JoukkueenValinta.Equals("JOKERIT"))
                    {
                        Joukkueet.Jokerit.LisääPelaaja();
                        break;
                    }
                    else if (JoukkueenValinta.Equals("2") || JoukkueenValinta.Equals("TPS"))
                    {
                        Joukkueet.TPS.LisääPelaaja();
                        break;
                    }
                    else if (JoukkueenValinta.Equals("3") || JoukkueenValinta.Equals("KÄRPÄT"))
                    {
                        Joukkueet.Kärpät.LisääPelaaja();
                        break;
                    }
                    else if (JoukkueenValinta.Equals("4") || JoukkueenValinta.Equals("TAPPARA"))
                    {
                        Joukkueet.Tappara.LisääPelaaja();
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Virheellinen valinta, anna uusi valinta");
                    }
                }
            }
        }

        static void Poista() //Metodi pelaajien poistamiseen joukkueista
        {
            {
                int joukkuemäärä = Joukkueet.SMLiiga.Count;
                Joukkueet.TulostaSMLiiga();
                while (true)
                {
                    Console.WriteLine();
                    Console.WriteLine("Mistä Joukkueesta haluat poistaa Pelaajan?");
                    string JoukkueenValinta = Console.ReadLine().ToUpper();
                    if (JoukkueenValinta.Equals("1") || JoukkueenValinta.Equals("JOKERIT"))
                    {
                        Joukkueet.Jokerit.TulostaJoukkue();
                        Joukkueet.Jokerit.PoistaPelaaja();
                        break;
                    }
                    else if (JoukkueenValinta.Equals("2") || JoukkueenValinta.Equals("TPS"))
                    {
                        Joukkueet.TPS.TulostaJoukkue();
                        Joukkueet.TPS.PoistaPelaaja();
                        break;
                    }
                    else if (JoukkueenValinta.Equals("3") || JoukkueenValinta.Equals("KÄRPÄT"))
                    {
                        Joukkueet.Kärpät.TulostaJoukkue();
                        Joukkueet.Kärpät.PoistaPelaaja();
                        break;
                    }
                    else if (JoukkueenValinta.Equals("4") || JoukkueenValinta.Equals("TAPPARA"))
                    {
                        Joukkueet.Tappara.TulostaJoukkue();
                        Joukkueet.Tappara.PoistaPelaaja();
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Virheellinen valinta, anna uusi valinta");
                    }
                }
            }
        }
    }
}


