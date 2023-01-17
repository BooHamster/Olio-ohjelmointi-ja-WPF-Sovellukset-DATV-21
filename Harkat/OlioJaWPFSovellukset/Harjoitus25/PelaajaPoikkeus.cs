using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus25
{
    class PelaajaPoikkeus : Exception
    {
        public PelaajaPoikkeus(string message) : base(message)
        {
            Console.WriteLine("-----Virhe-----");
            Console.WriteLine("Error: " + message);
            Console.WriteLine("-----ERROR-----");
        }
    }
}
