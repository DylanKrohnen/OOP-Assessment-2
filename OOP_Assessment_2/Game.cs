using OOP_Assessment_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assessment_2
{
    internal class Game:Statistics
    {

        public void SevensGame()
        {
            bool gameOver = false;
            int player = 0;
            List<int> sevensOutScore = new List<int>();
            sevensOutScore.Add(0);
            sevensOutScore.Add(0);
            sevensOutScore.Add(0);

            SevensOut so = new SevensOut();

            player = 1;
            gameOver = false;
            Console.WriteLine($"Player {player} turn. Press any key to begin.");
            Console.ReadKey();
            while (gameOver == false)
            {
                gameOver = so.Round(player, sevensOutScore);
            }
            Console.WriteLine($"Your total score is {sevensOutScore[player]}.");

            player = 2;
            gameOver = false;
            Console.WriteLine($"Player {player} turn. Press any key to begin.");
            Console.ReadKey();
            while (gameOver == false)
            {
                gameOver = so.Round(player, sevensOutScore);
            }
            Console.WriteLine($"Your total score is {sevensOutScore[player]}.");

            if (sevensOutScore[1] < sevensOutScore[2])
            {
                Console.WriteLine($"Player 2 has won with {sevensOutScore[2]} points.");
            }
            else if (sevensOutScore[1] > sevensOutScore[2])
            {
                Console.WriteLine($"Player 1 has won with {sevensOutScore[1]} points.");
            }
            else
            {
                Console.WriteLine("Game ended in a tie.");
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


