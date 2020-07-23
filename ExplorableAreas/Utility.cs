using System;
using System.Collections.Generic;
using System.Text;

namespace ExplorableAreas
{
    class Utility
    {
        public static Random random = new Random();

        public static int GetRandomNumber(int max)
        {
            return random.Next(max);
        }
    }
}
