using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Game
    {
        /*
         * The Game class should create three die objects, roll them, sum and report the total of the three dice rolls.
         *
         * EXTRA: For extra requirements (these aren't required though), the dice rolls could be managed so that the
         * rolls could be continous, and the totals and other statistics could be summarised for example.
         */

        // Create three instances of the Die class; we make it public so that it is accessible from any other class.

        public Die _die1 = new Die();
        public Die _die2 = new Die();
        public Die _die3 = new Die();
 
        /// <summary>
        /// Rolls 3 dice utilising the built-in Roll(); method
        /// </summary>
        public void Roll()
        {
            _die1.Roll();
            _die2.Roll();
            _die3.Roll();
        }

        /// <summary>
        /// Gets the current roll from each die and sums them up.
        /// </summary>
        /// <returns> Sum of all die </returns>
        public int RollSum()
        {
            int total = _die1.CrntRoll + _die2.CrntRoll + _die3.CrntRoll;
            Console.WriteLine($"Sum: {total}");
            return total;
        }

        // Prints out the result of each roll in the console
        public void RollOutput()
        {          
          Console.WriteLine($"Die 1:  {_die1.CrntRoll}");
          Console.WriteLine($"Die 2:  {_die2.CrntRoll}");
          Console.WriteLine($"Die 3:  {_die3.CrntRoll}");           
        }
    }
}
