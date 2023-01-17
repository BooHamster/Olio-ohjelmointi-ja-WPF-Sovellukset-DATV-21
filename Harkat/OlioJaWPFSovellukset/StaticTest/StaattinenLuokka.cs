using System;
using System.Collections.Generic;
using System.Text;

namespace StaticTest
{
    static class StaattinenLuokka
    {
        public static float KmToMiles(float i)
        {
            float conversion = 0.62137f;
            return i * conversion;
        }
    }
}
