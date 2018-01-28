using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Westman_Christopher_FinalProject
{
    class GasBot
    {
        // Create method to gather the amount of miles driven per trip and store and return an array
        public static double[] TripMiles(double _trips)
        {
            // Type cast parameter in order to declare array size
            int tripIndex = (int)_trips;

            // Declare array that scales with user input
            double[] tripMiles = new double[tripIndex];

            // Use a for loop to prompt the user the same amount of times as trips taken
            for (int i = 0; i < tripMiles.Length; i++)
            {
                // Prompt user for miles driven for i trip
                Console.WriteLine("\r\nGas Bot wants to know:\r\nHow many miles did you drive for trip #{0}? ", i + 1);

                // Validate and store miles by calling the Validate method
                double miles = Validate.Input(Console.ReadLine());
                // Take miles and assign it to the i index of tripMiles array
                tripMiles[i] = miles;

            }
            // return array to Main method
            return tripMiles;
        }

        // Create method to take the array created by GetMiles and calculate the sum of all miles, then return sum
        public static double TotalMiles(double[] _tripMiles)
        {
            // Declare a sum variable that will store the total amount of miles driven
            double sumOfMiles = 0;
            // Use for loop to cycle through the parameter array, adding miles together
            for (int i = 0; i < _tripMiles.Length; i++)
            {
                // Add miles together
                sumOfMiles += _tripMiles[i];
            }
            // Return mile total to Main method
            return sumOfMiles;

        }

        // Create CostOfGas method that takes in prior user input as argumants
        public static decimal CostOfGas(double _totalMiles, double _mpg, decimal _costPerGal)
        {
            // Calculate total cost of gas for sum of trips, then store in variable
            decimal _costOfGas = ((decimal)_totalMiles / (decimal)_mpg) * _costPerGal;
            // Retun cost to Main method
            return _costOfGas;
        }

        public static void Start()
        {
            // Prompt user for first inputs
            Console.Write("\r\nGas Bot wants to know: \r\n" +
                "How many trips do you wish to take? ");

            // Call Validate method and store in variable for later use
            double trips = Validate.Input(Console.ReadLine());

            // Declare variable that call the TotalMiles method, taking the GetMilesMethod, that takes trips as a parameter
            double milesInTotal = GasBot.TotalMiles(GasBot.TripMiles(trips));

            // Prompt user for gathering mpg value
            Console.WriteLine("\r\nGas Bot wants to know:\r\nHow many miles per gallon of gas does your vehicle get? ");

            // Validate and store input by calling the Validate method
            double milesPerGal = Validate.Input(Console.ReadLine());

            //Prompt user for cost of 1 gal of gas
            Console.Write("\r\nGas Bot wants to know:\r\nHow much is gas right now? Use 00.00 format please. ");

            // Validate and store input by calling the Validate method
            decimal pricePerGal = (decimal)Validate.Input(Console.ReadLine());

            // Store the total cost of gas from all trips by calling the CostOfGas method, taking in all prior input as argumants
            decimal totalCost = GasBot.CostOfGas(milesInTotal, milesPerGal, pricePerGal);

            // Inform user of total cost of gas
            Console.WriteLine("\r\nThe cost of driving {0} miles is {1:C}.", milesInTotal, totalCost);

            Console.WriteLine("\r\nThank you for using Gas Bot!");
        }
    }
}
