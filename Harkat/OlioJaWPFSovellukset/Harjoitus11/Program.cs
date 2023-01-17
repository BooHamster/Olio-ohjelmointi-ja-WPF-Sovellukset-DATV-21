using System;
//RObert Kajanti
namespace Harjoitus11
{
    class Program
    {
        static void Main(string[] args)
        {
            string lukija = ""; //Luodaan string tyyppinen muuttuja

            while (true) //While looppi käyttäjän kirjoittamia komentoja varten
            {
                Console.WriteLine();
                Console.WriteLine("Tämä on Opiskelija tietokanta, käytä vastuullisesti! ");
                Console.WriteLine();
                Console.WriteLine("Anna komento (Näytä, Lisää, Poista tai Poistu) : ");
                lukija = Console.ReadLine().ToLower(); //Määritetään lukija muuttuja Console.ReadLineksi, jolla käyttäjä antaa komennot, ja samalla muuntaa kaikki käyttäjän kirjoittaman pieniksi kirjaimiksi, jolloin sillä ei ole väliä kirjoittaako pieniä vai isoja kirjaimia

                if (lukija.Equals("näytä")) Kokoelma.TulostaKokoelma(); //Jos käyttäjä antaa näytä komennon, niin Kokoelma toteuttaa TulostaKokoelma metodin, mikä tulostaa Kokoelman tiedot

                else if (lukija.Equals("lisää")) Lisää(); //Jos käyttäjä antaa lisää komennon niin Lisää metodi käydään käpi, mikä on Opiskelia olioiden lisäämiseen Kokoelmaan tarkoitettu
                else if (lukija.Equals("poista")) Poista(); //Jos käyttäjä antaa poista komennon, niin käydään Poista metodi läpi, mikä on Opiskelia olioiden poistamiseen Kokoelmasta tarkoitettu metodi
                else if (lukija.Equals("poistu")) //Jos käyttäjä antaa poistu komennon, niin käydään läpi tämän else if lauseen sisältö ohjelmasta poistumiseen
                {
                    Console.WriteLine("Poistutaan sovelluksesta");
                    break; // Tämä lopettaa while loopin ja tässä tapauksessa koko ohjelman, voi käyttää myös return; komentoa loopista poistumiseen
                }
                else //Jos mitään komentoa ei annettu, mutta jotain kirjoitettiin, niin silloin tämä else lauseen sisältö käydään läpi
                {
                    Console.WriteLine("Virheellinen syöttö, yritä uudelleen");
                }
            }
        }

        static void Lisää() //Metodi Opiskelia olioiden lisäämiseen Opiskelijat Kokoelmaan
        {
 

            Console.WriteLine();               
            Console.WriteLine("-------");
            Console.WriteLine("Anna uuden Opiskelijan tiedot: ");
            Console.WriteLine();
            Kokoelma.LisääOpiskelija(); //Tämä toteuttaa LisääOpiskelija metodin Kokoelma luokalle, missä lisätään Opiskelija Kokoelma luokan sisällä luotuun Opiskelijat Kokoelma olioon
        }

        static void Poista() //Metodi Opiskelijat olioiden poistamiseen Opiskelijat Kokoelmasta
        {
            if (Kokoelma.Opiskelijat.Count == 0) //Jos Opiskelijat Kokoelma on tyhjä, niin silloin toteutetaan tämän if lauseen sisältö
            {
                Console.WriteLine("Opiskelija kokoelma on tyhjä!");
                return; //Tällä komennolla poistutaan Poista metodista ja palataan Main metodiin
            }

            Kokoelma.TulostaKokoelma(); //Metodi Opiskelijat Kokoelman sisällön tulostamiseen käyttäjälle

            int lukijaIndex; //Luodaan int muuttuja
            int opiskelijaMäärä = Kokoelma.Opiskelijat.Count; //Luodaaan ja määritetään int muuttuja, ja sen määritys on Opiskelijat Kokoelmassa olevien olioiden määrä

            while (true) //Tämä while looppi sitä varten, että pysytään tässä Metodissa niin kauan kunnes käyttäjä poistaa Opiskelija olion Opiskelijat Kokoelmasta
            {
                Console.WriteLine();
                Console.WriteLine("Kenet haluat poistaa? Valitse väliltä {0} - {1} : ", 1, opiskelijaMäärä); //Tulostaa Opiskelija oliot Opiskelijat Kokoelmasta 1 - niin monta oliota kuin Kokoelmassa on
                bool result = int.TryParse(Console.ReadLine(), out lukijaIndex); // Luodaan bool muuttuja, ja määritetään se Console.ReadLineksi, mutta int.TryParse komennolla tarkistetaan, että käyttäjän antama syöte on vain numero(oita), ja annettu arvo määrätään lukijaIndex muuttujalle

                if (result) //Jos result boolean on true, elikkä annettu arvo oli numeraalinen, niin tämän if lauseen sisältö suoritetaan
                { 
                    if (lukijaIndex <= opiskelijaMäärä && lukijaIndex > 0) //Jos käyttäjän antama arvo on pienempi tai yhtä suuri kuin Opiskelija olioiden määrä Opiskelijat Kokoelmassa JA annettu arvo on pienempi kuin 0, silloin tämä if lauseen sisältö suoritaan
                    {
                        Kokoelma.PoistaOpiskelija(lukijaIndex - 1); //Suoritetaan Kokoelma luokan sisältä PoistaOpiskelija metodi, mikä poistaa annettua arvoa vastaavan Opiskelija Olion Opiskelijat Kokoelmasta
                        break;  //Tällä poistutaan tästä TulostaKokoelma Metodista
                    }
                    else
                    {
                        Console.WriteLine("Virheellinen valinta, anna uusi valinta"); //Käyttäjä antoi numeron mikä ei vastannut mitään Opiskelijaa
                    }
                }
                else
                {
                    Console.WriteLine("Virheellinen syöttö. Syötöksi kelpaa vain numerot!"); //Käyttäjä antoi jonkun muun kuin numeron konsoliin
                }
            }
        }
    
    }
}
