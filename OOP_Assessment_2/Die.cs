using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assessment_2
{
    internal class Die
    {
        // Properties

        private Random random = new Random();
        public int value;

        // Method
        public int Roll()
        {
            value = random.Next(1, 7); // Creates a random integer between 1 and 6.
            return value;
        }

    }
}
