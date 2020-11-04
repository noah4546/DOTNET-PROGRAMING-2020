/*
 * Noah Tomkins
 * September 21, 2020
 * 
 * Employee Infromation Program
 * Lists all the employees and their: Name, Number, Pay Rate, Hours, Gross Pay
 * 
 * Class: Program, Main class of the program
 * 
 * I, Noah Tomkins, 000790079 certify that this material is my original work.  
 * No other person's work has been used without due acknowledgement.
 */

using System;
using System.Collections.Generic;
using System.IO;

namespace Lab4A
{
    class Program
    {
        /// <summary>
        /// Main method of the program
        /// Starts the program
        /// </summary>
        /// <param name="args">args unused</param>
        static void Main(string[] args)
        {
            List<Employee> employees = LoadEmployees();

            if(employees != null)
            {
                EmployeeView employeeView = new EmployeeView(employees);
                employeeView.ProcessUserSelection();
            }
            
        }

        /// <summary>
        /// Load Employees from file
        /// </summary>
        /// <returns>Employee array generated from file</returns>
        private static List<Employee> LoadEmployees()
        {
            List<Employee> employees = new List<Employee>();

            int lineNumber = 1;

            // Release file path
            string filePath = "employees.txt";

            try
            {
                // Debug file path
                if (File.Exists("../../employees.txt"))
                    filePath = "../../employees.txt";

                FileStream fs = new FileStream(filePath, FileMode.Open);
                StreamReader sr = new StreamReader(fs);

                while (!sr.EndOfStream)
                {
                    // Read next line
                    string input = sr.ReadLine();

                    //Check if line is empty
                    if (input != "")
                    {

                        // Parse the values
                        string[] values = input.Split(',');

                        //Check to see if there is 4 cols in line
                        if (values.Length != 4)
                        {
                            Console.WriteLine("In file: 'employees.txt', Line doesn't have 4 colums at ln" + lineNumber);
                            lineNumber++;
                            continue;
                        }

                        string name = values[0];

                        if (int.TryParse(values[1], out int number) == false)
                        {
                            Console.WriteLine("Failed to get employee number for employee:" + name);
                            number = 0;
                        }

                        if (decimal.TryParse(values[2], out decimal rate) == false)
                        {
                            Console.WriteLine("Failed to get employee rate for employee:" + name);
                            rate = 0;
                        }

                        if (double.TryParse(values[3], out double hours) == false)
                        {
                            Console.WriteLine("Failed to get employee hours for employee:" + name);
                            hours = 0;
                        }

                        employees.Add(new Employee(name, number, rate, hours));
                    }
                }

                fs.Close();
                sr.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Exeption loading Employees from file due to: {e.Message}");
            }

            return employees;
        }
    }
}
