using System;
using System.IO;
//Robert Kajanti
namespace Harjoitus14
{
    class Program
    {
        static void Main(string[] args)
        {
            string komento = "";
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Tämä on muistiinpanot ohjelma");
                Console.WriteLine();
                Console.WriteLine("Anna komento uusi, tulosta, tyhjennä tai poistu : ");
                komento = Console.ReadLine().ToLower(); //Määritetään lukija muuttuja Console.ReadLineksi, jolla käyttäjä antaa komennot, ja samalla muuntaa kaikki käyttäjän kirjoittaman pieniksi kirjaimiksi, jolloin sillä ei ole väliä kirjoittaako pieniä vai isoja kirjaimia

                if (komento.Equals("uusi")) Lisää();
                else if (komento.Equals("tulosta")) Tulosta(); //Jos käyttäjä antaa lisää komennon niin Lisää metodi käydään käpi, mikä on Opiskelia olioiden lisäämiseen Kokoelmaan tarkoitettu
                else if (komento.Equals("tyhjennä")) Tyhjennä(); //Jos käyttäjä antaa poista komennon, niin käydään Poista metodi läpi, mikä on Opiskelia olioiden poistamiseen Kokoelmasta tarkoitettu metodi
                else if (komento.Equals("poistu")) //Jos käyttäjä antaa poistu komennon, niin käydään läpi tämän else if lauseen sisältö ohjelmasta poistumiseen
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
        public static void Lisää() //Metodi joka luo tekstiedoston jos sitä ei ole vielä luotu, ja lisää tekstitiedostoon tekstiä joka tallennetaan string muuttujaan
        {
            try
            {
                string path = @"c:\Tekstit\Muistiinpanot.txt";
                string Tekstiä;
                if (!File.Exists(path))
                {
                    using (StreamWriter sw = File.CreateText(path))
                    {
                        sw.WriteLine("Uusi TekstiTiedosto");
                        sw.WriteLine("Tiedosto on luotu " + DateTime.Now.ToString());
                        sw.WriteLine("--------------------");
                    }
                }
                using (StreamWriter sw = File.AppendText(path))
                {
                    Console.WriteLine("Kirjoita uusi muistiinpano");
                    Tekstiä = Console.ReadLine();
                    sw.WriteLine(Tekstiä);
                    Console.WriteLine("Muistiinpano tallennettu");
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File NotFound (FileNotFoundException");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static void Tulosta() //Metodi joka tulostaa konsoliin tekstitiedoston sisältämän tekstin
        {
            string path = @"c:\Tekstit\Muistiinpanot.txt";
            /*  using (StreamReader sr = File.OpenText(path)) // Toinen tapa tulostaa tiedot konsoliin
                  {
                      string s = "";
                      while ((s = sr.ReadLine()) != null)
                      {
                          Console.WriteLine(s);
                      }
                  }
            */
            string text = System.IO.File.ReadAllText(path);
            System.Console.WriteLine("Contents of test.txt: \n" + text);
        }

        public static void Tyhjennä() //Metodi joka tyhjentää tekstitiedostosta tekstit
        {
            string path = @"c:\Tekstit\Muistiinpanot.txt";
            File.Create(path).Close();
            Console.WriteLine("Muistiinpanot on poistettu!");
        }
    }
}


