//#define TESTING
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assessment_2
{
    internal class SevensOut
    {
        // Properties
        public List<int> dieRolls { get; private set; }
        Die rl = new Die(); // Starts a new die class.


        //Method
        public bool Round(int player, List<int> sevensOutScore)
        {
            List<int> dieRolls = new List<int>(); // Creates a list with 2 random numbers from the Die class.
            dieRolls.Add(rl.Roll());
            dieRolls.Add(rl.Roll());

            int dieTotal = dieRolls[0] + dieRolls[1]; // Adds the two die together to get the total.

#if TESTING
            Console.WriteLine($"Roll 1 = {dieRolls[0]}");
            Console.WriteLine($"Roll 2 = {dieRolls[1]}");
            Console.WriteLine($"Total = {dieTotal}");
#endif
            if (dieTotal == 7) // If the die total is equal to 7 the game will end for the current player.
            {
                return true; // Returns true to the game over bool in the game class.
            }

            else if (dieRolls[0] == dieRolls[1]) // If both die are the same it will give the player double the die amount as a score.
            {
                sevensOutScore[player] = sevensOutScore[player] + (dieTotal * 2); // Adds double the die amounts to the players score.
#if TESTING
                Console.WriteLine($"Player {player} current score is {sevensOutScore[player]}.");
#endif
                return false; // Returns false to the game over bool in the game class.
            }

            else 
            {
                sevensOutScore[player] = sevensOutScore[player] + dieTotal; // Adds the die amounts to the players score.
#if TESTING
                Console.WriteLine($"Player {player} current score is {sevensOutScore[player]}.");
#endif
                return false; // Returns false to the game over bool in the game class.
            }
        }
    }
}
