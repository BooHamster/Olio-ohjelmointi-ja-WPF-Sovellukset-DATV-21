using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Harjoitus12
{
    static class Pakka //Pakka luokka
    {
        public static Dictionary<string, Kortti> Kortit = new Dictionary<string, Kortti>(); //Luodaan uusi Kortti Kokoelma
        public static int Hertta = 1;
        public static int Pata = 1;
        public static int Risti = 1;
        public static int Ruutu = 1;
        public static void LisääKortit2() //Korttien lisäys metodi ilman randomisointia
        {
            for (int i = 1; i < 56; i++)
            {
                while (Hertta < 15)
                {
                    Kortit.Add("Hertta " + Hertta, new Kortti("Hertta"));
                    Hertta++;
                }
                while (Ruutu < 15)
                {
                    Kortit.Add("Ruutu " + Ruutu, new Kortti("Ruutu"));
                    Ruutu++;
                }
                while (Risti < 15)
                {
                    Kortit.Add("Risti " + Risti, new Kortti("Risti"));
                    Risti++;
                }
                while (Pata < 15)
                {
                    Kortit.Add("Pata " + Pata, new Kortti("Ruutu"));
                    Pata++;
                }
            }
        }
        public static void LisääKortit() //Korttien randomisoitu lisäys metodi kokoelmaan
        {
            Kortit.Clear();
            bool Number1 = true;
            bool Number2 = true;
            bool Number3 = true;
            bool Number4 = true;
            bool Number5 = true;
            bool Number6 = true;
            bool Number7 = true;
            bool Number8 = true;
            bool Number9 = true;
            bool Number10 = true;
            bool Number11 = true;
            bool Number12 = true;
            bool Number13 = true;
            bool Number14 = true;
            bool Number15 = true;
            bool Number16 = true;
            bool Number17 = true;
            bool Number18 = true;
            bool Number19 = true;
            bool Number20 = true;
            bool Number21 = true;
            bool Number22 = true;
            bool Number23 = true;
            bool Number24 = true;
            bool Number25 = true;
            bool Number26 = true;
            bool Number27 = true;
            bool Number28 = true;
            bool Number29 = true;
            bool Number30 = true;
            bool Number31 = true;
            bool Number32 = true;
            bool Number33 = true;
            bool Number34 = true;
            bool Number35 = true;
            bool Number36 = true;
            bool Number37 = true;
            bool Number38 = true;
            bool Number39 = true;
            bool Number40 = true;
            bool Number41 = true;
            bool Number42 = true;
            bool Number43 = true;
            bool Number44 = true;
            bool Number45 = true;
            bool Number46 = true;
            bool Number47 = true;
            bool Number48 = true;
            bool Number49 = true;
            bool Number50 = true;
            bool Number51 = true;
            bool Number52 = true;
            bool Number53 = true;
            bool Number54 = true;
            bool Number55 = true;
            bool Number56 = true;

            int Laske = 0; //Luodaan int muuttuja pakan korttien lisäyksen laskemiseen, tätä lisätään aina yhdellä kun kortti on lisätty pakkaan
            int randomluku; //Luodaan int muuttuja randomi luvun tarkastamiseen
            Random arpa = new Random(); //Luodaan uusi randomi luku muuttuja
            randomluku = arpa.Next(1, 57); //Asetetaan randomi luvun muuttujan minimi ja maksimi arvot
            while (Laske < 56) //While looppi, joka pyörii niin kauan kun Laske muuttuja pysyy alle 56
            {
                randomluku = arpa.Next(1, 57);
                if (randomluku == 1 && Number1)
                {
                    Kortit.Add("Pata Ässä", new Kortti("Pata Ässä")); //Luodaan uusi Kortti olio ja lisätään se Kortit Kokoelmaan
                    Laske++;
                    Number1 = false;
                }
                else if (randomluku == 3 && Number3)
                {
                    Kortit.Add("Pata Kakkonen", new Kortti("Pata Kakkonen"));
                    Laske++;
                    Number3 = false;
                }
                else if (randomluku == 4 && Number4)
                {
                    Kortit.Add("Pata Kolmonen", new Kortti("Pata Kolmonen"));
                    Laske++;
                    Number4 = false;
                }
                else if (randomluku == 5 && Number5)
                {
                    Kortit.Add("Pata Nelonen", new Kortti("Pata Nelonen"));
                    Laske++;
                    Number5 = false;
                }
                else if (randomluku == 6 && Number6)
                {
                    Kortit.Add("Pata Vitonen", new Kortti("Pata Vitonen"));
                    Laske++;
                    Number6 = false;
                }

                else if (randomluku == 7 && Number7)
                {
                    Kortit.Add("Pata Kutonen", new Kortti("Pata Kutonen"));
                    Laske++;
                    Number7 = false;
                }
                else if (randomluku == 8 && Number8)
                {
                    Kortit.Add("Pata Seiska", new Kortti("Pata Seiska"));
                    Laske++;
                    Number8 = false;
                }
                else if (randomluku == 9 && Number9)
                {
                    Kortit.Add("Pata Kasi", new Kortti("Pata Kasi"));
                    Laske++;
                    Number9 = false;
                }
                else if (randomluku == 10 && Number10)
                {
                    Kortit.Add("Pata Ysi", new Kortti("Pata Ysi"));
                    Laske++;
                    Number10 = false;
                }
                else if (randomluku == 11 && Number11)
                {
                    Kortit.Add("Pata Kymppi", new Kortti("Pata Kymppi"));
                    Laske++;
                    Number11 = false;
                }
                else if (randomluku == 12 && Number12)
                {
                    Kortit.Add("Pata Jätkä", new Kortti("Pata Jätkä"));
                    Laske++;
                    Number12 = false;
                }
                else if (randomluku == 13 && Number13)
                {
                    Kortit.Add("Pata Kuningatar", new Kortti("Pata Kuningatar"));
                    Laske++;
                    Number13 = false;
                }
                else if (randomluku == 14 && Number14)
                {
                    Kortit.Add("Pata Kuningas", new Kortti("Pata Kuningas"));
                    Laske++;
                    Number14 = false;
                }
                else if (randomluku == 15 && Number15)
                {
                    Kortit.Add("Pata Jokeri", new Kortti("Pata Jokeri"));
                    Laske++;
                    Number15 = false;
                }
                else if (randomluku == 16 && Number16)
                {
                    Kortit.Add("Hertta Ässä", new Kortti("Hertta Ässä"));
                    Laske++;
                    Number16 = false;
                }
                else if (randomluku == 17 && Number17)
                {
                    Kortit.Add("Hertta Kakkonen", new Kortti("Hertta Kakkonen"));
                    Laske++;
                    Number17 = false;
                }
                else if (randomluku == 18 && Number18)
                {
                    Kortit.Add("Hertta Kolmonen", new Kortti("Hertta Kolmonen"));
                    Laske++;
                    Number18 = false;
                }
                else if (randomluku == 19 && Number19)
                {
                    Kortit.Add("Hertta Nelonen", new Kortti("Hertta Nelonen"));
                    Laske++;
                    Number19 = false;
                }
                else if (randomluku == 20 && Number20)
                {
                    Kortit.Add("Hertta Vitonen", new Kortti("Hertta Vitonen"));
                    Laske++;
                    Number20 = false;
                }
                else if (randomluku == 21 && Number21)
                {
                    Kortit.Add("Hertta Kutonen", new Kortti("Hertta Kutonen"));
                    Laske++;
                    Number21 = false;
                }
                else if (randomluku == 22 && Number22)
                {
                    Kortit.Add("Hertta Seiska", new Kortti("Hertta Seiska"));
                    Laske++;
                    Number22 = false;
                }
                else if (randomluku == 23 && Number23)
                {
                    Kortit.Add("Hertta Kasi", new Kortti("Hertta Kasi"));
                    Laske++;
                    Number23 = false;
                }
                else if (randomluku == 24 && Number24)
                {
                    Kortit.Add("Hertta Ysi", new Kortti("Hertta Ysi"));
                    Laske++;
                    Number24 = false;
                }
                else if (randomluku == 25 && Number25)
                {
                    Kortit.Add("Hertta Kymppi", new Kortti("Hertta Kymppi"));
                    Laske++;
                    Number25 = false;
                }
                else if (randomluku == 26 && Number26)
                {
                    Kortit.Add("Hertta Jätkä", new Kortti("Hertta Jätkä"));
                    Laske++;
                    Number26 = false;
                }
                else if (randomluku == 27 && Number27)
                {
                    Kortit.Add("Hertta Kuningatar", new Kortti("Hertta Kuningatar"));
                    Laske++;
                    Number27 = false;
                }
                else if (randomluku == 28 && Number28)
                {
                    Kortit.Add("Hertta Kuningas", new Kortti("Hertta Kuningas"));
                    Laske++;
                    Number28 = false;
                }
                else if (randomluku == 55 && Number55)
                {
                    Kortit.Add("Hertta Jokeri", new Kortti("Hertta Jokeri"));
                    Laske++;
                    Number55 = false;
                }
                else if (randomluku == 29 && Number29)
                {
                    Kortit.Add("Ruutu Ässä", new Kortti("Ruutu Ässä"));
                    Laske++;
                    Number29 = false;
                }
                else if (randomluku == 30 && Number30)
                {
                    Kortit.Add("Ruutu Kakkonen", new Kortti("Ruutu Kakkonen"));
                    Laske++;
                    Number30 = false;
                }
                else if (randomluku == 31 && Number31)
                {
                    Kortit.Add("Ruutu Kolmonen", new Kortti("Ruutu Kolmonen"));
                    Laske++;
                    Number31 = false;
                }
                else if (randomluku == 56 && Number56)
                {
                    Kortit.Add("Ruutu Nelonen", new Kortti("Ruutu Nelonen"));
                    Laske++;
                    Number56 = false;
                }
                else if (randomluku == 32 && Number32)
                {
                    Kortit.Add("Ruutu Vitonen", new Kortti("Ruutu Vitonen"));
                    Laske++;
                    Number32 = false;
                }
                else if (randomluku == 33 && Number33)
                {
                    Kortit.Add("Ruutu Kutonen", new Kortti("Ruutu Kutonen"));
                    Laske++;
                    Number33 = false;
                }
                else if (randomluku == 2 && Number2)
                {
                    Kortit.Add("Ruutu Seiska", new Kortti("Ruutu Seiska"));
                    Laske++;
                    Number2 = false;
                }
                else if (randomluku == 34 && Number34)
                {
                    Kortit.Add("Ruutu Kasi", new Kortti("Ruutu Kasi"));
                    Laske++;
                    Number34 = false;
                }
                else if (randomluku == 35 && Number35)
                {
                    Kortit.Add("Ruutu Ysi", new Kortti("Ruutu Ysi"));
                    Laske++;
                    Number35 = false;
                }
                else if (randomluku == 36 && Number36)
                {
                    Kortit.Add("Ruutu Kymppi", new Kortti("Ruutu Kymppi"));
                    Laske++;
                    Number36 = false;
                }
                else if (randomluku == 37 && Number37)
                {
                    Kortit.Add("Ruutu Jätkä", new Kortti("Ruutu Jätkä"));
                    Laske++;
                    Number37 = false;
                }
                else if (randomluku == 38 && Number38)
                {
                    Kortit.Add("Ruutu Kuningatar", new Kortti("Ruutu Kuningatar"));
                    Laske++;
                    Number38 = false;
                }
                else if (randomluku == 39 && Number39)
                {
                    Kortit.Add("Ruutu Kuningas", new Kortti("Ruutu Kuningas"));
                    Laske++;
                    Number39 = false;
                }
                else if (randomluku == 40 && Number40)
                {
                    Kortit.Add("Ruutu Jokeri", new Kortti("Ruutu Jokeri"));
                    Laske++;
                    Number40 = false;
                }
                else if (randomluku == 41 && Number41)
                {
                    Kortit.Add("Risti Ässä", new Kortti("Risti Ässä"));
                    Laske++;
                    Number41 = false;
                }
                else if (randomluku == 42 && Number42)
                {
                    Kortit.Add("Risti Kakkonen", new Kortti("Risti Kakkonen"));
                    Laske++;
                    Number42 = false;
                }
                else if (randomluku == 43 && Number43)
                {
                    Kortit.Add("Risti Kolmonen", new Kortti("Risti Kolmonen"));
                    Laske++;
                    Number43 = false;
                }
                else if (randomluku == 44 && Number44)
                {
                    Kortit.Add("Risti Nelonen", new Kortti("Risti Nelonen"));
                    Laske++;
                    Number44 = false;
                }
                else if (randomluku == 45 && Number45)
                {
                    Kortit.Add("Risti Vitonen", new Kortti("Risti Vitonen"));
                    Laske++;
                    Number45 = false;
                }
                else if (randomluku == 46 && Number46)
                {
                    Kortit.Add("Risti Kutonen", new Kortti("Risti Kutonen"));
                    Laske++;
                    Number46 = false;
                }
                else if (randomluku == 47 && Number47)
                {
                    Kortit.Add("Risti Seiska", new Kortti("Risti Seiska"));
                    Laske++;
                    Number47 = false;
                }
                else if (randomluku == 48 && Number48)
                {
                    Kortit.Add("Risti Kasi", new Kortti("Risti Kasi"));
                    Laske++;
                    Number48 = false;
                }
                else if (randomluku == 49 && Number49)
                {
                    Kortit.Add("Risti Ysi", new Kortti("Risti Ysi"));
                    Laske++;
                    Number49 = false;
                }
                else if (randomluku == 50 && Number50)
                {
                    Kortit.Add("Risti Kymppi", new Kortti("Risti Kymppi"));
                    Laske++;
                    Number50 = false;
                }
                else if (randomluku == 51 && Number51)
                {
                    Kortit.Add("Risti Jätkä", new Kortti("Risti Jätkä"));
                    Laske++;
                    Number51 = false;
                }
                else if (randomluku == 52 && Number52)
                {
                    Kortit.Add("Risti Kuningatar", new Kortti("Risti Kuningatar"));
                    Laske++;
                    Number52 = false;
                }
                else if (randomluku == 53 && Number53)
                {
                    Kortit.Add("Risti Kuningas", new Kortti("Risti Kuningas"));
                    Laske++;
                    Number53 = false;
                }
                else if (randomluku == 54 && Number54)
                {
                    Kortit.Add("Risti Jokeri", new Kortti("Risti Jokeri"));
                    Laske++;
                    Number54 = false;
                }
            }
            Console.WriteLine();
            Console.WriteLine("Kortit lisätty pakkaan!");

        }


        public static void Sekoita() //Korttien sekoitus Metodi luokan sisältä
        {
            var rnd = new Random(); //luodaan uusi random muuttuja
            var randomized = Kortit.OrderBy(item => rnd.Next()); //Luodaan ja määritellään muuttuja mikä Randomisoi Kortit Kokoelman käyttäen rnd randomi Muuttujan parametrejä, mitkä on arvot kokoelmasta, elikkä arvot minimistä maksimiin saadaan Kokoelman arvoista
            int i = 1; //Luodaan Int muuttuja foreach looppia varten
            Console.WriteLine();
            foreach (var value in randomized) //foreach looppi jokaista arvoa var muuttuja randomized muuttujasta, tässä tapauksessa 56 arvoa Kortit Kokoelmasta
            {
                Console.WriteLine("{0}. Kortti on: " + value.Key, i); //Tulostaa käyttäjälle randomisoidun listan korteista, tulostaen ensin i muuttujan arvon, sitten arvon randomized muuttujasta, mikä on Kortti olio Kortit kokoelmasta, minkä järjestys on randomisoitu
                i++; //Lisätään aina yksi, elikkä i + 1= arvo, jotta looppi jatkuu kunnes kaikki arvot on tulostettu Kortit Kokoelmasta
            }
        }

        public static void TulostaPakka()  //Metodi Kokoelman sisällön tulostamiseen käyttäjälle
        {
            if (Kortit.Count == 0) //Tämä if lause toteutuu jos Pakka Kokoelma on tyhjä, elikkä sisältää 0 Kortti oliota
            {
                Console.WriteLine();
                Console.WriteLine("Pakka on Tyhjä, lisää kortit pakkaan!");
                return; //Poistutaan Metodista
            }

            int i = 1; //Luodaan ja määritetään muuttuja int i arvoon 1
            Console.WriteLine();
            Console.WriteLine("Kortit Pakassa: ");

          /*  foreach (Kortti kortti in Kortit.Values) //Toteutetaan jokaiselle Kortti luokan Kortille Kortit kokoelman Values hakemiston sisällä, arvot ovat <string>, ja <Kokoelman tyyppi> = Kortti
            {
                Console.WriteLine("{0}: {1}", i, kortti.Tiedot()); // Tulostaa {0} arvoon i muuttujan arvon, ja {1} arvoon Kortti.HaeData Metodilla Kortti olion tiedot 
                i++; //Kun foreach käy Kortti olion läpi,  muuttujan i arvo lisääntyy aina yhdellä
            } */
            foreach (string avain in Kortit.Keys) //Toteutetaan jokaiselle Kortti luokan Kortille Kortit kokoelman Values hakemiston sisällä, arvot ovat <string>, ja <Kokoelman tyyppi> = Kortti
            {
                Console.WriteLine(i + ".Kortti on: " + avain);  //Tulostaa ensin i muuttujan arvon, sitten kirjoitetun stringin, ja lopuksi string tyyppisen avaimen Kortit.Keys kokoelman arvoista.
                i++; //Kun foreach käy Kortti olion läpi,  muuttujan i arvo lisääntyy aina yhdellä
            }
        }
    }
}
