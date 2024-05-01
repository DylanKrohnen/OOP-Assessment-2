using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assessment_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string gameOption = null;
            Game rn = new Game();
            while (gameOption == null) // Will continue to show the menu options until a valid option is picked.
            {
                Console.WriteLine("Type the number for what you would like to do.\n1. Start sevens out game.\n2. Start three or more game.\n3. View game statistics.\n4. Perform tests.\n5. Exit program.");
                gameOption = Console.ReadLine();

                if (gameOption == "1")
                {
                    //Senvens Out
                    rn.SevensGame(); // Starts a new sevens out game.

                    gameOption = null; // Allows the user to pick another menu option.
                }
                else if (gameOption == "2")
                {
                    //Three or more
                    rn.ThreeOrMoreGame();

                    gameOption = null;
                }
                else if (gameOption == "3")
                {
                    //Game stats
                    
                   
                    gameOption = null; // Allows the user to pick another menu option.
                }
                else if (gameOption == "4")
                {
                    //Testing
                    Testing te = new Testing(); // Starts testing.

                    gameOption = null; // Allows the user to pick another menu option.
                }
                else if (gameOption == "5")
                {
                    System.Environment.Exit(1); // Terminates the program.
                }
                else
                {
                    Console.WriteLine("Option does not exist."); // If the user enters an option that does not exist this error message will show and the user can try again.
                    gameOption = null;
                }
            }
        }
    }
}
