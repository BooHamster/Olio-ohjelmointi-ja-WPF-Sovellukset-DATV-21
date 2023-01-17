using System;
//Robert Kajanti
namespace StaticTest
{
    class Program
    {
        static void Main(string[] args)
        {
            float kilometri = 60f;
            float mailit = StaattinenLuokka.KmToMiles(kilometri);

            Console.WriteLine("{0}km/h on yhtä kuin {1} mailia", kilometri, mailit);
        }
    }
}
