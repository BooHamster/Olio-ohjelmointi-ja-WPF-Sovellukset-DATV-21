using System;
using System.Collections.Generic;
using System.Text;

namespace Harjoitus6
{
    class Monkey : Eläin
    {
            private static int instanssit = 0; //staattinen muttuja jota voidaan kutsua itse luokalla, luomatta luokan oliota

        public Monkey()
            {
                instanssit++;
            }

        public static new void KuinkaMonta()
        {
            Console.WriteLine("Monkeja luotu " + instanssit);
        }
        public override void Ääntele() //ylikirjoitetaan Eläin luokan metodi
        {
            Console.WriteLine("U-U-A-A");
        }
    }
}
