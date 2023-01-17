using System;
using System.Windows.Input;
using Xamarin.Forms;
//Robert Kajanti
namespace Harjoitus7
{
    class Program
    {
        static void Main(string[] args)
        {
            Hissi Hissi1 = new Hissi(); //Luodaan uusi Hissi olio

            while (true) //while looppi jatkuu kunnes sen ehto ei täyty enää
            {
                try //Virheen ilmoitus tsekkausta varten
                {
                    Console.Write("Olet hississä jossa on 1-6 kerrosta, mihin kerrokseen haluaisit mennä? Anna kerroksen numero ja paina Enter: ");
                    Hissi1.AsetaKerros(); // Hissi1 Olio käyttää AsetaKerros metodia, minkä sisällä asetetaan kerros ja myös tulostaa missä kerroksessa käyttäjä on
                    Console.WriteLine("jos haluat poistua hissistä paina 'p' nappia, muuten paina mitä vaan: ");
                    if (Console.ReadKey(true).Key == ConsoleKey.P) //Katsoo jos käyttäjä painoi P näppäintä näppäimistöltä, ja jos painoi, silloin if lauseen sisältö suoritetaan
                    {
                        Console.WriteLine("Poistuit hissistä");
                        break; //Asetetaan while loopin jatkamis boolean falseksi, jotta while loop pysähtyy
                    }
                   
                }
                catch (Exception) //Jos try komento löytää sen sisältä virheen, niin tämä catch komento suoritetaan
                {
                    Console.WriteLine("Annoit väärän toiminnon"); //Kirjoittaa consoliin virheilmoituksen, jos käyttäjä antoi komennon mille ei ole koodattu mitään vastiketta
                }
            }
            //Hissi1.Kerros = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("Olet kerroksessa: " + Hissi1.Kerros.ToString());

        }
    }
}
