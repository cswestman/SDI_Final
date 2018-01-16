using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Westman_Christopher_FinalProject
{
    class Validate
    {
        // Craete method for validating user input
        public static double Input(string input)
        {
            // Declare generic variable since this method will be used for multiple questions
            double output = 0;
            // Create while loop that allows for 2 validation loops to run
            while (true)
            {
                // Validate for number < 0
                while (double.TryParse(input, out output) && output < 0)
                {
                    Console.WriteLine("\r\nYou can not type in a value of less than 0. Please try again.");
                    input = Console.ReadLine();

                }

                // Validate for letters and blank
                while (string.IsNullOrWhiteSpace(input) || !double.TryParse(input, out output))
                {
                    // If incorrect user input is entered, correct user
                    Console.WriteLine("Pleae type in a valid entry.");
                    // Store input once again from user
                    input = Console.ReadLine();
                    continue;
                }
                // Break out of while loop if user input is valid
                if (output >= 0)
                {
                    break;
                }

            }

            // Return output to user to be stored for later purposes
            return output;
        }
    }
}
