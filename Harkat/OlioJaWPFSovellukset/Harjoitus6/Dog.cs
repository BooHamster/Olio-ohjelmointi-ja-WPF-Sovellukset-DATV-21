using System;
using System.Collections.Generic;
using System.Text;

namespace Harjoitus6
{
    class Dog : Eläin //Koira aliluokka, perii Eläin yliluokan : Eläin toiminnolla
    {
        private static int instanssit = 0; //staattinen muttuja jota voidaan kutsua itse luokalla, luomatta luokan oliota

        public Dog()
        {
            instanssit++; //tätä muuttujaa lisätään aina yhdellä kun luokan olio luodaan
        }

        public static new void KuinkaMonta() //Metodi joka tuo konsoliin Dog luokan olioiden määrän
        {
            Console.WriteLine("Dogeja luotu " + instanssit);
        }
        public override void Ääntele() //ylikirjoitetaan Eläin luokan metodi
        {
            Console.WriteLine("Woof");
        }
    }
}
