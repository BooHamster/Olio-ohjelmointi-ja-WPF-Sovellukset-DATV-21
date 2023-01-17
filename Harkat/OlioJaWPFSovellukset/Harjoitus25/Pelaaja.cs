using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus25
{
    [Serializable] //Sarjasoitavissa oleva luokka, jota tarvitaan kun tallennetaan pelaajatiedot
    class Pelaaja
    {
        //Muuttujat
        private string _etunimi;
        private string _sukunimi;
        private int _pelaajaNumero;

        public string Etunimi { get => _etunimi; set => _etunimi = value; }
        public string Sukunimi { get => _sukunimi; set => _sukunimi = value; }
        public int PelaajaNumero { get => _pelaajaNumero; set => _pelaajaNumero = value; }
        public bool Valittuna{ get; set; }

        //Konstruktori
        public Pelaaja(string _etunimi, string _sukunimi, int _pelaajaNumero) 
        {
            this.Etunimi = _etunimi;
            this.Sukunimi = _sukunimi;
            this.PelaajaNumero = _pelaajaNumero;
            Valittuna = false;
        }

        public string Tiedot() //Metodi pelaajatietojen tulostukseen
        {
            return "---Pelaajan Tiedot: Etunimi: " + Etunimi + ". Sukunimi: " + Sukunimi  + ". PelaajaNumero: " + PelaajaNumero;              
        }
    }
}
