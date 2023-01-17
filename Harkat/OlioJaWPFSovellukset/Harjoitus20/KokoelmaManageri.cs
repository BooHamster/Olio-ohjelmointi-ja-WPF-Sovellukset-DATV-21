using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Harjoitus20
{
    static class KokoelmaManageri //Staattinen luokka, jonka pohjalta ei siis luoda olioita, vaan käytetään pelkästään sen metodeita
    {
        //Muuttujat

        private static string path = "OpiskelijaKokoelma.bin";

        public static Dictionary<string, Opiskelija> Opiskelijat = new Dictionary<string, Opiskelija>();

        public static void LisääOpiskelija(string etunimi, string sukunimi, string opiskelijaID) //Metodi opiskelijan lisäämiseen string Opiskelija tyyppiseen Opiskelijat nimiseen listaan
        {
            Opiskelijat.Add(opiskelijaID, new Opiskelija(etunimi, sukunimi, opiskelijaID));
        }

        public static bool TarkistaID(string id) //Metodi OpiskelijaID muuttujan tarkistamiseen, jotta kahta samaa OpiskelijaID:tä ei voi käyttää
        {
            if (Opiskelijat.ContainsKey(id))
            {
                throw new OpiskelijaPoikkeus("OpiskelijaID " + id + " ei ole uniikki, anna uusi ID");
            }
            else
            {
                return true;
            }
        }


        public static void PoistaOpiskelija(Opiskelija opiskelija) //Metodi opiskelijan poistamiseen listalta Opiskelija ID muuttujan avulla
        {
            Opiskelijat.Remove(opiskelija.OpiskelijaID);
        }

        public static List<Opiskelija> PalautaOpiskelijat() //Metodi joka tekee listan opiskelijatListassa, ja sitten lisää tähän uuteen listaan arvot Opiskelijat kokoelmasta, ja sitten palauttaa tämän uuden listan arvot kun metodia käytetään 
        {
            List<Opiskelija> opiskelijatListassa = new List<Opiskelija>();

            opiskelijatListassa.AddRange(Opiskelijat.Values);

            return opiskelijatListassa;
        }

        public static string LoadFromFile() // Metodi joka lataa tallennetut opiskelijatiedot tiedostosta
        {
            Stream fileStream = null;
            string result = "";

            try
            {
                fileStream = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.None);
                IFormatter formatter = new BinaryFormatter();


                List<Opiskelija> opiskelijatList = (List<Opiskelija>)formatter.Deserialize(fileStream);

                foreach (Opiskelija op in opiskelijatList)
                {
                    Opiskelijat.Add(op.OpiskelijaID, op);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                result = ex.Message;
            }

            return result;
        }

        public static string SaveToFile() //Metodi joka tallentaa opiskelija tiedot,luomalla opiskelijatList Listan ja siirtämällä Opiskelijat kokoelman sisällön tähän listaan
        {
            Stream fileStream = null;
            string result = "";

            try
            {
                fileStream = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.None);
                IFormatter formatter = new BinaryFormatter();

                List<Opiskelija> opiskelijatList = new List<Opiskelija>();

                foreach (Opiskelija op in Opiskelijat.Values)
                {
                    opiskelijatList.Add(op);
                }

                formatter.Serialize(fileStream, opiskelijatList);
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
