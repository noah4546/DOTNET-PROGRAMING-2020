/*
 * Noah Tomkins
 * September 21, 2020
 * 
 * Employee Infromation Program
 * Lists all the employees and their: Name, Number, Pay Rate, Hours, Gross Pay
 * 
 * Class: Sorts employee array and outputs to the console
 * 
 * I, Noah Tomkins, 000790079 certify that this material is my original work.  
 * No other person's work has been used without due acknowledgement.
 * 
 * Sorting algorithum from: 
 * https://www.w3resource.com/csharp-exercises/searching-and-sorting-algorithm/searching-and-sorting-algorithm-exercise-6.php
 */

using Lab4A;
using System;
using System.Collections.Generic;

namespace Lab_1___Noah_Tomkins___000790079
{
    class InsertionSort
    {

        Employee[] employees;

        /// <summary>
        /// Creates a new sort
        /// </summary>
        /// <param name="employees">Employees array</param>
        public InsertionSort(List<Employee> employees)
        {
            this.employees = employees.ToArray();
        }

        /// <summary>
        /// Sorts Employees by Name (Ascending)
        /// </summary>
        public void ByName()
        {
            // Sort using insertionSort
            for (int i = 0; i < employees.Length - 1; i++)
                for (int j = i + 1; j > 0; j--)
                    if (string.Compare(employees[j - 1].Name, employees[j].Name) == 1)
                    {
                        Employee temp = employees[j - 1];
                        employees[j - 1] = employees[j];
                        employees[j] = temp;
                    }

            DisplayHeader();

            // Display all Employees to the console (sorted)
            foreach (Employee employee in employees)
                Console.WriteLine(employee);
        }

        /// <summary>
        /// Sorts Employees by Number (Ascending)
        /// </summary>
        public void ByNumber()
        {
            // Sort using insertionSort
            for (int i = 0; i < employees.Length - 1; i++)
                for (int j = i + 1; j > 0; j--)
                    if (employees[j - 1].Number > employees[j].Number)
                    {
                        Employee temp = employees[j - 1];
                        employees[j - 1] = employees[j];
                        employees[j] = temp;
                    }

            DisplayHeader();

            // Display all Employees to the console (sorted)
            foreach (Employee employee in employees)
                Console.WriteLine(employee);
        }

        /// <summary>
        /// Sorts Employees by Pay Rate (Descending)
        /// </summary>
        public void ByRate()
        {
            // Sort using insertionSort
            for (int i = 0; i < employees.Length - 1; i++)
                for (int j = i + 1; j > 0; j--)
                    if (employees[j - 1].Rate < employees[j].Rate)
                    {
                        Employee temp = employees[j - 1];
                        employees[j - 1] = employees[j];
                        employees[j] = temp;
                    }

            DisplayHeader();

            // Display all Employees to the console (sorted)
            foreach (Employee employee in employees)
                Console.WriteLine(employee);
        }

        /// <summary>
        /// Sorts Employees by Hours (Descending)
        /// </summary>
        public void ByHours()
        {
            // Sort using insertionSort
            for (int i = 0; i < employees.Length - 1; i++)
                for (int j = i + 1; j > 0; j--)
                    if (employees[j - 1].Hours < employees[j].Hours)
                    {
                        Employee temp = employees[j - 1];
                        employees[j - 1] = employees[j];
                        employees[j] = temp;
                    }

            DisplayHeader();

            // Display all Employees to the console (sorted)
            foreach (Employee employee in employees)
                Console.WriteLine(employee);
        }

        /// <summary>
        /// Sorts Employees by Gross Pay (Descending)
        /// </summary>
        public void ByGross()
        {
            // Sort using insertionSort
            for (int i = 0; i < employees.Length - 1; i++)
                for (int j = i + 1; j > 0; j--)
                    if (employees[j - 1].Gross < employees[j].Gross)
                    {
                        Employee temp = employees[j - 1];
                        employees[j - 1] = employees[j];
                        employees[j] = temp;
                    }

            DisplayHeader();

            // Display all Employees to the console (sorted)
            foreach (Employee employee in employees)
                Console.WriteLine(employee);
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
