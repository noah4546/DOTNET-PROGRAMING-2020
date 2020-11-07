/*
 * Noah Tomkins
 * September 21, 2020
 * 
 * I, Noah Tomkins, 000790079 certify that this material is my original work.  
 * No other person's work has been used without due acknowledgement.
 */

using System;
using System.Collections.Generic;

namespace MidtermA
{
    /// <summary>
    /// Calculates the total price of all the Prodcuts and Services
    /// Displays each item and all their contents
    /// Displays grand total of all valid Products and Services
    /// </summary>
    class Invoice
    {
        /// <summary>
        /// Main method of program, gets called first at startup
        /// </summary>
        /// <param name="args">Unused</param>
        static void Main(string[] args)
        {

            List<IBillable> billables = new List<IBillable>();

            billables.Add(new Product(108715, "30inch Monitor", 1, 445.99M));
            billables.Add(new Product(119912, "Speakers", 2, 135.35M));
            billables.Add(new Service("Configure", "Operating System", 135.25M));
            billables.Add(new Service("Debug", "Firefox", 25.89M));
            billables.Add(new Product(191162, "FireTV Stick", 1, 65.39M));
            billables.Add(new Service("Backup", "SSD Drive", 125.19M));

            // Procces the billables List
            decimal grandTotal = 0;
            foreach (IBillable item in billables)
                if (item.Validate())
                    grandTotal += item.Bill();

            // Display the header
            Console.Title = "Mohawk Microcomputers";
            Console.WriteLine("This Month’s Accounts Payable");
            Console.WriteLine("=============================\n");

            // Display each item and if it is valid, error message shown when not valid
            foreach (IBillable item in billables)
            {
                Console.WriteLine(item);
                Console.Write($"Total cost: {item.Bill():C}");
                if (item.Validate())
                    Console.WriteLine(", ID is valid");
                else
                {
                    Console.WriteLine(", ID is invalid");
                    if (item is Product)
                        Console.WriteLine("Error: ID must be a 6-digit and start with 10, 11, 12, or 13");
                    if (item is Service)
                        Console.WriteLine("Error: ID must be “configure”, “debug”, or “restore”");
                }
                
                Console.WriteLine("");  
            }

            Console.WriteLine("============================");
            Console.WriteLine($"Grand Total: {grandTotal:C}");

            Console.WriteLine("\n\nPress any key to exit . . .");
            Console.ReadKey();
        }

    }
}
