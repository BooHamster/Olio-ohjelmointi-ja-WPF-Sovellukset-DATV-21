using System;
using System.Collections.Generic;
using System.Text;

namespace Harjoitus10
{
    abstract class Eläin //Eläin yliluokka, se on abstrakti, mikä tarkoittaa, että itse Eläin luokasta ei voi tehdä oliota, vaan sen luokan voi periä vain toinen luokka
    {
        public string Nimi { get; set; }

        public abstract void MakeASound(); //Abstrakti metodi joka periytyy alaluokille, ja sen voi ylikirjoittaa
    }
}
