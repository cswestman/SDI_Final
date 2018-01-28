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
            Console.WriteLine("Welcome to GAS BOT! This app will calculate the cost of your gas for multiple trips!");

            GasBot.Start();

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
        
    }
}
