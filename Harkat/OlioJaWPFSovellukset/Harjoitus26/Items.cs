using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus26
{
    //Tavaroiden luokka
    class Items 
    {
        public bool bronzeSword;
        public bool bronzeShield;

        //Metodi tarkistamaan mikä ase pelaaja oliolla on käytössä
        public int Weapon()
        {
            int WeaponDamage = 0;
            if (bronzeSword)
            {
                WeaponDamage = 1;
            }
            return WeaponDamage;
        }

        //Metodi tarkistamaan mitkä haarniskan osat pelaaja oliolla on päällä
        public int Armor()
        {
            int ArmorClass = 0;
            if (bronzeShield)
            {
                ArmorClass = 1;
            }
            return ArmorClass;
        }
    }
}
