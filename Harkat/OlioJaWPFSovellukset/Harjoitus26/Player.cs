using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus26
{
    abstract class Player //Abstrakti Pelaaja luokka jonka pohjalta luodaan muut pelaaja luokat
    {
        //Pelaajan perus Muuttujat

        public string Name;
        public string Sex;
        public string Race;
        public int DwarfHP = 2;
        public int DwarfAC = 1;
        public int STR;
        public int CON;
        public int DEX;
        public int WIS;
        public int INT;
        public int HP;
        public int MANA;
        public int ARMOR;
        public int ATK;
        public int PhysRES = 0;
        public int LEVEL = 1;
        public int EXP = 0;
        public int DMG = 1;
        public int CRIT = 0;
        public int Gold = 100;
        public string CLASS;
        public bool confused;
        public bool stunned;
        public bool blinded;
        public bool dazed;
        public bool slowed;
        public bool poisoned;
        static public int DiceRoll;
        public int FreeStats;

        abstract public void LEVELUP();      //Levelin nosto Metodi 


        abstract public int Attack(int damage, int phyres); //Normaali Hyökkäys metodi

    }
}
