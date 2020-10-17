/*
 * Noah Tomkins
 * October 11, 2020
 * 
 * Class: Util, Utility class for functions that get used a lot
 * 
 * I, Noah Tomkins, 000790079 certify that this material is my original work.  
 * No other person's work has been used without due acknowledgement.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2A
{
    class Util
    {
        /// <summary>
        /// Validates the input of a dimention from the console
        /// </summary>
        /// <param name="dimention">name of the dimention</param>
        /// <returns>double of dimention</returns>
        public static double ValidateGetDouble(string dimention)
        {
            bool good = false;
            double userSelection;
            do
            {
                Console.Write($"Enter the {dimention}: ");
                string input = Console.ReadLine();
                if ((double.TryParse(input, out userSelection) == false) || userSelection < 0)
                {
                    Console.WriteLine("Input invalid. Please enter a double greater than 0");
                }
                else
                    good = true;
            } while (!good);
            return userSelection;
        }
    }
}
