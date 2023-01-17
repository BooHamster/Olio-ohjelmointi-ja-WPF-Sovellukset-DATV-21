using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus20
{
    [Serializable]
    class Opiskelija //Opiskelija luokka
    {
        //Muuttujat
        private string etunimi;
        private string sukunimi;
        private string opiskelijaID;

        public string OpiskelijaID { get => opiskelijaID; set => opiskelijaID = value; }
        public string Sukunimi { get => sukunimi; set => sukunimi = value; }
        public string Etunimi { get => etunimi; set => etunimi = value; }
        public bool IsSelected { get; set; }


        public Opiskelija(string etunimi, string sukunimi, string opiskelijaID) //Konstruktori
        {
            this.Etunimi = etunimi;
            this.Sukunimi = sukunimi;
            this.OpiskelijaID = opiskelijaID;
            IsSelected = false;
        }


        public string HaeData() //Metodi Opiskelijan tietojen tulostukseen
        {
            return Etunimi + " " + Sukunimi + ". ID: " + OpiskelijaID;
        }
    }
}
