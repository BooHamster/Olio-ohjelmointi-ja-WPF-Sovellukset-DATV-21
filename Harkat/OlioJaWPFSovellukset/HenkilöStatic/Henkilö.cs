using System;
using System.Collections.Generic;
using System.Text;

namespace HenkilöStatic
{
    class Henkilö
    {
        private static int instanssit = 0;

        public Henkilö()
        {
            if(instanssit >4)
            {
                return; //Tuhoaa lisätyn henkilön
            }

            instanssit ++;
        }
        
        public static void KuinkaMontaHenkilöä()
        {
            Console.WriteLine("Henkilöitä olemassa " + instanssit);
        }
        public void EiStaattinenHenkilö() //Ei Staattinen Metodi
        {
            Console.WriteLine("Henkilöitä olemassa " + instanssit);
        }
    }
}
