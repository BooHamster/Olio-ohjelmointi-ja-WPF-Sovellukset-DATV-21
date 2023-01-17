using System;
using System.Collections.Generic;
using System.Text;

namespace Harjoitus10
{
    interface ICanSwim //interface, eli käyttöliittymä, jonka eri luokat voivat periä, ja interfaceja voi periä useamman, kun taas yliluokkia ei
    {
        public int SwimSpeed { get; set; } 
         
        public void Swim(); //Metodio johon ei ole määritelty vielä mitään, mutta voidaan määritellä luokassa johon se peritään
 
    }
}
