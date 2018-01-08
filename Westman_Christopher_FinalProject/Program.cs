using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Westman_Christopher_FinalProject
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Christopher Westman
             * 12/14/2017
             * Week 4, FINAL PROJECT!!!
             */
             // Greet user and explain program
            Console.WriteLine("Welcome to the GAS BOT! This app will calculate the cost of your gas for multiple road trips!");

            // Prompt user for first input
            Console.WriteLine("\r\nGas Bot wants to know: \r\n" +
                "How many trips do you wish to take?");

            // Declare variables for validation 
            string s_trips = Console.ReadLine();

            // Call Validate method and store in variable for later use
            double trips = Validate(s_trips);

            // Declare variable that call the TotalMiles method, taking the GetMilesMethod, that takes trips as a parameter
            double milesInTotal = TotalMiles(GetMiles(trips));

            // Prompt user for gathering mpg value
            Console.WriteLine("\r\nGas Bot wants to know:\r\nHow many miles per gallon of gas does your vehicle get?");

            // Store user input for validation
            string s_milesPerGal = Console.ReadLine();
            // Validate and store input by calling the Validate method
            double milesPerGal = Validate(s_milesPerGal);

            //Prompt user for cost of 1 gal of gas
            Console.WriteLine("\r\nGas Bot wants to know:\r\nHow much is gas right now? Use 00.00 format please.");

            // Store user input for validation
            string s_pricePerGal = Console.ReadLine();

            // Validate and store input by calling the Validate method
            decimal pricePerGal = (decimal)Validate(s_pricePerGal);

            // Store the total cost of gas from all trips by calling the CostOfGas method, taking in all prior input as argumants
            decimal totalCost = CostOfGas(milesInTotal, milesPerGal, pricePerGal);

            // Inform user of total cost of gas
            Console.WriteLine("The cost of driveing {0} miles is {1:C}.", milesInTotal, totalCost);

            Console.WriteLine("\r\nThank you for using Gas Bot!");

            /* Use data for testing
             * Enter a negative number, blank, or letters on any prompt, reprompted for valid entry
             * Test #1
             * Enter 3 for trips taken
             * Enter 200 for trip #1
             * Enter 100 for trip #2 
             * Enter 30 for trip #3
             * Enter 30 for number of miles per gallon of gas
             * Enter 2.20 for price of gas
             * Output: "The cost of driving 330 miles is $24.20."
             * Test #2
             * Enter 3 for trips taken
             * Enter 10 for trip #1
             * Enter 15 for trip #2 
             * Enter 25 for trip #3
             * Enter 25 for number of miles per gallon of gas
             * Enter 1 for price of gas
             * Output: "The cost of driving 50 miles is $2.00."
             * Test #3
             * Enter 20 for trips taken
             * Enter 1 for trip #1
             * Enter 1 for each trip until finish with trip input 
             * Enter 2 for number of miles per gallon of gas
             * Enter 4.00 for price of gas
             * Output: "The cost of driving 20 miles is $40.00."
             */
        }
        //---------------------OUTSIDE OF MAIN METHOD----------/////////////////////////////////////////////////////
        //-/////////////////////////////////////////////////////////////////////////////////////////////////////////

        // Create method to gather the amount of miles driven per trip and store and return an array
        static double[] GetMiles(double _trips)
        {
            // Type cast parameter in order to declare array size
            int tripIndex = (int)_trips;

            // Declare array that scales with user input
            double[] tripMiles = new double[tripIndex];
          
            // Use a for loop to prompt the user the same amount of times as trips taken
            for (int i = 0; i < tripMiles.Length; i++)
            {
                // Prompt user for miles driven for i trip
                Console.WriteLine("\r\nGas Bot wants to know:\r\nHow many miles did you drive for trip #{0}?", i + 1);
                // Store user input for validation
                string s_miles = Console.ReadLine();
                // Validate and store miles by calling the Validate method
                double miles = Validate(s_miles);
                // Take miles and assign it to the i index of tripMiles array
                tripMiles[i] = miles;

            }
            // return array to Main method
            return tripMiles;
        }

        // Create method to take the array created by GetMiles and calculate the sum of all miles, then return sum
        static double TotalMiles(double[] _tripMiles)
        {
            // Declare a sum variable that will store the total amount of miles driven
            double sumOfMiles = 0;
            // Use for loop to cycle through the parameter array, adding miles together
            for (int i = 0; i < _tripMiles.Length; i ++)
            {
                // Add miles together
                sumOfMiles += _tripMiles[i];
            }
            // Return mile total to Main method
            return sumOfMiles;

        }

        // Create CostOfGas method that takes in prior user input as argumants
        static decimal CostOfGas(double _totalMiles, double _mpg, decimal _costPerGal)
        {
            // Calculate total cost of gas for sum of trips, then store in variable
            decimal _costOfGas = ((decimal)_totalMiles / (decimal)_mpg) * _costPerGal;
            // Retun cost to Main method
            return _costOfGas;
        }

        // Craete method for validating user input
        public static double Validate(string input)
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
