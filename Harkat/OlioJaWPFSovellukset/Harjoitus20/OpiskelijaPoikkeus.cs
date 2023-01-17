using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus20
{
    class OpiskelijaPoikkeus : Exception
    {
        public OpiskelijaPoikkeus(string message) : base(message)
        {
            Console.WriteLine("-----ERROR-----");
            Console.WriteLine("Error: " + message);
            Console.WriteLine("-----ERROR-----");
        }
    }
}
