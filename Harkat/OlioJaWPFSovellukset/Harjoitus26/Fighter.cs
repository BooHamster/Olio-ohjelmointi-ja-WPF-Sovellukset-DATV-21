using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus26
{
    class Fighter : Player //Tappelija/Fighter Luokka
    {
        //Tappelija luokan muuttujat
        public int baseHP = 10;
        public int baseMANA = 3;
        public int baseATK;
        public int baseDMG;
        public int baseARMOR;
        public int AttackRoll;
        public int DiceRoll;
        public int CritChance = 20;
        public int ExpBase = 200;
        Random randomi = new Random();

        //Konstruktori Tappelija luokalle
        public Fighter(string _name, int _str, int _con, int _dex, int _wis, int _int, string _sex, string _race)
        {
            Name = _name;
            STR = _str;
            CON = _con;
            DEX = _dex;
            WIS = _wis;
            INT = _int;
            Sex = _sex;
            Race = _race;
        }

        //Metodi joka asettaa luokan oliolle sen aloitusarvot
        public void Initiate()
        {
            CLASS = "Fighter";
            if (Race == "Dwarf")
            {
                baseHP = baseHP + DwarfHP + LEVEL * ((CON - 10) / 2);
            }
            else
            {
                baseHP = baseHP + LEVEL * ((CON - 10) / 2);
            }
            baseMANA = baseMANA + LEVEL * (INT + WIS - 20) / 2;
            baseATK = 5;
            baseARMOR = 10;
            baseDMG = 1;
            HP = baseHP;
            MANA = baseMANA;
        }

        //Metodi joka päivittää olion arvoja joka kierroksen alussa
        public void PlayerUpdate()
        {
            ATK = baseATK + (STR - 10) / 2;
            DMG = baseDMG + (STR - 10) / 2;
            ARMOR = baseARMOR + (DEX - 10) / 2;
            if (Race == "Dwarf")
            {
                ARMOR -=  DwarfAC;
            }

        }

        //Metodi joka tarkistaa olion kokemuspisteet, ja nostaa tasoa jos kokemusta on tarpeeksi, ja nostaa olion arvoja
        override public void LEVELUP()
        {
            while (ExpBase <= EXP)
            {
                LEVEL++;
                if (Race == "Dwarf")
                {
                    baseHP = baseHP + DwarfHP + LEVEL * ((CON - 10) / 2);
                    baseHP += LEVEL * DwarfHP + LEVEL * 10;
                }
                else
                {
                    baseHP = baseHP + LEVEL * ((CON - 10) / 2);
                    baseHP += LEVEL * 10;
                }
                baseMANA = baseMANA + LEVEL * (INT + WIS - 20) / 2;
                baseMANA += 2;
                ATK += 3;
                FreeStats++;
                ExpBase *= 2;
            }
        }

        //Metodi jolla tarkistetaan osuuko olio vastustajaan hyökkäyksellä
        public bool Hit(int Armor)
        {
            DiceRoll = randomi.Next(1, 21);
            AttackRoll = ATK + DiceRoll;
            bool hit = AttackRoll > Armor;
            if (DiceRoll >= CritChance - CRIT)
            {
                hit = true;
            }
            return hit;
        }

        //Metodi joka laskee vahingon määrän, ja tarkistaa onko osuma kriittinen, jos nopan arvo ylittää tietyn arvon
        override public int Attack(int health, int phyres)
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
