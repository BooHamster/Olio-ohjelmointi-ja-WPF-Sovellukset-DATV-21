using System;
//RObert Kajanti
namespace Harjoitus8
{
    class Program
    {
        static void Main(string[] args)
        {
            Työntekijä.KuinkaMonta(); //Metodi työntekijä olioiden laskemiseen ja tulostamiseen konsoliin
            Työntekijä Työntekijä1 = new Työntekijä("Kalle Tiihola", "TuhoonTuomitunKuja 56 C 20, Vantaa 1600", "Careeria Oy", 37.5M, 1); //Luodaan uusi työntekijä sen konstruktorin määrittelemillä muuttujilla, ja syötetään niihin arvot
            Työntekijä Työntekijä2 = new Työntekijä("Jesse Pelkonen", "Keskellä Ei Mitään Tie 66 D 6, Vantaa 1300", "Tikkurila Oy", 30.2M, 5);
            Pomo Pomo1 = new Pomo("Tero Kaikentietävä", "LuksusKuja 13 E 37, Espoo 0420", "SuperCell", 40M, 9); //Luodaan Pomo olio
            Työntekijä1.PalkkaTaulukko(); //Käytetään metodia joka näyttää työntekijän palkkatiedot
            Työntekijä2.PalkkaTaulukko();
            Työntekijä.KuinkaMonta();
            Pomo.KuinkaMonta();
            Pomo1.PalkkaTaulukko(500);
            Pomo Pomo2 = new Pomo("Baby Boss", "VauvaTie 22 A 40, Helsinki 0290", "SuperCell", 20M, 5);
            Pomo.KuinkaMonta();
        }
    }
}
