using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assessment_2
{
    internal class SevensOut
    {
      

        public bool Round(int player, List<int> sevensOutScore)
        {
            
            Die rl = new Die();
            List<int> dieRolls = new List<int>();
            dieRolls.Add(rl.Roll());
            dieRolls.Add(rl.Roll());

            int dieTotal = dieRolls[0] + dieRolls[1];
            if (dieTotal == 7)
            {
                return true;
            }
            else if (dieRolls[0] == dieRolls[1])
            {
                sevensOutScore[player] = sevensOutScore[player] + (dieTotal* 2);
                return false;
            }
        
            else
            {
                sevensOutScore[player] = sevensOutScore[player] + dieTotal;
                return false;
            }

        }


    }
}
