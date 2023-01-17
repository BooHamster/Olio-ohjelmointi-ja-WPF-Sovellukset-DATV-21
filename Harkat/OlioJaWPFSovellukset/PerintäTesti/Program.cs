using System;
//Robert Kajanti
namespace PerintäTesti
{
    class Program
    {
        static void Main(string[] args)
        {
            Henkilö henkilö = new Henkilö();

            henkilö.Nimi = "Matti";
            henkilö.Puhu();
            Console.WriteLine(henkilö.ToString());

            Opiskelija opiskelija = new Opiskelija();

            opiskelija.Nimi = "Pelle";
            opiskelija.Puhu();
            Console.WriteLine(opiskelija.ToString());

            Eläin.KuinkaMonta();
            Koira.KuinkaMonta();
            Kissa.KuinkaMonta();

            Eläin eläin = new Eläin();
            Koira.KuinkaMonta();

            eläin.Ääntele();

            Koira koira = new Koira();
            koira.Ääntele();

            Koira koira2 = new Koira();

            Koira koira3 = new Koira();

            Kissa kissa = new Kissa();
            kissa.Ääntele();

            Kissa kissa2 = new Kissa();

            Kissa kissa3 = new Kissa();

            Eläin.KuinkaMonta();
            Koira.KuinkaMonta();
            Kissa.KuinkaMonta();

        }
    }
}
