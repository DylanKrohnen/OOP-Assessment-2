using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assessment_2
{
    internal class SevensOut
    {
        public List<int> dieRolls { get; private set; }


        Die rl = new Die(); // Starts a new die class.



        public bool Round(int player, List<int> sevensOutScore)
        {
            
            
            List<int> dieRolls = new List<int>();
            dieRolls.Add(rl.Roll());
            dieRolls.Add(rl.Roll());

            int dieTotal = dieRolls[0] + dieRolls[1];

            Console.WriteLine($"Roll 1 = {dieRolls[0]}");
            Console.WriteLine($"Roll 2 = {dieRolls[1]}");
            Console.WriteLine($"Total = {dieTotal}");

            if (dieTotal == 7)
            {
                Console.WriteLine("Game Over");
                return true;
            }

            else if (dieRolls[0] == dieRolls[1])
            {
                sevensOutScore[player] = sevensOutScore[player] + (dieTotal * 2);
                Console.WriteLine($"Current Score = {sevensOutScore[player]}");
                return false;
            }

            else
            {
                sevensOutScore[player] = sevensOutScore[player] + dieTotal;
                Console.WriteLine($"Current Score = {sevensOutScore[player]}");
                return false;
            }
        }
    }
}
