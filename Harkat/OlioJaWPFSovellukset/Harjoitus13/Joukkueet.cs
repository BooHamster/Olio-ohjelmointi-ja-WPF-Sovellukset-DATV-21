using System;
using System.Collections.Generic;
using System.Text;

namespace Harjoitus13
{
    class Joukkueet
    {
        public static Dictionary<string, Joukkue> SMLiiga = new Dictionary<string, Joukkue>(); //Luodaan Joukkue tyyppinen kokoelma
        public static string Tunnus { get; set; }
        public static string Nimi = "";
        public static string KotiKaupunki = "";

        //Luodaan Joukkue olioita Joukkueet luokan sisään
        public static Joukkue Jokerit = new Joukkue("Jokerit", "Helsinki", "JOK"); 
        public static Joukkue TPS = new Joukkue("TPS", "Turku", "TPS");
        public static Joukkue Kärpät = new Joukkue("Kärpät", "Tampere", "KÄR");
        public static Joukkue Tappara = new Joukkue("Tappara", "Tampere", "TAP");




        public static void LisääJoukkueet() // Metodi Joukkueiden lisäämiseen Joukkue tyyppisen listan sisään
        {
            SMLiiga.Add("Jokerit", Jokerit);
            SMLiiga.Add("TPS", TPS);
            SMLiiga.Add("Kärpät", Kärpät);
            SMLiiga.Add("Tappara", Tappara);
        }

        /*  
         Tämä koodi pätkä oli tarkoitettu joukkueiden lisäämiseen manuaalisesti, mikä muuten toimi, mutta kun joukkueeseen piti lisätä pelaaja, törmäsin ongelmiin
           public static bool TarkistaJoukkueenNimi(string id)
          {
              if (SMLiiga.ContainsKey(id))
              {
                  throw new Poikkeukset("Joukkue Tunnus " + id + " ei ole uniikki, anna uusi Tunnus"); //Tämä tulostuu jos annettu avain löytyi jo Kokoelmasta
              }
              else if (id.Length < 3 || id.Length > 3) //Tämä katsoo onko annettu avain annettujen arvojen sisällä, tässä tapauksessa ei lyhyempi tai pidempi kuin 6 merkkiä
              {
                  throw new Poikkeukset("Joukkueen Tunnus " + id + " on liian pitkä tai lyhyt. Joukkueen tunnuksen tulee olla tasan 3 merkkiä"); //Tämä tulostuu jos annettu avain oli väärän pituinen
              }
              else
              {
                  return true; //Jos avain oli sopivan pituinen ja uniikki, niin silloin palautetaan boolean arvo joka oli määritelty tälle metodille true arvoon
              }
          } */


        /*   public static void PoistaJoukkue(int syötettyIndex)
           {
               int i = 0; 

               foreach (string avain in SMLiiga.Keys) 
               {
                   if (i == syötettyIndex)  
                   {
                       TulostaViesti("Joukkue " + SMLiiga[avain].HaeData() + " poistettu SM-Liigasta "); 
                       SMLiiga.Remove(avain); 
                       break; 
                   }

                   i++; //i Muuttujan arvoa nostetaan yhdellä, niin kauan, että se vastaa syötettyIndex arvoa
               }
           } */

        public static void TulostaSMLiiga()  //Metodi Kokoelman sisällön tulostamiseen käyttäjälle
        {
            if (SMLiiga.Count == 0)
            {
                TulostaViesti("SM-Liigassa ei ole Joukkueita");
                return; //Poistutaan Metodista
            }

            int i = 1;

            TulostaViesti("Joukkueet SM-Liigassa: "); 

            foreach (Joukkue joukkue in SMLiiga.Values)
            {
                Console.WriteLine("{0}: {1}", i, joukkue.HaeData());
                i++;
            }
        }
        public static void TulostaViesti(string message)
        {
            Console.WriteLine();
            Console.WriteLine("-----------");
            Console.WriteLine(message);

        }

        public static string HaeData()
        {
            return Nimi + "." + " Kotikaupunki: " + "." + " Tunnus: " + Tunnus + "."; //Palauttaa nämä tiedot, tämän voisi kyllä toteuttaa myös Console.Write komennolla myös
        }
    }
}
