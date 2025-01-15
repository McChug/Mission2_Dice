using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission2_Dice
{
    internal class RollDice
    {
        public int[] Roll(int number_of_rolls)
        {
            // Initialize random
            Random rnd = new Random();

            // Init variables
            int roll_1_result = 0;
            int roll_2_result = 0;
            int roll_total = 0;
            int[] results = new int[11];

            // Loop to simulate number_of_rolls
            for (int i = 0; i < number_of_rolls; i++)
            {
                // Get two random dice rolls and add them together
                roll_1_result = rnd.Next(1, 7);
                roll_2_result = rnd.Next(1, 7);
                roll_total = roll_1_result + roll_2_result;

                // Store in array
                results[roll_total - 2] += 1;
            }

            return results;
        }
    }
}
