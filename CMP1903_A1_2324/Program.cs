using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Create a Game object and call its methods.
             * Create a Testing object to verify the output and operation of the other classes.
             */

            // Snippets / lines to help the user understand how to start the program or exit
            Console.WriteLine("Press 1 to roll.");
            Console.WriteLine("Press 2 to enter Debug / Testing Mode.");
            Console.WriteLine("Press 3 to exit.");
            
            ///<summary>
            /// Error handling; we don't want users inputting anything but 1,2 or 3. Below ensures that the user input is between 1-3 and is only a number.
            /// </summary> 
            int choice;
            while (true)
            {
                try
                {
                    choice = Convert.ToInt16(Console.ReadLine()); //Attempt to convert int input to int16 so console can read it (wont read an int)
                    if (choice > 0 && choice < 4) // If input is less than 0 or more than 3
                    {
                        break; //Break out of loop as input meets requirements
                    }
                    Console.WriteLine("Please pick a number - 1, 2 or 3."); //Try again, wont break out of loop until meets requirements
                }
                catch (Exception) // Catch any strings
                {
                    Console.WriteLine("That isn't a number. Please input a number only.");
                }     
            }
            ///<summary>
            ///Runs the actual game using methods from Game & Testing
            /// </summary>
            /// <returns> 3 die rolls, sum of all 3 die, or 500 die & their individual sums (if Testing chosen) </returns>
            switch (choice)
                {
                    case 1:
                        Game game = new Game();
                        game.Roll();
                        game.RollOutput();
                        game.RollSum();
                        game.Reset();
                        break;                      
                    case 2:
                        Testing testroll = new Testing(); //Call a new test method
                        testroll.Run();
                        break;
                    case 3:
                        Environment.Exit(0);
                        break;
                }
            }                      
        }
    }


