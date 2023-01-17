using System;
//Robert Kajanti
namespace HenkilöStatic
{
    class Program
    {
        static void Main(string[] args)
        {
            Henkilö.KuinkaMontaHenkilöä();

            Henkilö Henkilö1 = new Henkilö();
            Henkilö.KuinkaMontaHenkilöä();

            Henkilö1.EiStaattinenHenkilö(); // Ei staattisen metodin kutsunta

            Henkilö Henkilö2= new Henkilö();
            Henkilö Henkilö3 = new Henkilö();
            Henkilö Henkilö4 = new Henkilö();
            Henkilö Henkilö5 = new Henkilö();
            Henkilö Henkilö6 = new Henkilö();
            Henkilö Henkilö7 = new Henkilö();
            Henkilö.KuinkaMontaHenkilöä();
        }
    }
}
