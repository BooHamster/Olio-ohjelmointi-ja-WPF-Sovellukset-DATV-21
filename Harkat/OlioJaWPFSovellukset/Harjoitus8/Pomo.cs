using System;
using System.Collections.Generic;
using System.Text;

namespace Harjoitus8
{
    class Pomo : Henkilö //Pomo olio
    {
        private static int instanssit = 0; //Pomo olioiden lukumäärän laskemiseen staattinen muuttuja

        public static void KuinkaMonta() //Metodi joka tulostaa pomo olioiden määrän konsoliin
        {
            Console.WriteLine("Pomoja Luotu " + instanssit);
            Console.WriteLine();
        }

        //Pomo olion muuttujat
        public override string Nimi { get; set; } 
        public override string Osoite { get; set; }
        public string TyöPaikka { get; set; }
        public int Palkkaluokka { get; set; }
        public decimal Tunnit { get; set; }
        public decimal Palkka { get; set; }

        public string auto;

        public int bonus;

        public Pomo(string _nimi, string _osoite, string _työ, decimal _tunnit, int _luokka) //Pomo olion konstruktorin muuttujat
        {
            Nimi = _nimi;
            Osoite = _osoite;
            TyöPaikka = _työ;
            Tunnit = _tunnit;
            Palkkaluokka = _luokka;
            if (Pomo.instanssit > 0) //Jos pomoja yrittää luoda useamman, se ei onnistu koska tämä if lause katsoo pomo olioiden määrää
            {
                Console.WriteLine("Yritit ylentää jonkun pomoksi, mutta pomoja saa olla vain yksi!");
            }
            else //Jos pomoja olioita ei ole vielä luotu, niin silloin tämä else lauseen koodi suoritetään ja lisätään pomojen määrää yhdellä
            {
                Console.WriteLine("Pomo lisätään");
                instanssit++;
            }
        }
    


        public void PalkkaTaulukko(int i) //Koodin sisältä voi muuttaa tähän pomo olion saamaa palkkaa
        {
            int randomluku; //Luodaan kokonaisluku muuttuja
            Random arpa = new Random(); //Luodaan randomi tyyppinen muuttuja
            randomluku = arpa.Next(1, 10); //Luodaan uusi muuttuja joka tallentaa randomi muuttuja arpa muuttujan arvon, joka arvotaan 1 ja 10 väliltä
            Console.WriteLine("Pomon tiedot: ");  //Pomon tiedot tulostuu tähän
            Console.WriteLine("-- Nimi:  " + Nimi);
            Console.WriteLine("-- Osoite:  " + Osoite);
            Console.WriteLine("-- Työpaikka:  " + TyöPaikka);
            Console.WriteLine("-- Työtunnit kuukaudessa:  " + Tunnit);
            //Käydään if lauseilla läpi mikä pomon palkaksi tulee randomisaatiolla
            if (randomluku == 1)
            {
                bonus = i * randomluku;
                Console.WriteLine("Pomon osallistui {0} yhtiökokoukseen kuussa ja sai bonusta " + bonus + " euroa joka kokouksesta", randomluku);
            }

            else if (randomluku == 2)
            {
                bonus = i * randomluku;
                Console.WriteLine("Pomon osallistui {0} yhtiökokoukseen kuussa ja sai bonusta " + bonus + " euroa", randomluku);
            }

            else if (randomluku == 3)
            {
                bonus = i * randomluku;
                Console.WriteLine("Pomon osallistui {0} yhtiökokoukseen kuussa ja sai bonusta " + bonus + " euroa", randomluku);
            }

            else if (randomluku == 4)
            {
                bonus = i * randomluku;
                Console.WriteLine("Pomon osallistui {0} yhtiökokoukseen kuussa ja sai bonusta " + bonus + " euroa", randomluku);
            }

            else if (randomluku == 5)
            {
                bonus = i * randomluku;
                Console.WriteLine("Pomon osallistui {0} yhtiökokoukseen kuussa ja sai bonusta " + bonus + " euroa", randomluku);
            }

            else if (randomluku == 6)
            {
                bonus = i * randomluku;
                Console.WriteLine("Pomon osallistui {0} yhtiökokoukseen kuussa ja sai bonusta " + bonus + " euroa", randomluku);
            }

            else if (randomluku == 7)
            {
                bonus = i * randomluku;
                Console.WriteLine("Pomon osallistui {0} yhtiökokoukseen kuussa ja sai bonusta " + bonus + " euroa", randomluku);
            }

            else if (randomluku == 8)
            {
                bonus = i * randomluku;
                Console.WriteLine("Pomon osallistui {0} yhtiökokoukseen kuussa ja sai bonusta " + bonus + " euroa", randomluku);
            }

            else if (randomluku == 9)
            {
                bonus = i * randomluku;
                Console.WriteLine("Pomon osallistui {0} yhtiökokoukseen kuussa ja sai bonusta " + bonus + " euroa", randomluku);
            }

            else if (randomluku == 10)
            {
                bonus = i * randomluku;
                Console.WriteLine("Pomon osallistui {0} yhtiökokoukseen kuussa ja sai bonusta " + bonus + " euroa", randomluku);
            }
            //Pomon palkkaluokka sen mukaan mitä pomo oliolle määrättiin sen konstruktorin muuttujalle sitä luodessa
            if (Palkkaluokka == 1)
            {
                decimal conversion = 50.00M;
                Console.WriteLine("--Palkka tunnissa: 50 euroa");
                Console.WriteLine("--Palkka viikossa: " + Tunnit * conversion + " euroa");
                auto = ("Lada");
                Palkka = Tunnit * conversion * 22;
            }
            else if (Palkkaluokka == 2)
            {
                decimal conversion = 75.50M;
                Console.WriteLine("--Palkka tunnissa: 75.50 euroa");
                Console.WriteLine("--Palkka viikossa: " + Tunnit * conversion + " euroa");
                auto = ("Renault");
                Palkka = Tunnit * conversion * 22;
            }
            else if (Palkkaluokka == 3)
            {
                decimal conversion = 100.55M;
                Console.WriteLine("--Palkka tunnissa: 100.55 euroa");
                Console.WriteLine("--Palkka viikossa: " + Tunnit * conversion + " euroa");
                auto = ("Ford");
                Palkka = Tunnit * conversion * 22;
            }
            else if (Palkkaluokka == 4)
            {
                decimal conversion = 125.85M;
                Console.WriteLine("--Palkka tunnissa: 125.85 euroa");
                Console.WriteLine("--Palkka viikossa: " + Tunnit * conversion + " euroa");
                auto = ("Toyta");
                Palkka = Tunnit * conversion * 22;
            }

            else if (Palkkaluokka == 5)
            {
                decimal conversion = 150.85M;
                Console.WriteLine("--Palkka tunnissa: 150.85 euroa");
                Console.WriteLine("--Palkka viikossa: " + Tunnit * conversion + " euroa");
                auto = ("VolksWagen");
                Palkka = Tunnit * conversion * 22;
            }

            else if (Palkkaluokka == 6)
            {
                decimal conversion = 175.85M;
                Console.WriteLine("--Palkka tunnissa: 175.85 euroa");
                Console.WriteLine("--Palkka viikossa: " + Tunnit * conversion + " euroa");
                auto = ("Volvo");
                Palkka = Tunnit * conversion * 22;
            }
            else if (Palkkaluokka == 7)
            {
                decimal conversion = 200.95M;
                Console.WriteLine("--Palkka tunnissa: 200.95 euroa");
                Console.WriteLine("--Palkka palkka viikossa: " + Tunnit * conversion + " euroa");
                auto = ("BMW");
                Palkka = Tunnit * conversion * 22;
            }

            else if (Palkkaluokka == 8)
            {
                decimal conversion = 250.5M;
                Console.WriteLine("--Palkka tunnissa: 250.5 euroa");
                Console.WriteLine("--Palkka viikossa: " + Tunnit * conversion + " euroa");
                auto = ("Audi");
                Palkka = Tunnit * conversion * 22;
            }

            else if (Palkkaluokka == 9)
            {
                decimal conversion = 500.85M;
                Console.WriteLine("--Palkka tunnissa: 500.85 euroa");
                Console.WriteLine("--Palkka viikossa: " + Tunnit * conversion + " euroa");
                auto = ("Merdeces Benz");
                Palkka = Tunnit * conversion * 22;
            }
            Console.WriteLine("-- Kuukausi Palkka:  " + Palkka + " euroa");
            Console.WriteLine("-- Palkkaluokka:  " + Palkkaluokka);
            Console.WriteLine("-- Kuukausi Bonus:  " + bonus);
            Console.WriteLine("-- Pomon työsuhde auto:  " + auto);

            Console.WriteLine();
        }
        public void PomonBonus(int i) //Metodi pomon bonuksen randomisointiin
        {
            int randomluku;
            Random arpa = new Random();
            randomluku = arpa.Next(1, 10);

            if (randomluku == 1)
            {
                bonus = i * randomluku;
                Console.WriteLine("Pomon osallistui {0} yhtiökokoukseen kuussa ja sai bonusta " +bonus + " euroa joka kokouksesta", randomluku );
            }

            else if (randomluku == 2)
            {
                bonus = i * randomluku;
                Console.WriteLine("Pomon osallistui {0} yhtiökokoukseen kuussa ja sai bonusta " + bonus + " euroa", randomluku);
            }

            else if (randomluku == 3)
            {
                bonus = i * randomluku;
                Console.WriteLine("Pomon osallistui {0} yhtiökokoukseen kuussa ja sai bonusta " + bonus + " euroa", randomluku);
            }

            else if (randomluku == 4)
            {
                bonus = i * randomluku;
                Console.WriteLine("Pomon osallistui {0} yhtiökokoukseen kuussa ja sai bonusta " + bonus + " euroa", randomluku);
            }

            else if (randomluku == 5)
            {
                bonus = i * randomluku;
                Console.WriteLine("Pomon osallistui {0} yhtiökokoukseen kuussa ja sai bonusta " + bonus + " euroa", randomluku);
            }

            else if (randomluku == 6)
            {
                bonus = i * randomluku;
                Console.WriteLine("Pomon osallistui {0} yhtiökokoukseen kuussa ja sai bonusta " + bonus + " euroa", randomluku);
            }

            else if (randomluku == 7)
            {
                bonus = i * randomluku;
                Console.WriteLine("Pomon osallistui {0} yhtiökokoukseen kuussa ja sai bonusta " + bonus + " euroa", randomluku);
            }

            else if (randomluku == 8)
            {
                bonus = i * randomluku;
                Console.WriteLine("Pomon osallistui {0} yhtiökokoukseen kuussa ja sai bonusta " + bonus + " euroa", randomluku);
            }

            else if (randomluku == 9)
            {
                bonus = i * randomluku;
                Console.WriteLine("Pomon osallistui {0} yhtiökokoukseen kuussa ja sai bonusta " + bonus + " euroa", randomluku);
            }

            else if (randomluku == 10)
            {
                bonus = i * randomluku;
                Console.WriteLine("Pomon osallistui {0} yhtiökokoukseen kuussa ja sai bonusta " + bonus + " euroa", randomluku);
            }
        }
        public void TulostaData() //Metodi pomon kaikkien tietojen tulostukseen
        {
            Console.WriteLine("Pomon tiedot: ");
            Console.WriteLine("-- Nimi:  " + Nimi);
            Console.WriteLine("-- Osoite:  " + Osoite);
            Console.WriteLine("-- Työpaikka:  " + TyöPaikka);
            Console.WriteLine("-- Työtunnit kuukaudessa:  " + Tunnit);
            Console.WriteLine("-- Palkkaluokka:  " + Palkkaluokka);
            Console.WriteLine("-- Kuukausi Bonus:  " + bonus);
            Console.WriteLine("-- Kuukausi Palkka:  " + Palkka);
            Console.WriteLine("-- Pomon työsuhde auto:  " + auto);

            Console.WriteLine();
        }
    }
}
