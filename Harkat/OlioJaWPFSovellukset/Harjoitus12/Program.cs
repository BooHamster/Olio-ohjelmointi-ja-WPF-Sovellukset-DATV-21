using System;
//Robert Kajanti
namespace Harjoitus12
{
    class Program
    {
        static void Main(string[] args)
        {
            string lukija = ""; //Luodaan string tyyppinen muuttuja

            while (true) //While looppi käyttäjän kirjoittamia komentoja varten
            {
                Console.WriteLine();
                Console.WriteLine("Tämä on KorttiPakka sovellus, Voit lisätä Kortit Pakkaan, Näyttää kortit Pakassa, ja Sekoittaa Kortit Pakassa ");
                Console.WriteLine();
                Console.WriteLine("Anna komento (Näytä, Lisää, Sekoita tai Poistu) : ");
                lukija = Console.ReadLine().ToLower(); //Määritetään lukija muuttuja Console.ReadLineksi, jolla käyttäjä antaa komennot, ja samalla muuntaa kaikki käyttäjän kirjoittaman pieniksi kirjaimiksi, jolloin sillä ei ole väliä kirjoittaako pieniä vai isoja kirjaimia

                if (lukija.Equals("näytä")) Pakka.TulostaPakka(); //Jos käyttäjä antaa näytä komennon, niin Pakka luokka toteuttaa TulostaPakka metodin, mikä tulostaa Kokoelman tiedot

                else if (lukija.Equals("lisää")) Pakka.LisääKortit2(); //Jos käyttäjä antaa lisää komennon, niin Lisää metodi käydään käpi, mikä on Kortit olioiden lisäämiseen Kokoelmaan tarkoitettu
                else if (lukija.Equals("sekoita")) Pakka.Sekoita(); //Jos käyttäjä antaa Sekoita komennon, niin Pakka luokka käy Sekoita Metodin läpi, mikä sekoittaa Kortti Kokoelman Kortit, ja tulostaa sekoitetun Kokoelman järjestyksen käyttäjälle
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
       
    }
}
