using System;
using System.Collections.Generic;
using System.Text;

namespace Harjoitus10
{
    class Kala : Eläin, ICanSwim //Kala luokka joka periytyy eläin yliluokasta, ja se perii myös interfacen ICanSwim
    {
        //Kala olion muuttujat
        public int SwimSpeed { get; set; }
        public string Sound { get; set; }
        public Kala(string _nimi, string _sound, int _speed)
        {
            Nimi = _nimi;
            Sound = _sound;
            SwimSpeed = _speed;
        }
        public override void MakeASound() //Ylikirjoitetaan eläin yliluokan metodi
        {
            Console.WriteLine("blup blup");
        }
        public void Swim() //Luokassa lisätään tähän metodiin uusi koodi
        {
            Console.WriteLine("Kala {0}, ui nopeudella {1}", Nimi, SwimSpeed);
        }
    }
}
