/*
 * Noah Tomkins
 * September 21, 2020
 * 
 * Employee Infromation Program
 * Lists all the employees and their: Name, Number, Pay Rate, Hours, Gross Pay
 * 
 * Class: EmployeeView, gives output and input to the user
 * 
 * I, Noah Tomkins, 000790079 certify that this material is my original work.  
 * No other person's work has been used without due acknowledgement.
 */

using System;
using System.Collections.Generic;

namespace Lab4A
{
    class EmployeeView
    {
        public List<Employee> Employees { get; set; }
        private Employee.EmployeeComparer employeeComparer = Employee.GetComparer();

        /// <summary>
        /// EmployeeView Main Constructor
        /// </summary>
        /// <param name="employees">Array of employees</param>
        public EmployeeView(List<Employee> employees)
        {
            Employees = employees;
        }

        /// <summary>
        /// Processes the users input and outputs the data to the console
        /// </summary>
        /// <returns>true if ran properly</returns>
        public bool ProcessUserSelection()
        {
            Console.Title = "Employee Program";
            Console.WriteLine("EMPLOYEE PROGRAM");
            Console.WriteLine("Created by, Noah Tomkins - 000790079");
            Console.WriteLine("\nSelect Employees and manage employees pay and hours\n\n");

            DisplayMenu();

            while (true)
            {

                string input = Console.ReadLine();
                Console.Clear();
                if ((int.TryParse(input, out int userSelection) == false) || userSelection < 1 || userSelection > 6)
                {
                    Console.WriteLine("\nInput invalid. Please enter a value between 1 and 6.");
                    continue;
                }

                if (userSelection == 1)
                    employeeComparer.WhichComparison = Employee.EmployeeComparer.ComparisonType.Name;
                else if (userSelection == 2)
                    employeeComparer.WhichComparison = Employee.EmployeeComparer.ComparisonType.Number;
                else if (userSelection == 3)
                    employeeComparer.WhichComparison = Employee.EmployeeComparer.ComparisonType.Rate;
                else if (userSelection == 4)
                    employeeComparer.WhichComparison = Employee.EmployeeComparer.ComparisonType.Hours;
                else if (userSelection == 5)
                    employeeComparer.WhichComparison = Employee.EmployeeComparer.ComparisonType.Gross;
                else //userSelection must be 6, so exit
                    break;

                DisplayHeader();

                Employees.Sort(employeeComparer);
                foreach (Employee employee in Employees)
                    Console.WriteLine(employee);

                Console.WriteLine("\n\n");
                DisplayMenu();
            }


            return true;
        }

        /// <summary>
        /// Displays the menu to the user through the console
        /// </summary>
        public void DisplayMenu()
        {
            Console.WriteLine("1. Sort by Employee Name");
            Console.WriteLine("2. Sort by Employee Number");
            Console.WriteLine("3. Sort by Employee Pay Rate");
            Console.WriteLine("4. Sort by Employee Hours");
            Console.WriteLine("5. Sort by Employee Gross Pay");
            Console.WriteLine("\n6. Exit");
            Console.WriteLine("\nEnter choice:");
        }

        /// <summary>
        /// Displays the header for the ordered tables in console
        /// </summary>
        public void DisplayHeader()
        {
            Console.WriteLine($"{"Employee",-20}   {"Number",6}   {"Rate",6}   {"Hours",5}   {"Gross Pay",9}\t\tNoah's Company");
            Console.WriteLine("=====================  ======   ======   =====   =========\t\t--------------");
        }
    }
}
