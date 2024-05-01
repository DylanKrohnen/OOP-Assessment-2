using OOP_Assessment_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assessment_2
{
    internal class Game
    {

        public void SevensGame()
        {
            bool gameOver = false;
            int player = 0;
            int attempts = 0;
            List<int> sevensOutScore = new List<int>(); // Creates a list to store the games score.
            sevensOutScore.Add(0); // Computer Score
            sevensOutScore.Add(0); // Player 1 Score
            sevensOutScore.Add(0); // Player 2 Score

            SevensOut so = new SevensOut();

            string playOption = null;
            while (playOption == null) // Will continue to show the menu options until a valid option is picked.
            {
                Console.WriteLine("Type the number for how you want to play.\n1. Play with partner.\n2. Play with computer.");
                playOption = Console.ReadLine();

                // 1 V 1 Play
                if (playOption == "1")
                {
                    // Player 1 Turn
                    player = 1;
                    Console.WriteLine($"Player {player} turn. Press any key to begin.\n");
                    Console.ReadKey();
                    while (gameOver == false) // Will reroll the die and add to the score until a 7 is reached.
                    {
                        gameOver = so.Round(player, sevensOutScore);
                        attempts++; // Keeps track of how many rolls the player has had.
                    }
                    Console.WriteLine($"Player {player} rolled the die {attempts} times and got a score of {sevensOutScore[player]}.\n");

                    // Player 2 Turn
                    player = 2;
                    gameOver = false;
                    Console.WriteLine($"Player {player} turn. Press any key to begin.\n");
                    Console.ReadKey();
                    while (gameOver == false) // Will reroll the die and add to the score until a 7 is reached.
                    {
                        gameOver = so.Round(player, sevensOutScore);
                        attempts++; // Keeps track of how many rolls the player has had.
                    }
                    Console.WriteLine($"Player {player} rolled the die {attempts} times and got a score of {sevensOutScore[player]}.\n");

                    if (sevensOutScore[1] < sevensOutScore[2]) // If player 2 has won then this message will display.
                    {
                        Console.WriteLine($"Player 2 has won this game with {sevensOutScore[2]} points.\n");
                    }
                    else if (sevensOutScore[1] > sevensOutScore[2]) // If player 1 has won then this message will display.
                    {
                        Console.WriteLine($"Player 1 has won this game with {sevensOutScore[1]} points.\n");
                    }
                    else // If both players end with the same score this message will display.
                    {
                        Console.WriteLine("This game has ended in a tie.\n");
                    }
                }

                // 1 V CPU Play
                else if (playOption == "2")
                {
                    // Player 1 Turn
                    player = 1;
                    Console.WriteLine($"Player {player} turn. Press any key to begin.\n");
                    Console.ReadKey();
                    while (gameOver == false) // Will reroll the die and add to the score until a 7 is reached.
                    {
                        gameOver = so.Round(player, sevensOutScore);
                        attempts++; // Keeps track of how many rolls the player has had.
                    }
                    Console.WriteLine($"Player {player} rolled the die {attempts} times and got a score of {sevensOutScore[player]}.\n");

                    // Computers Turn
                    player = 0;
                    gameOver = false;
                    Console.WriteLine($"Computers turn.\n");
                    while (gameOver == false) // Will reroll the die and add to the score until a 7 is reached.
                    {
                        gameOver = so.Round(player, sevensOutScore);
                        attempts++; // Keeps track of how many rolls the player has had.
                    }
                    Console.WriteLine($"Computer rolled the die {attempts} times and got a score of {sevensOutScore[player]}.\n");

                    if (sevensOutScore[1] < sevensOutScore[0]) // If player 2 has won then this message will display.
                    {
                        Console.WriteLine($"Computer has won this game with {sevensOutScore[0]} points.\n");
                    }
                    else if (sevensOutScore[1] > sevensOutScore[0]) // If player 1 has won then this message will display.
                    {
                        Console.WriteLine($"Player 1 has won this game with {sevensOutScore[1]} points.\n");
                    }
                    else // If both players end with the same score this message will display.
                    {
                        Console.WriteLine("This game has ended in a tie.\n");
                    }
                }


                else
                {
                    Console.WriteLine("Option does not exist."); // If the user enters an option that does not exist this error message will show and the user can try again.
                    playOption = null;
                }
            }
        }

        public void ThreeOrMoreGame()
        {
            List<int> threeOrMoreScore = new List<int>(); // Creates a list to store the games score.
            threeOrMoreScore.Add(0); // Computer Score
            threeOrMoreScore.Add(0); // Player 1 Score
            threeOrMoreScore.Add(0); // Player 2 Score

            int player = 0;
            bool gameOver = false;

            ThreeOrMore tm = new ThreeOrMore();


            string playOption = null;
            while (playOption == null) // Will continue to show the menu options until a valid option is picked.
            {
                Console.WriteLine("Type the number for how you want to play.\n1. Play with partner.\n2. Play with computer.");
                playOption = Console.ReadLine();
 
                // 1 V 1 Play
                if (playOption == "1")
                {
                    while (gameOver == false) 
                    {
                        // Player 1 Turn
                        if (threeOrMoreScore[2] >= 20) // If player 2 score is 20 or more the game will end and player 2 will win.
                        {
                            gameOver = true;
                            Console.WriteLine($"Player {player} has won the game with {threeOrMoreScore[player]} points.\n");
                            return;
                        }
                        else // If there is no winner then the die will be rolled again. Each player takes it in turns to roll the die.
                        {

                            player = 1;
                            Console.WriteLine($"Player {player} turn. Press any key to roll dice.\n");
                            Console.ReadKey();
                            tm.Round(player, threeOrMoreScore);
                            Console.WriteLine($"Your current score is: {threeOrMoreScore[player]}.\n");
                        }

                        // Player 2 Turn
                        if (threeOrMoreScore[1] >= 20) // If player 1 score is 20 or more the game will end and player 1 will win.
                        {
                            gameOver = true;
                            Console.WriteLine($"Player {player} has won the game with {threeOrMoreScore[player]} points.\n");
                            return;
                        }
                        else // If there is no winner then the die will be rolled again. Each player takes it in turns to roll the die.
                        {
                            player = 2;
                            Console.WriteLine($"Player {player} turn. Press any key to roll dice.\n");
                            Console.ReadKey();
                            tm.Round(player, threeOrMoreScore);
                            Console.WriteLine($"Your current score is: {threeOrMoreScore[player]}.\n");
                        }
                    }
                }

                // 1 V CPU Play
                else if (playOption == "2")
                {
                    while (gameOver == false)
                    {
                        if (threeOrMoreScore[2] >= 20) // If computers score is 20 or more the game will end and computer will win.
                        {
                            gameOver = true;
                            Console.WriteLine($"Computer has won the game with {threeOrMoreScore[player]} points.\n");
                            return;
                        }
                        else // If there is no winner then the die will be rolled again. Each player takes it in turns to roll the die.
                        {

                            player = 1;
                            Console.WriteLine($"Player {player} turn. Press any key to roll dice.\n");
                            Console.ReadKey();
                            tm.Round(player, threeOrMoreScore);
                            Console.WriteLine($"Your current score is: {threeOrMoreScore[player]}.\n");
                        }


                        if (threeOrMoreScore[1] >= 20) // If player 1 score is 20 or more the game will end and player 1 will win.
                        {
                            gameOver = true;
                            Console.WriteLine($"Player {player} has won the game with {threeOrMoreScore[player]} points.\n");
                            return;
                        }
                        else // If there is no winner then the die will be rolled again. Each player takes it in turns to roll the die.
                        {
                            player = 0;
                            Console.WriteLine($"Computers turn. Rolling dice.\n");
                            tm.Round(player, threeOrMoreScore);
                            Console.WriteLine($"Your current score is: {threeOrMoreScore[player]}.\n");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Option does not exist."); // If the user enters an option that does not exist this error message will show and the user can try again.
                    playOption = null;
                }
            }
        } 
    }
}


