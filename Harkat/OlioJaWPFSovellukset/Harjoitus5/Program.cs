using System;
//Robert Kajanti
namespace Harjoitus5
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Boolean lopeta = false;
                Console.WriteLine("Tämä on Ultimate laskinator over 9000");
                while (lopeta != true)
                {
                    Laskin(); //Aloitetaan Laskin metodi
                    Console.WriteLine("Haluatko vielä laskea universumin salaisuuksia? E=Ei, muut näppäimet = Ohjelma jatkuu");
                    if (Console.ReadLine().ToUpper() == "E") lopeta = true;

                }
                Console.ReadLine();
            }
        }
        static void Laskin()
        {
            bool jatka = true;
            Console.WriteLine();
            while (jatka == true)
            {
                try //Virheiden löytämiseen tarkoitettu komento, joka katsoo koodi mikä on try lauseen sisällä, ja jos tulee virhe, niin silloin suorittaa catch lauseen sisällä olevan koodin
                {
                    Console.WriteLine();
                    Console.WriteLine("Minkälaisen laskun haluat tehdä?");
                    Console.WriteLine("Yhteenlasku syötä y, vähennyslasku syötä v, kertolasku syötä k, jakolasku syötä j, jos haluat lopettaa syötä p? ");
                    string asetus = Console.ReadLine(); //String tyyppiseen muuttujaan tallennetaan käyttäjän syöttämä arvo
                    Laskin Laskin1 = new Laskin(); //Luodaan laskin olio
                    if (asetus.Equals("y"))
                    {
                        Console.Write("Valitsit yhteenlaskun, syötä ensimmäinen luku: ");
                        Laskin1.ValueA = float.Parse(Console.ReadLine()); //Muutetaan käyttäjän ensimmäinen antama arvo float muotoon string muodosta, jotta sitä voidaan käyttää laskemiseen
                        Console.Write("Valitsit yhteenlaskun, syötä toinen luku: ");
                        Laskin1.ValueB = float.Parse(Console.ReadLine());                       
                        Laskin1.Summa(); //Suoritetaan Summa metodi käyttäjän antamaan kahteen muuttujaan
                    }

                    else if (asetus.Equals("v"))
                    {
                        Console.Write("Valitsit vähennyslaskun, syötä ensimmäinen luku: ");
                        Laskin1.ValueA = float.Parse(Console.ReadLine());
                        Console.Write("Valitsit vähennyslaskun, syötä toinen luku: ");
                        Laskin1.ValueB = float.Parse(Console.ReadLine());
                        Laskin1.Erotus();
                    }

                    else if (asetus.Equals("k"))
                    {
                        Console.Write("Valitsit kertolaskun, syötä ensimmäinen luku: ");
                        Laskin1.ValueA = float.Parse(Console.ReadLine());
                        Console.Write("Valitsit kertolaskun, syötä toinen luku: ");
                        Laskin1.ValueB = float.Parse(Console.ReadLine());
                        Laskin1.KertoLasku();
                    }

                    else if (asetus.Equals("j"))
                    {
                        Console.Write("Valitsit jakolaskun, syötä ensimmäinen luku: ");
                        Laskin1.ValueA = float.Parse(Console.ReadLine());
                        Console.Write("Valitsit jakolaskun, syötä toinen luku: ");
                        Laskin1.ValueB = float.Parse(Console.ReadLine());
                        Laskin1.JakoLasku();
                    }

                    else if (asetus.Equals("p")) //Loopin lopettamiseen tarkoitettu if lause
                    {
                        jatka = false;
                    }

                    else
                    {
                        Console.WriteLine("Annoit väärän toiminnon");
                    }
                }
                catch (Exception) // Tämän catch lauseen sisällä oleva koodi suoritetaan jos tulee virhe. esim jos käyttäjä antaisi jonkun arvon mitä ohjelma ei pysty kääntämään oikeaan muotoon kun suoritetaan laskimen eri metodeja
                {
                    Console.WriteLine("Annoit väärän toiminnon");
                }
            }

        }
    }
}
