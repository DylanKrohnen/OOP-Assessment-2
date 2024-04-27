using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assessment_2
{
    internal class Game
    {


        public static void SevensOut()
        {
            bool gameOver = false;
            List<int> sevensOutScore = new List<int>();
            sevensOutScore.Add(0);
            sevensOutScore.Add(0);
            sevensOutScore.Add(0);

            while (gameOver == false)
            {
                gameOver = new SevensOut(1, sevensOutScore);
                    
                    

            }

        }
        

    }
}

// Player 1 goes first until they hit 7
// Player 2 goes second until they hit 7
// Player with the most points wins
// Add high score to player stats
// Add win to player stats
// Add number of games played to both.