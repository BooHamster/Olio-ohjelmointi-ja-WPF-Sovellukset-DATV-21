using System;
using System.Collections.Generic;
using System.Text;

namespace Harjoitus8
{
    class Työntekijä : Henkilö // Työntekijä luokka
    {

        private static int instanssit = 0; //Työntekijä luokan muuttujat

        public override string Nimi { get; set; }
        public override string Osoite { get; set; }
        public string TyöPaikka { get; set; }
        public int Palkkaluokka { get; set; }
        public decimal Tunnit { get; set; }
        public decimal Palkka { get; set; }

        public Työntekijä(string _nimi, string _osoite, string _työ, decimal _tunnit, int _luokka) //Työntekijä olion konstruktorin muuttujat
        {
            Console.WriteLine("Työntekijä lisätään");
            Console.WriteLine();
            Nimi = _nimi;
            Osoite = _osoite;
            TyöPaikka = _työ;
            Tunnit = _tunnit;
            Palkkaluokka = _luokka;
            instanssit++;
        }

        public static void KuinkaMonta() //Metodi työntekijä olioiden laskemiseen
        {
            Console.WriteLine("Työntekijöitä luotu " + instanssit);
            Console.WriteLine();
        }

        public void PalkkaTaulukko() 
        {
            Console.WriteLine("Työntekijän tiedot: ");
            Console.WriteLine("-- Nimi:  " + Nimi);
            Console.WriteLine("-- Osoite:  " + Osoite);
            Console.WriteLine("-- Työpaikka:  " + TyöPaikka);
            Console.WriteLine("-- Tarkat palkkatiedot: ");
            
            if (Palkkaluokka == 1)
            {
                decimal conversion = 8.00M;
                Console.WriteLine("-- Palkka tunnissa: 8 euroa");
                Console.WriteLine("-- Palkka viikossa: " + Tunnit * conversion + " euroa");
                Palkka = Tunnit * conversion * 4;
            }
            else if (Palkkaluokka == 2)
            {
                decimal conversion = 10.15M;
                Console.WriteLine("-- Palkka tunnissa: tunnissa: 15.15 euroa");
                Console.WriteLine("-- Palkka  viikossa: " + Tunnit * conversion + " euroa");
                Palkka = Tunnit * conversion * 4;
            }
            else if (Palkkaluokka == 3)
            {
                decimal conversion = 11.55M;
                Console.WriteLine("-- Palkka tunnissa: 11.55 euroa");
                Console.WriteLine("-- Palkka  viikossa: " + Tunnit * conversion + " euroa");
                Palkka = Tunnit * conversion * 22;
            }
            else if (Palkkaluokka == 4)
            {
                decimal conversion = 12.85M;
                Console.WriteLine("-- Palkka tunnissa: 12.85 euroa");
                Console.WriteLine("-- Palkka  viikossa: " + Tunnit * conversion + " euroa");
                Palkka = Tunnit * conversion * 4;
            }

            else if (Palkkaluokka == 5)
            {
                decimal conversion = 15.85M;
                Console.WriteLine("-- Palkka tunnissa: 15.85 euroa");
                Console.WriteLine("-- Palkka  viikossa: " + Tunnit * conversion + " euroa");
                Palkka = Tunnit * conversion * 4;
            }

            else if (Palkkaluokka == 6)
            {
                decimal conversion = 18.85M;
                Console.WriteLine("-- Palkka tunnissa: 18.85 euroa");
                Console.WriteLine("-- Palkka  viikossa: " + Tunnit * conversion + " euroa");
                Palkka = Tunnit * conversion * 4;
            }
            else if (Palkkaluokka == 7)
            {
                decimal conversion = 20.95M;
                Console.WriteLine("-- Palkka tunnissa: 20.95 euroa");
                Console.WriteLine("-- Palkka  viikossa: " + Tunnit * conversion + " euroa");
                Palkka = Tunnit * conversion * 4;
            }

            else if (Palkkaluokka == 8)
            {
                decimal conversion = 25.5M;
                Console.WriteLine("-- Palkka tunnissa: 25.5 euroa");
                Console.WriteLine("-- Palkka  viikossa: " + Tunnit * conversion + " euroa");
                Palkka = Tunnit * conversion * 4;
            }

            else if (Palkkaluokka == 9)
            {
                decimal conversion = 50.85M;
                Console.WriteLine("-- Palkka tunnissa: 50.85 euroa");
                Console.WriteLine("-- Palkka  viikossa: " + Tunnit * conversion + " euroa");
                Palkka = Tunnit * conversion * 4;
            }
            Console.WriteLine("-- Kuukausi Palkka:  " + Palkka + " euroa");
            Console.WriteLine("-- Työtunnit kuukaudessa:  " + Tunnit);
            Console.WriteLine("-- Palkkaluokka:  " + Palkkaluokka);
            Console.WriteLine();
        }
        public void TulostaData()
        {
            Console.WriteLine("Työntekijän tiedot: ");
            Console.WriteLine("-- Nimi:  " + Nimi); 
            Console.WriteLine("-- Osoite:  " + Osoite);
            Console.WriteLine("-- Työpaikka:  " + TyöPaikka);
            Console.WriteLine("-- Työtunnit kuukaudessa:  " + Tunnit);
            Console.WriteLine("-- Palkkaluokka:  " + Palkkaluokka);
            Console.WriteLine("-- Kuukausi Palkka:  " + Palkka);
            Console.WriteLine();
        }
    }
}
