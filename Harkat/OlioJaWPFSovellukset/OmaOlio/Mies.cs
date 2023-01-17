using System;
using System.Collections.Generic;
using System.Text;

namespace OmaOlio
{
    class Mies
    {
        public int Elämä = 100;
        public string Nimi;
        public bool Kuollut;
        public bool NimiAnnettu = false;
        public int Hulluus = 0;

        public Mies(bool _elos, int _elämä, int _hulluus)
        { 
            Kuollut = _elos;
            Elämä = _elämä;
            Hulluus = _hulluus; 
        }

        public void NäytäInfo()
        {
            if(NimiAnnettu !=true)
            {
                Nimi = Console.ReadLine();
                NimiAnnettu = true;
            }
            Console.WriteLine("Elämä Pointsit: " + Elämä + " Tila: Olet vielä elossa!" + "Hulluus Aste: " + Hulluus+ "%"  + " Urpon nimi: " + Nimi);
        }

        public void OtaLämää(int i)
        {
            Elämä = Elämä - i;
        }
    }
}   
