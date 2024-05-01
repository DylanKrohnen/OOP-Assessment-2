using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assessment_2
{
    internal class ThreeOrMore
    {
        // Properties
        public List<int> dieRolls { get; private set; }
        Die rl = new Die(); // Starts a new die class.

        //Method
        public void Round(int player, List<int> ThreeOrMoreScore)
        {
            List<int> dieRolls = new List<int>(); // Creates a list with 5 random numbers from the Die class.
            dieRolls.Add(rl.Roll());
            dieRolls.Add(rl.Roll());
            dieRolls.Add(rl.Roll());
            dieRolls.Add(rl.Roll());
            dieRolls.Add(rl.Roll());

            int num = 1;

            Console.WriteLine($"You have rolled the following: {dieRolls[0]}, {dieRolls[1]}, {dieRolls[2]}, {dieRolls[3]}, {dieRolls[4]}.");

            while (num < 7) // Loops for all the dice numbers (1-6).
            {
                var match = from die in dieRolls where die == num select die; // Checks for 3, 4 and 5 of a kind using LINQ.
                int numOfMatches = match.Count();

                if (numOfMatches == 5) // If all 5 die are the same then 12 points are given to the player.
                {
                    Console.WriteLine("You have rolled a full house.");
                    ThreeOrMoreScore[player] = ThreeOrMoreScore[player] + 12;
                    return;
                }

                else if (numOfMatches == 4) // If 4 die are the same then 6 points are given to the player.
                {
                    Console.WriteLine("You have rolled a 4 of a kind.");
                    ThreeOrMoreScore[player] = ThreeOrMoreScore[player] + 6;
                    return;
                }

                else if (numOfMatches == 3) // If 3 die are the same then 3 points are given to the player.
                {
                    Console.WriteLine("You have rolled a 3 of a kind.");
                    ThreeOrMoreScore[player] = ThreeOrMoreScore[player] + 3;
                    return;
                }
                num++; // Adds 1 to the current die to check.
            }

        }

    }
}
