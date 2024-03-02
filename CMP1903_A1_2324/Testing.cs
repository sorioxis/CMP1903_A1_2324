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
                Debug.Assert(game.RollSum() == (game._die1.CrntRoll + game._die2.CrntRoll + game._die3.CrntRoll), "Sum of rolls does not match actual value"); 
                int[] allrolls = { game._die1.CrntRoll, game._die2.CrntRoll, game._die3.CrntRoll }; //We iterate over a list that containts all of our rolls - its easier than going through each one by one.               
                foreach (int Val in allrolls) // for each recorded value in the list, test the below
                {
                    Debug.Assert(Val > 6 == false, "Roll was higher than 6."); 
                    Debug.Assert(Val < 1 == false, "Roll was lower than 1.");                    
                }              
            }
            Console.WriteLine("Debugging / Testing complete");
        }
    }
}
