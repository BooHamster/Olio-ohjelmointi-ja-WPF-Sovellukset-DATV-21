using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus26
{
    static class Enemy  //Staattinen vihollis luokka, mikä tuottaa viholliset peliin
    {
        //Vihollisen perusmuuttujat
        static public int Level;
        static public string Name;
        static public int STR;
        static public int CON;
        static public int DEX;
        static public int WIS;
        static public int INT;
        static public int HP;
        static public int MANA;
        static public int ARMOR;
        static public int ATK;
        static public int DMG;
        static public int baseHP;
        static public int baseMANA;
        static public int baseARMOR;
        static public int baseATK;
        static public int baseDMG;
        static public int PhysRES;
        static public int CRIT = 0;
        static public int CritChance = 20;
        static public int AttackRoll;
        static public bool confused;
        static public bool stunned;
        static public bool blinded;
        static public bool dazed;
        static public bool slowed;
        static public bool poisoned;
        static public int DiceRoll;
        static public int Exp;
        static public int Gold;
        static Random randomi = new Random();


        //Metodi Menninkäis vihulaisen luontiin
        static public void Goblin()
        {
            Name = "Goblin";
            STR = 8;
            CON = 10;
            DEX = 14;
            INT = 10;
            WIS = 8;
            baseARMOR = 15;
            baseATK = 4;
            baseDMG = randomi.Next(2, 4);
            baseHP = randomi.Next(2, 7) + Level * ((CON - 10) / 2);
            baseMANA = randomi.Next(2, 7);
            ARMOR = baseARMOR + ((DEX - 10) / 2);
            MANA = baseMANA * Level + Level * ((INT + WIS - 20) / 2);
            HP = baseHP;
            Level = 1;
            Exp = 50;
            Gold = 5;
        }

        //Metodi Örkki vihulaisen luontiin
        static public void Orc()
        {
            Name = "Orc";
            STR = 16;
            CON = 16;
            DEX = 12;
            INT = 7;
            WIS = 11;
            baseARMOR = 13;
            baseATK = 5;
            baseDMG = randomi.Next(1, 8);
            baseHP = randomi.Next(8, 15) + Level * ((CON - 10) / 2);
            baseMANA = randomi.Next(2, 7);
            ARMOR = baseARMOR + ((DEX - 10) / 2);
            MANA = baseMANA * Level + Level * ((INT + WIS - 20) / 2);
            HP = baseHP;
            Exp = 100;
            Gold = 10;
            Level = 2;
        }

        //Metodi Vihulaisen arvojen päivittämiseen joka kierroksella
        static public void EnemyUpdate()
        {
            ATK = baseATK + (STR - 10) / 2;
            DMG = baseDMG + (STR - 10) / 2;
            ARMOR = baseARMOR + (DEX - 10) / 2;
        }

        //Metodi joka laskee osuuko vihulais olio pelaaja olioon
        public static bool Hit(int Armor)
        {
            int CritChance = 20 - CRIT;
            DiceRoll = randomi.Next(1, 21);
            AttackRoll = ATK + DiceRoll;
            bool hit = AttackRoll > Armor;
            if (DiceRoll >= CritChance - CRIT)
            {
                hit = true;
            }
            return hit;
        }

        //Metodi joka laskee kuinka paljon vahinko vihulais olio tekee pelaaja oliolle, ja onko osuma kriittinen
        public static int Attack(int health, int phyres)
        {
            if (DiceRoll >= CritChance - CRIT)
            {
                health -= DMG * 2 - phyres;
            }

            else
            {
                health -= DMG - phyres;
            }
            return health;
        }
    }
}
