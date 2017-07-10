using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberPyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            // variables
            int number, numRows, spaces;
            string userEntry, userInput;
            bool appRunning = true;

            while (appRunning)
            {
                //Prompt the user for input
                Console.WriteLine("Please enter a number between 1 - 10 or type \"done\" to quit: ");

                //we need to get a user input
                userEntry = Console.ReadLine();

                // we will exit the program if the user types done
                if (userEntry.ToLower() == "done")
                {
                    break;
                }
                //input validation
                else if (int.TryParse(userEntry, out numRows) == false || numRows > 10)
                {
                    Console.WriteLine("Invalid entry! Try again.");
                    continue;
                }
                
                //clear the console
                Console.Clear();

                // a loop that will iterate the same number of times the user input
                for (int i = 0; i <= numRows; i++)
                {
                    // this will add spaces to the left of the numbers to create the pyramid effect
                    for (spaces = 0; spaces <= numRows - i; spaces++)
                    {
                        Console.Write(" ");
                    }

                    // this will count the numbers up
                    for (number = 1; number <= i; number++)
                    {
                        Console.Write(number);
                    }

                    //This will count the number back down
                    for (number = (i - 1); number > 0; number--)
                    {
                        Console.Write(number);
                    }


                    //starts a new line
                    Console.WriteLine();
                }

                // prompt the user to continue or quit
                Console.WriteLine("Press Enter to try again or type \"done\" to quit: ");
                userInput = Console.ReadLine();
                if (userInput == "done")
                {
                    appRunning = false;
                }
                
            }
        }
    }
}
