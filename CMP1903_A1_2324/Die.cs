using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Die
    {
        /*
         * The Die class should contain one property to hold the current die value, -- Done
         * and one method that rolls the die, returns and integer and takes no parameters. -- Done
         */

        /// <summary>
        ///Generates a random number. We ensure all die don't roll the same number by making it static.
        ///New int for values, not accessible outside class
        /// </summary>
        private int _value;
        private static Random _rndm = new Random();

        /// <summary>
        /// We can use the below get & set to instance our class and call it in any way we want - we can set the value to anything, for debugging.
        /// </summary>
        public int CrntRoll
        {
            get { return _value; }
            set { _value = value; }
        }
     
        /// <summary>
        /// Rolls the dice - gives a random number between 1-6
        /// </summary>
        /// <returns> Random number btwn 1-6 
        /// </returns>
        /// 
        public int Roll()
        {
            // Below will generate a random number between 1 and 6.
            CrntRoll = _rndm.Next(1, 7);
            // Return randomly generated number from above
            return CrntRoll;



        }
    }
}
