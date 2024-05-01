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
        public int value { get; private set; }
        private static Random random;

        // Methods
        public Die() // Creates an initial random value for the dice between 1 and 6.
        {
            random = new Random();
            value = random.Next(1, 7);
        }
        public int Roll() // Creates a random integer between 1 and 6 and stores in "value" and returns it.
        {
            value = random.Next(1, 7);
            return value;
        }

        public int Current() // Returns the current value of the dice.
        {
            return value;
        }

    }
}
