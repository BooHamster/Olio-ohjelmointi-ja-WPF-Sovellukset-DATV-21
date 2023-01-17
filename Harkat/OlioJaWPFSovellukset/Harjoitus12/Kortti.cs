using System;
using System.Collections.Generic;
using System.Text;

namespace Harjoitus12
{
    class Kortti
    {
        private string Nimi { get; set; }
        
        public Kortti(string _nimi)
        {
            Nimi = _nimi;
        }

        public string Tiedot()
        {
          return Nimi;
        }
    }
}
