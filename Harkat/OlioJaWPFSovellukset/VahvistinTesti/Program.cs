using System;
//Robert Kajanti
namespace VahvistinTesti
{
    class Program
    {
        static void Main(string[] args)
        {
            int Uusivoimakkuus; //Luodaan uusi int tyyppinen muuttuja

            Console.WriteLine("Luodaan uusi vahvistin");

            Vahvistin vahvistin = new Vahvistin(); //Luodaan uusi vahvistin olio

            Console.WriteLine("Uusi vahvistin luotu, poistu kirjoittamalla 'sammuta' ");

            while (true) //luodaan while looppi joka käy itseään läpi ilman erillistä muuttujaa pelkällä true ehdolla, mikä voidaan kumota break; komennolla
            {
                Console.WriteLine("Anna uusi äänenvoimakkuus vahvistimelle (0-100): ");
                string LuettuArvo = Console.ReadLine(); //asetetaan string muuttuja, minkä arvon käyttäjä antaa Konsolissa

                if (LuettuArvo.Equals("sammuta")) //Jos käyttäjä kirjoitti täsmälleen "sammuta", pieninkirjaimin, niin if lauseen sisältö suoritetaan
                {
                    break; //Poistutaan loopista
                }

                bool result = int.TryParse(LuettuArvo, out Uusivoimakkuus); //Tämä muuttuja ensin katsoo onko käyttäjän antama arvo muuttujaan string LuettuArvo numero, vai onko siinä kirjaimia, jos se on pelkkä numero(oita), niin silloin se on true, jos siinä on kirjaimia se on false, ja lopuksi se asettaa annetun arvon int UusiVoimakkuus muuttujalle

                if(result) //Sama kuin result == true, jos Try.Parse palautti numeraalisen arvon LuettuArvo muuttujasta, ja asetti sen Uusivoimakkuus muuttujalle, silloin käydään tämän if lauseen sisältö läpi
                {
                    vahvistin.Äänenvoimakkuus = Uusivoimakkuus; //vahvistin olion Äänenvoimakkuus muuttuja asetetaan samaksi kuink UusiVoimakkuus muuttuja
                }

                else //Tämän sisältö käydään läpi vain jos Try.Parse palautti muuta kuin pelkän numeraalisen arvon LuettuArvo muuttujasta, elikkä käyttäjä oli syöttänyt esim. kirjaimia numeroiden sijaan
                {
                    Console.WriteLine("Error: Annettu arvo oli virheellinen, mikäli haluat sammuttaa vahvistimen, kirjoita 'sammuta' ");
                }
            }

            Console.WriteLine("Vahvistin on sammutettu"); //Tämä käydään läpi jos poistutaan while loopista
        }
    }
}
