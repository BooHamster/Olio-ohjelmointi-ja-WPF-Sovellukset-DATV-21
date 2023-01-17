using System;
//Robert Kajanti
namespace Harjoitus9
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean lopeta = false; //asettaa true/false booleanin jota käytetään ohjelman jatkumiseen tai lopettamiseen, se asetetaan ensin false tilaan tässä tapauksessa
            Console.WriteLine("Edessäsi on matkaradio, päätät kokeilla mitä kanavia löydät");
            while (lopeta != true) //while looppi joka käy niin kauan kunnes ehto lopeta !=true ei täyty enää, !=true on sama kuin jos ehto olisi ==false, elikkä lopeta booleanin pitää olla false tilassa jotta ehto täyttyy
            {
                Radio(); //Suorittaa Radio metodin, kun Radio metodista palataan takaisin pääohjelmaan(Main), niin sen jälkeen suoritetaan tämän while loopin loppu sisältö
                Console.ResetColor(); //Resetoi värit
                Console.WriteLine("Haluatko palata radion ääreen? K=kyllä/E=Ei");
                if (Console.ReadLine().ToUpper() == "E") lopeta = true; // Käyttäjän on annettava E, jos käyttäjä antaa pienen e kirjaimen, niin ToUpper komento vaihtaa sen isoksi E kirjaimeksi, tällöin ohjelma lopettaa suorittamisen koska lopeta boolean vaihtuu true tilaan, jos käyttäjä antaa jonkun muun merkin, niin ohjelma jatkaa suoritusta. 
                                                                        //Tämä To.Upper tarkastus toimii hyvin vain jos on yksi if lause, koska useammalla if lausekkeella se käy läpi jokaisen if lauseen, eli käyttäjän on annettava joku komento joka ikiseen if lauseeseen, ellei sitten ole tarkoitus vastata jotain kaikkiin if lauseisiin
            }
            Console.ReadLine(); // Tämä on vain ohjelman lopetusta varten, jotta ohjelma ei sulkeudu suoraan
        }

        static void Radio() // Suoritetaan Radio metodi
        {
            bool jatka = true; // Luodaan boolean while loopin jatkumiselle
            Console.WriteLine(); //Luodaan Tyhjä rivi
            Kanava Kanava1 = new Kanava("Radio Pop", 88.9M); //Luodaan Kanava olioita
            Kanava Kanava2 = new Kanava("Radio Rock", 95.1M);
            Kanava Kanava3 = new Kanava("Radio Poppi Doppi", 99.5M);
            Kanava Kanava4 = new Kanava("Radio Hard Rock", 102.7M);
            Kanava Kanava5 = new Kanava("Radio Populääri", 104.2M);
            Kanava Kanava6 = new Kanava("Radio Rock Forever", 106.8M);
            Kanava Kanava7 = new Kanava("Radio Pop Sky", 107.9M);
            Radio Radio1 = new Radio("Sony WalkMan Radio", false, 0, 88.0M); //Luodaan uusi radio olio, ja asetetaan sille arvot(string Nimi ja bool_on, mitkä on määritelty Radio luokan konstruktorissa
            while (jatka == true)
            {
                try
                {
                    Radio1.TulostaData(); //Tulostetaan radio olion tiedot
                    //Katsotaan mikä Kanava radiosta otetaan jos radion taajuus muuttuja vastaa kanavan taajuus muuttujaa
                    if (Radio1.Taajuus == Kanava1.Taajuus)
                    {
                        Kanava1.TulostaKanava(); //Tulostetaan kanava olion tiedot
                        Kanava1.TulostaPopKanava();
                    }
                    if (Radio1.Taajuus == Kanava2.Taajuus)
                    {
                        Kanava2.TulostaKanava();
                        Kanava2.TulostaRockKanava();
                    }
                    if (Radio1.Taajuus == Kanava3.Taajuus)
                    {
                        Kanava3.TulostaKanava();
                        Kanava3.TulostaPopKanava();
                    }
                    if (Radio1.Taajuus == Kanava4.Taajuus)
                    {
                        Kanava4.TulostaKanava();
                        Kanava4.TulostaRockKanava();
                    }
                    if (Radio1.Taajuus == Kanava5.Taajuus)
                    {
                        Kanava5.TulostaKanava();
                        Kanava5.TulostaPopKanava();
                    }
                    if (Radio1.Taajuus == Kanava6.Taajuus)
                    {
                        Kanava6.TulostaKanava();
                        Kanava7.TulostaRockKanava();
                    }
                    if (Radio1.Taajuus == Kanava7.Taajuus)
                    {
                        Kanava7.TulostaKanava();
                        Kanava7.TulostaPopKanava();
                    }

                    string asetus = Console.ReadLine();
                    if (asetus.Equals("k")) //Radion päälle ja pois asettamisen íf lause
                    {
                        Radio1.ONJAOFF();
                    }
                    
                    else if (asetus.Equals("w")) //Radion Äänenvoimakkuuden ja laskemisen(alapuolella) if lauseet
                    {
                        Radio1.NostaÄänenVoimakkuutta(1);
                        Console.WriteLine("Nostit äänenvoimakkuutta");
                    }

                    else if (asetus.Equals("s"))
                    {
                        Radio1.LaskeÄänenVoimakkuutta(1);
                        Console.WriteLine("Laskit äänenvoimakkuutta");
                    }

                    else if (asetus.Equals("n")) //Radion taajuuden nostamiseen ja laskemiseen(alapuolella) if lauseet
                    {
                        Radio1.NostaTaajuutta(0.1M);
                        Console.WriteLine("Nostit taajuutta");
                    }

                    else if (asetus.Equals("l"))
                    {
                        Radio1.LaskeTaajuutta(0.1M);
                        Console.WriteLine("Laskit taajuutta");
                    }

                    else if (asetus.Equals("p")) //Radiolta poistumisen if lause
                    {
                        jatka = false;
                        Console.WriteLine("Poistuit radion ääreltä");
                    }
                }
                catch (Exception) //Jos käyttäjä antoi jonkun virheellisen toiminnon niin tämä catch lauseen sisältö toteutuu
                {
                    Console.WriteLine("Annoit väärän toiminnon");
                }
            }
        }


    }
}
