using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing.Imaging;
using System.Drawing;
using Microsoft.Win32;
//Robert Kajanti
namespace Harjoitus3
{
    class Program
    {
        static void Main(string[] args) //Ensimmäinen metodi ohjelmassa, mistä pyritään käynnistämään muut ohjelman metodit
        {
            {
                Boolean lopeta = false;  //Boolean muuttuja kyllä tai ei arvolla looppia varten
                Console.WriteLine("Tervetuloa käyttämään Harvia 3000, Burn your nuts off kiuasta");
                Kiuas(); // Kutsutaan Kiuas metodia
                while (lopeta != true) //While looppi jonka tarkoitus on antaa käyttäjälle mahdollisuus poistua ohjelmasta tai jatkaa sen käyttöä
                {
                    Console.ResetColor(); //Resetoidaan värit konsolissa
                    Console.WriteLine("Haluatko palata takaisin saunaan käyttämään Harvia kiuasta? K=kyllä/E=Ei");
                    string asetus = Console.ReadLine().ToUpper(); //Muuttuja joka tallentaa käyttäjän antamat merkit console readlinellä
                    if (asetus.Equals("E")) // if lause katsoo onko käyttäjän antama merkki sama
                    {
                        lopeta = true; //.ToUpper komento muuntaa kaikki käyttäjän antamat merkit suuriksi
                    }

                    else if (asetus.Equals("K")) 
                    {
                        Kiuas();
                    }

                    else //Jos käyttäjä antoi jonkun muun kuin k tai e kirjaimen
                    {                      
                        Console.WriteLine("");
                        Console.WriteLine("Väärä toiminto");
                    }

                }


                static void Kiuas()
                {
                    bool jatka = true;
                    Console.WriteLine();
                    Kiuas Kiuas1 = new Kiuas("Harvia 3000, Burn your nuts off model", false, 0, 0); // Luodaan kiuas olio
                    while (jatka == true && Kiuas1.Kuolit != true) // while looppi joka jatkaa kunnes käyttäjä lopettaa tai "kuolee"
                    {
                        try
                        {
                            Kiuas1.TulostaData(); // Metodi tulostaa kiuakaan tiedot konsoliin
                            Console.Write("Anna Toiminto: ");
                            string asetus = Console.ReadLine();  
                            if (asetus.Equals("k") && Kiuas1.Kuolit != true)
                            {
                                Kiuas1.ONJAOFF();
                            }

                            else if (asetus.Equals("n") && Kiuas1.Kuolit != true)
                            {
                                Kiuas1.LisääLämpöä(10);
                            }

                            else if (asetus.Equals("l") && Kiuas1.Kuolit != true)
                            {
                                Kiuas1.LaskeLämpöä(10);
                            }

                            else if (asetus.Equals("h") && Kiuas1.Kuolit != true)
                            {
                                Kiuas1.HeitäLöylyä(5);
                            }

                            else if (asetus.Equals("p") && Kiuas1.Kuolit != true)
                            {
                                jatka = false;
                            }

                            else
                            {
                                Console.WriteLine("Annoit väärän toiminnon");
                            }
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Annoit väärän toiminnon");
                        }
                    }
                }
            }
        }
    }
}
