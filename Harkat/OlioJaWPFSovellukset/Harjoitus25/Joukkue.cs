using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus25
{

    class Joukkue
    {
        //Muuttujat
        private string Nimi;
        private string Kotikaupunki;
        public Dictionary<int, Pelaaja> Pelaajat = new Dictionary<int, Pelaaja>();
        public string path = "PelaajaKokoelma.bin";

        //Konstruktori
        public Joukkue(string _nimi, string _kotikaupunki) 
        {
            Nimi = _nimi;
            Kotikaupunki = _kotikaupunki;
        }


        public void Lisää(string Etunimi, string Sukunimi, int PelaajaNumero) //Pelaajan lisäämisen metodi
        {
            Pelaajat.Add(PelaajaNumero, new Pelaaja(Etunimi, Sukunimi, PelaajaNumero));
        }

        public bool TarkistaPelaajaNumero(int id) //Pelaajanumeron tarkistamisen metodi
        {
            if (Pelaajat.ContainsKey(id))
            {
                throw new PelaajaPoikkeus("PelaajaNumero " + id + " ei ole uniikki, anna uusi ID");
            }
            else
            {
                return true;
            }
        }

        public void PoistaPelaaja(Pelaaja pelaaja) //Pelaajan poistamisen metodi Pelaajat kokoelmasta Pelaajanumeron perusteella
        {
            Pelaajat.Remove(pelaaja.PelaajaNumero);
        }

        public List<Pelaaja> NäytäPelaajat() //Metodi pelaaja tietojen näyttämiseen Pelaajat kokoelmasta
        {
            List<Pelaaja> pelaajatListassa = new List<Pelaaja>(); //Luodaan lista Pelaajille

            pelaajatListassa.AddRange(Pelaajat.Values); // Siirretään tiedot Pelaajat kokoelmasta pelaajatListassa listaan

            return pelaajatListassa; //Palautetaan listan tiedot kun metodia käytetään
        }

        public string LoadFromFile() //Metodi pelaajatietojen lataukseen tiedostosta
        {
            Stream fileStream = null; //Luodaan uusi FileStream muuttuja jonka avulla voidaan ladata tietoja tiedostosta
            string result = "";

            try
            {
                fileStream = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.None); //Annetaan fileStream muuttujalle oikeudet avata ja lukea tiedostosta
                IFormatter formatter = new BinaryFormatter();


                List<Pelaaja> PelaajatListassa = (List<Pelaaja>)formatter.Deserialize(fileStream); //Otetaan fireStream muuttujan avulla tiedostosta pelaajatiedot listaan

                foreach (Pelaaja pelaaja in PelaajatListassa) //Lisätään kokoelmaan jokainen pelaaja PelaajatListasta
                {
                    Pelaajat.Add(pelaaja.PelaajaNumero, pelaaja);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                result = ex.Message;
            }

            return result;
        }

        public string SaveToFile() //Pelaajatietojen tallennuksen metodi
        {
            Stream fileStream = null;
            string result = "";

            try
            {
                fileStream = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.None);
                IFormatter formatter = new BinaryFormatter();

                List<Pelaaja> PelaajatListassa = new List<Pelaaja>();

                foreach (Pelaaja pelaaja in Pelaajat.Values)
                {
                    PelaajatListassa.Add(pelaaja);
                }

                formatter.Serialize(fileStream, PelaajatListassa);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                result = ex.Message;
            }
            finally
            {
                if (fileStream != null)
                {
                    fileStream.Close();
                }
            }

            return result;
        }
    }
}


