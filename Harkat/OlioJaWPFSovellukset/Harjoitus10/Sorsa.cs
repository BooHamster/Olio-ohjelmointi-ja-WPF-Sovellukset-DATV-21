using System;
using System.Collections.Generic;
using System.Text;

namespace Harjoitus10
{
    class Sorsa : Eläin, ICanFly, ICanSwim //Sorsa luokka joka perii Eläin yliluokan, ja ICanFly ja IcanSwim Interfacet
    {
        public float WingSize { get; set; }
        public int SwimSpeed { get; set; }
        public Sorsa(string _nimi, float _wingsize, int _speed) //Konstruktori
        {
            Nimi = _nimi;
            WingSize = _wingsize;
            SwimSpeed = _speed;
        }
        public void Fly() //Lisätään tähän interfacesta perittyyn metodiin koodia
        {
            Console.WriteLine("{0} lentää. Siipien koko on {1}", Nimi, WingSize);
        }

        public override void MakeASound() //Ylikirjoitetaa yliluokasta perityn metodin koodia
        {
            Console.WriteLine("Quack Quack!");
        }

        public void Swim() //Lisätään tähän interfacesta perittyyn metodiin koodia
        {
            Console.WriteLine("Sorsa {0}, ui nopeudella {1}", Nimi, SwimSpeed);
        }
    }
}
