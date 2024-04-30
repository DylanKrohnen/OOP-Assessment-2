using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assessment_2
{
    internal class Testing
    {
        public Testing()
        {
            gameObjectCreateTest();
            Console.WriteLine("Testing Complete\n");
        }

        private static void gameObjectCreateTest() // Checks that the game object can be created, if not it will return an error message.
        {
            Game rn = new Game();
            Debug.Assert(rn != null, "Game object has failed to be created.");
            Debug.WriteLine("Game object created successfully.");
        }

        

    }
}
