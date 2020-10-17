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
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1___Noah_Tomkins___000790079
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
            Employee[] employees = LoadEmployees();

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
        private static Employee[] LoadEmployees()
        {
            Employee[] tempEmployees = new Employee[100];
            int count = 0;
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

                while (!sr.EndOfStream && lineNumber < tempEmployees.Length)
                {
                    // Read next line
                    string input = sr.ReadLine();

                    //Check if line is empty
                    if (input == "")
                    {
                        Console.WriteLine("In file: 'employees.txt', Empty line at ln" + lineNumber);
                        lineNumber++;
                        continue;
                    }
                        

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

                    if (double.TryParse(values[2], out double rate) == false)
                    {
                        Console.WriteLine("Failed to get employee rate for employee:" + name);
                        rate = 0;
                    }

                    if (double.TryParse(values[3], out double hours) == false)
                    {
                        Console.WriteLine("Failed to get employee hours for employee:" + name);
                        hours = 0;
                    }

                    tempEmployees[count] = new Employee(name, number, (decimal)rate, hours);
                    count++;
                    lineNumber++;
                }

                fs.Close();
                sr.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Exeption loading Employees from file due to: {e.Message}");
            }

            // Create new array that is limited by the ammount of employees
            // that were in the employees.txt file
            Employee[] myEmployees = new Employee[count];

            for (int i = 0; i < myEmployees.Length; i++)
                myEmployees[i] = tempEmployees[i];

            return myEmployees;
        }
    }
}
