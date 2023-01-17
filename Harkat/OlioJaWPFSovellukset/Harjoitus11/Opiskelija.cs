using System;
using System.Collections.Generic;
using System.Text;

namespace Harjoitus11
{
    class Opiskelija
    {
          private string etunimi { get; set; } //Asetetaan Opiskelija luokalle sen muuttujat, tässä tapauksessa private tyyppisenä, public kyllä toimisi myös tässä
          private string sukunimi { get; set; }
          private string ryhmäTunnus { get; set; }
          private string opiskelijaID { get; set; }

          public Opiskelija(string _etunimi, string _sukunimi, string _ryhmä, string _id) //Luodaan konstruktori Opiskelija luokan Olioille, nämä arvot vaaditaan/asetetaan aina kun luodaan uutta Opiskelijaa
          {
              etunimi = _etunimi;
              sukunimi = _sukunimi;
              ryhmäTunnus = _ryhmä;
              opiskelijaID = _id;
          }

        public string HaeData() //Opiskelijan tietojen tulostamiseen tarkoitettu Metodi
        {
            return etunimi + " " + sukunimi + "." + " Ryhmätunnus " + ryhmäTunnus + ". ID: " + opiskelijaID; //Palauttaa nämä tiedot, tämän voisi kyllä toteuttaa myös Console.Write komennolla myös
        }

    }
}
