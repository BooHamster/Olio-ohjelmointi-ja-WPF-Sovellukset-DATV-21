using System;
using System.Collections.Generic;
using System.Text;

namespace Harjoitus11
{
    static class Kokoelma
    {
        public static Dictionary<string, Opiskelija> Opiskelijat = new Dictionary<string, Opiskelija>(); //Luodaan Opiskelija tyyppinen kokoelma, jossa avain on string tyyppinen.

        public static string OpiskelijaID = "";  //Tuodaan muuttujat Opiskelija luokasta, jotta voidaan asettaa ne tässä luokassa, muuten niitä ei pysty asettamaan kun luodaan Opiskelija Olio Kokoelma luokan sisällä
        public static string etunimi = "";
        public static string sukunimi = "";
        public static string ryhmä = "";



        public static void LisääOpiskelija() //Metodi Opiskelija olion lisäämiselle Kokoelma luokan sisällä
        {
            bool Tarkista = false;  //Boolean muuttuja jolla tarkistetaan myöhemmin onko Opiskelija olion luominen sallittua
            int randomluku;     //int tyyppinen muuttuja Opiskelijan ryhmätunnuksen randomisointiin
            Random randomRyhma = new Random(); //Luodaan randomi muuttuja randomisointiin
            randomluku = randomRyhma.Next(1, 5);  //Määritetään randomluku muuttujan parametrit, mikä valitsee randomi numeron 1-5
            if (randomluku == 1)  //Katsotaan mikä randomi luku randomluku muuttujalle tuli if lauseissa, ja numeron mukaan asetetaan Opiskelijalle ryhmätunnus
            {
                ryhmä = "1A";
            }
            else if (randomluku == 2)
            {
                ryhmä = "1B";
            }

            else if (randomluku == 3)
            {
                ryhmä = "1C";
            }

            else if (randomluku == 4)
            {
                ryhmä = "1D";
            }

            else if (randomluku == 5)
            {
                ryhmä = "1E";
            }

            Console.WriteLine("Syötä Etunimi: ");  
            etunimi = Console.ReadLine();  // Käyttäjä saa antaa itse Opiskelijalle Etunimen
            Console.WriteLine();  //Nämä tyhjät Console.WriteLinet ovat vain luettavuutta varten, ulkoasu on selkeämpi kun kaikki tekstit eivät ole kiinni toisissaan
            Console.WriteLine("Syötä Sukunimi: ");
            sukunimi = Console.ReadLine(); // Käyttäjä saa antaa itse Opiskelijalle Sukunimen
            Console.WriteLine();   
            while (!Tarkista)    // While looppi jonka tarkoitus on käydä Tarkistus metodi OpiskelijaID:lle, ja jos tarkistus no väärä niin käydään mennään käymään catch lauseen virheilmoitus läpi
            {
                try  //Katso try lauseen sisällön läpi, ja jos käyttäjä syöttää väärin OpiskelijaID:een, niin silloin siirrytään catch lauseeseen
                {
                    Console.WriteLine("Syötä Opiskelija ID, pituuden pitää olla 6 merkkiä: ");
                    OpiskelijaID = Console.ReadLine();  //Käyttäjä saa syöttää Opiskelija ID:een itse
                    Tarkista = TarkistaID(OpiskelijaID); //Määritetään boolean Tarkista samaksi kuin TarkistaID metodi, ja käydään Tarkista metodi läpi käyttäjän antamalle OpiskelijaID:lle
                }
                catch(Poikkeukset) //Virheilmoitus metodi on sisällytetty catch lauseen () sulkeiden sisään, jolloin voidaan jättää {} sisältö tyhjäksi
                {

                }
            }

            if (Tarkista) //Jos OpiskelijaID oli oikein syötetty, TarkistaID palauttaa Tarkista booleanille true vastauksen, jolloin tämä if lause käydään läpi
            {
                Opiskelijat.Add(OpiskelijaID, new Opiskelija(etunimi, sukunimi, ryhmä, OpiskelijaID)); //Luodaan Opiskelija olio, ja asetetaan arvot Opiskelija olion konstruktorista, ja samalla lisätään Opiskelija olio Opiskelijat Kokoelmaan
                TulostaViesti(string.Format("Uusi opiskelija {0} lisätty kokoelmaan!", Opiskelijat[OpiskelijaID].HaeData())); //Käydään TulostaViesti metodi läpi
            }
        }

        public static bool TarkistaID(string id) //Metodi OpiskelijaID:een tarkistukseen
        {
            if (Opiskelijat.ContainsKey(id)) //Katsotaan onko Opiskelijat Kokoelmassa jo lisätty avain ContainsKey() Metodilla, mikä on valmis metodi, ja palauttaa true arvon jos se löytää Kokoelmasta jo saman avaimen, ja falsen jos se ei löydä samaa avainta
            {
                throw new Poikkeukset("OpiskelijaID " + id + " ei ole uniikki, anna uusi ID"); //Tämä tulostuu jos annettu avain löytyi jo Kokoelmasta
            }
            else if (id.Length < 6 || id.Length > 6) //Tämä katsoo onko annettu avain annettujen arvojen sisällä, tässä tapauksessa ei lyhyempi tai pidempi kuin 6 merkkiä
            {
                throw new Poikkeukset("OpiskelijaID " + id + " on liian pitkä tai lyhyt. Opiskelija ID:n potuus tulee olla tasan 6"); //Tämä tulostuu jos annettu avain oli väärän pituinen
            }
            else
            {
                return true; //Jos avain oli sopivan pituinen ja uniikki, niin silloin palautetaan boolean arvo joka oli määritelty tälle metodille true arvoon
            }
        }

       
        public static void PoistaOpiskelija(int syötettyIndex) //Opiskelija olion poistamiseen Kokoelmasta tarkoitettu metodi, missä määritellään että sen arvo on syötettyIndex muuttujan arvo Pääohjelmasta
        {
            int i = 0; //Luodaan int muuttuja ja määritetään se 0 arvoksi

            foreach (string avain in Opiskelijat.Keys) //Tämä käydään läpi jokaiselle muuttujalle foreach lauseen sisällä, tässä tapauksessa avain(key) Opiskelijat.Keys hakemiston sisältä, tämä avain tai key, on tässä tapauksessa OpiskelijaID
            {
                if (i == syötettyIndex)  //Tämä if lause toteutetaan jos muuttuja i on sama kuin käyttäjän pääohjelmassa syöttämä arvo
                {
                    TulostaViesti("Opiskelija " + Opiskelijat[avain].HaeData() + " poistettu kokoelmasta"); //Ensin käytetään TulostaViesti Metodia, mikä lisää muutaman Console.Write rivin, sitten käytetään HaeData metodia käyttäjän antaman numeron vastaavalle Opiskelija avaimelle(OpiskelijaID)
                    Opiskelijat.Remove(avain); //Poistetaan käyttäjän antamaa numeroa vastaava Opiskelija olio, Opiskelijat kokoelmasta
                    break; //Poistutaan metodista
                }

                i++; //i Muuttujan arvoa nostetaan yhdellä, niin kauan, että se vastaa syötettyIndex arvoa
            }
        }

        // Loopataan lista läpi, ja tulostetaan opiskelijat konsoliin
        public static void TulostaKokoelma()  //Metodi Kokoelman sisällön tulostamiseen käyttäjälle
        {
            if (Opiskelijat.Count == 0) //Tämä if lause toteutuu jos Opiskelija Kokoelma on tyhjä, elikkä sisältää 0 Opiskelija oliota
            {
                TulostaViesti("Opiskelija kokoelma on tyhjä");
                return; //Poistutaan Metodista
            }

            int i = 1; //Luodaan ja määritetään muuttuja int i arvoon 1

            TulostaViesti("Opiskelijat kokoelmassa: ");

            foreach (Opiskelija opiskelija in Opiskelijat.Values) //Toteutetaan jokaiselle Opiskelija luokan Opiskelijalle Opiskelijat kokoelman Values hakemiston sisällä, arvot ovat <string> = OpiskelijaID, ja <Kokoelman tyyppi> = Opiskelija
            {
                Console.WriteLine("{0}: {1}", i, opiskelija.HaeData()); // Tulostaa {0} arvoon i muuttujan arvon, ja {1} arvoon opiskelija.HaeData Metodilla Opiskelija olion tiedot 
                i++; //Kun foreach käy Opiskelija olion läpi,  muuttujan i arvo lisääntyy aina yhdellä
            }
        }
         public static void TulostaViesti(string message) //Metodi minkä pitäisi vähentää Console.WriteLinen käyttöä, kun Metodia käytetään voidaan Metodin sulkeiden sisälle Kirjoittaa se mitä halutaan, Metodi tulostaa aina kaksi ylimmäista Console.WriteLinea, ja sen jälkeen sen mitä oli kirjoitettu TulostaViestin sulkeiden sisään. esim TulostaViesti("Tulosta Tämä"), tai sitä voisi myös käyttää näin TulostaViesti(Console.ReadLine), jos halutaan, että käyttäjä voi kirjoittaa viestin sisällön
        {
            Console.WriteLine();
            Console.WriteLine("-----------");
            Console.WriteLine(message);

        }
    }
}
