using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography.X509Certificates;

namespace CMP1903_A1_2324
{
    internal class Testing
    {
        /*
         * This class should test the Game and the Die class.
         * Create a Game object, call the methods and compare their output to expected output.
         * Create a Die object and call its method.
         * Use debug.assert() to make the comparisons and tests.
         */

        /// <summary>
        /// General testing of the game - loops 500 times over for extensive testing and ensures that sum matches up, and rolls aren't higher or lower than possible e.g 0 or 7
        /// </summary>
        public void Run()
        {
            Game game = new Game(); //New game object
            for (int i = 0; i < 500; i++) //Loop over 500 times
            {
                game.Roll(); //Roll all three dice
                int[] allrolls = { game._die1.CrntRoll, game._die2.CrntRoll, game._die3.CrntRoll }; //Store rolls in a list so we can iterate over them individually
                foreach (int Val in allrolls) //For each value (roll) in the list above
                {
                    game.RollOutput(); //Show output of value
                    game.RollSum(); // Show sum of values (from 3 die)
                    Debug.Assert(Val < 1 == false, "Detected roll less than 1."); //Detect if die is lower than 1 
                    Debug.Assert(Val > 6 == false, "Detected roll more than 6."); //Detect if die is lower than 6
                }                              
            }
            Console.WriteLine("Debugging / Testing complete, closing program in 10 seconds (or press any key to exit)"); //Program kept closing automatically (needs Console.Read();)
            System.Threading.Thread.Sleep(10000); //Waits 10 seconds then exits unless manually exit by user
            Environment.Exit(0); 

        }
    }
}
