using System;
using System.Collections.Generic;
using System.Text;

namespace Harjoitus13
{
    class Joukkue //Joukkue luokka
    {
        public Dictionary<int, Pelaaja> Pelaajat = new Dictionary<int, Pelaaja>(); //Pelaaja tyyppisen listan luominen

        private int PelaajaNumero; //Muuttujat Joukkue olioille
        private string etunimi = "";
        private string sukunimi = "";
        private string Nimi { get; set; }
        private string Kotikaupunki { get; set; }

        private string Tunnus { get; set; }
        public Joukkue(string _nimi, string _kaupunki, string _tunnus) //Konstruktori Joukkue luokalle
        {
            Nimi = _nimi;
            Kotikaupunki = _kaupunki;
            Tunnus = _tunnus;
        }

        public void LisääPelaaja() //Metodi pelaajan lisäämiseen joukkueseen
        {
            bool Tarkista = false;  //Boolean muuttuja jolla tarkistetaan myöhemmin onko Pelaaja olion luominen sallittua
            Console.WriteLine("Syötä Pelaajan Etunimi: ");
            etunimi = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Syötä Pelaajan Sukunimi: ");
            sukunimi = Console.ReadLine();
            Console.WriteLine();
            while (!Tarkista) //While looppi pelaaja numeron tarkistamista varten
            {
                try
                {
                    Console.WriteLine("Syötä Pelaajan PeliNumero, sen on oltava vain 2 Numeroa: ");
                    PelaajaNumero = Convert.ToInt32(Console.ReadLine());
                    Tarkista = TarkistaPelaajaNumero(PelaajaNumero); //Metodi joka katsoo onko PelaajaNumero muuttuja vain 2 numeron pituinen
                }
                catch (Poikkeukset) //Virheiden tarkistamiseen tarkoitettu lause, joka vie Poikkeukset luokkaan
                {

                }
            }

            if (Tarkista)
            {
                Pelaajat.Add(PelaajaNumero, new Pelaaja(etunimi, sukunimi, PelaajaNumero));
                TulostaViesti(string.Format("Uusi Pelaaja {0} on lisätty Joukkueeseen", Pelaajat[PelaajaNumero].HaeData()));
            }


        }

        public bool TarkistaPelaajaNumero(int id) //Pelaajanumeron tarkistamiseen tarkoitettu metodi, katsoo onko pelaajanumero jo olemassa Pelaajat listassa, ja onko se oikean pituinen
        {
            if (Pelaajat.ContainsKey(id))
            {
                throw new Poikkeukset("Pelaaja Numero " + id + " ei ole uniikki, anna uusi ID");
            }
            else if (id < 0 || id > 99)
            {
                throw new Poikkeukset("Pelaaja Numero " + id + " on liian pitkä tai lyhyt. Pelaaja Numeron Pituus tulee olla tasan 2 numeroa"); //Tämä tulostuu jos annettu avain oli väärän pituinen
            }
            else
            {
                return true;
            }
        }


        public void PoistaPelaaja() //Pelaajan poistamiseen Pelaajat listasta tarkoitettu metodi, joka katsoo avaimen perusteella onko pelaaja listalla
        {
            int PelaajanValinta;
            int i = 1;
            Console.WriteLine("Kuka Pelaaja Poistetaan?");
            while(true)
            {
                bool result = int.TryParse(Console.ReadLine(), out PelaajanValinta);
                if (result)
                {
                    foreach (int avain in Pelaajat.Keys)
                    {
                        if (i == PelaajanValinta)
                        {
                            Console.WriteLine();
                            TulostaViesti("Pelaaja " + Pelaajat[avain].HaeData() + " poistettu Joukkueesta ");
                            Pelaajat.Remove(avain);
                            break;
                        }
                        i++;
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("Virheellinen valinta, anna uusi valinta");
                }
            }

        }


        public void TulostaJoukkue()
        {

            if (Pelaajat.Count == 0)
            {
                Console.WriteLine();
                TulostaViesti(string.Format("Joukkueessa ei ole pelaajia"));
                return;
            }


            int r = 1;
            foreach (Pelaaja pelaaja in Pelaajat.Values)
            {
                Console.WriteLine("{0}: {1}", r, pelaaja.HaeData());
                r++;
            }
        }
        public void TulostaViesti(string message)
        {
            Console.WriteLine();
            Console.WriteLine("-----------");
            Console.WriteLine(message);

        }

        public string HaeData()
        {
            return Nimi + "." + " Kotikaupunki: " + Kotikaupunki + "." + " Tunnus: " + Tunnus + "."; //Palauttaa nämä tiedot, tämän voisi kyllä toteuttaa myös Console.Write komennolla myös
        }
    }
}
