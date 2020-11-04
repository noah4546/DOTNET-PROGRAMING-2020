/*
 * Noah Tomkins
 * September 21, 2020
 * 
 * Employee Infromation Program
 * Lists all the employees and their: Name, Number, Pay Rate, Hours, Gross Pay
 * 
 * Class: Employee, stores the employee as an object
 * 
 * I, Noah Tomkins, 000790079 certify that this material is my original work.  
 * No other person's work has been used without due acknowledgement.
 */


using System;
using System.Collections;
using System.Collections.Generic;

namespace Lab4A
{
    class Employee : IComparable<Employee>
    {
        public string Name { get; set; }
        public int Number { get; set; }
        public decimal Rate { get; set; }
        public double Hours { get; set; }
        public decimal Gross { get; private set; }
        
        /// <summary>
        /// Main Construtor of Employee, makes an employee object
        /// </summary>
        /// <param name="name">Employee Name</param>
        /// <param name="number">Employee Number</param>
        /// <param name="rate">Employee Pay Rate</param>
        /// <param name="hours">Employee Hours Worked</param>
        public Employee(string name, int number, decimal rate, double hours)
        {
            Name = name;
            Number = number;
            Rate = rate;
            Hours = hours;
            Gross = (decimal)Hours * Rate;

            if (hours > 40)
                Gross = Gross + (((decimal)Hours - 40) * Rate * (decimal)0.5);
        }

        /// <summary>
        /// Returns a string of Employee
        /// </summary>
        /// <returns>Employee string</returns>
        public override string ToString()
        {
            return $"{Name,-20}   {Number,-6}   {Rate,-6:$0.00}   {Hours,-5:0.00}   {Gross,9:0,0.00}";
        }

        /// <summary>
        /// Gets the comparer for Employees
        /// </summary>
        /// <returns>Employee Comparer</returns>
        public static EmployeeComparer GetComparer()
        {
            return new EmployeeComparer();
        }

        /// <summary>
        /// Compares right hand side to employee number
        /// </summary>
        /// <param name="rhs">Employee to compare</param>
        /// <returns>value to indicate greater, less, or equal</returns>
        public int CompareTo(Employee rhs)
        {
            return Number.CompareTo(rhs.Number);
        }

        /// <summary>
        /// Compares right hand side to employee whichComparison
        /// </summary>
        /// <param name="rhs">Employee to compare</param>
        /// <param name="whichComparison">Which property to compare with</param>
        /// <returns>value to indicate greater, less, or equal</returns>
        public int CompareTo(Employee rhs, EmployeeComparer.ComparisonType whichComparison)
        {
            switch (whichComparison)
            {
                case EmployeeComparer.ComparisonType.Name:
                    return Name.CompareTo(rhs.Name);
                case EmployeeComparer.ComparisonType.Number:
                    return Number.CompareTo(rhs.Number);
                case EmployeeComparer.ComparisonType.Rate:
                    return Rate.CompareTo(rhs.Rate) * -1; //*-1 to sort descending
                case EmployeeComparer.ComparisonType.Hours:
                    return Hours.CompareTo(rhs.Hours) * -1; //*-1 to sort descending
                case EmployeeComparer.ComparisonType.Gross:
                    return Gross.CompareTo(rhs.Gross) * -1; //*-1 to sort descending
            }
            return 0;
        }

        // Nested class which implements IComparer
        public class EmployeeComparer : IComparer<Employee>
        {
            public ComparisonType WhichComparison { get; set; }

            public enum ComparisonType
            {
                Name,
                Number,
                Rate,
                Hours,
                Gross
            };

            /// <summary>
            /// Compares two employees lhs and rhs depending on whichComparison
            /// </summary>
            /// <param name="lhs">Left hand side</param>
            /// <param name="rhs">Right hand side</param>
            /// <returns>value to indicate greater, less, or equal</returns>
            public int Compare(Employee lhs, Employee rhs)
            {
                return lhs.CompareTo(rhs, WhichComparison);
            }
        }
    }
}
