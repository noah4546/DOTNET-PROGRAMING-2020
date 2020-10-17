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
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1___Noah_Tomkins___000790079
{
    class Employee
    {
        private string name;
        private int number;
        private decimal rate;
        private double hours;
        private decimal gross;
        
        /// <summary>
        /// Main Construtor of Employee, makes an employee object
        /// </summary>
        /// <param name="name">Employee Name</param>
        /// <param name="number">Employee Number</param>
        /// <param name="rate">Employee Pay Rate</param>
        /// <param name="hours">Employee Hours Worked</param>
        public Employee(string name, int number, decimal rate, double hours)
        {
            this.name = name;
            this.number = number;
            this.rate = rate;
            this.hours = hours;
            this.gross = (decimal)this.hours * this.rate;
        }

        /// <summary>
        /// Gets the gross pay of employee
        /// </summary>
        /// <returns>Gross Pay</returns>
        public decimal GetGross()
        {
            this.gross = (decimal)this.hours * this.rate;
            return (decimal)this.hours * this.rate;
        }

        /// <summary>
        /// Get hours worked of employee
        /// </summary>
        /// <returns>Hours Worked</returns>
        public double GetHours()
        {
            return this.hours;
        }

        /// <summary>
        /// Get Employee Name
        /// </summary>
        /// <returns>Employee Name</returns>
        public string GetName()
        {
            return this.name;
        }

        /// <summary>
        /// Get Employee Number
        /// </summary>
        /// <returns>Employee Number</returns>
        public int GetNumber()
        {
            return this.number;
        }

        /// <summary>
        /// Get Employee Pay Rate
        /// </summary>
        /// <returns>Pay Rate</returns>
        public decimal GetRate()
        {
            return this.rate;
        }

        /// <summary>
        /// ToString for Employee
        /// </summary>
        /// <returns>Employee ToString</returns>
        public override string ToString()
        {
            return $"{name,-20}   {number,-6}   {rate.ToString("$0.00"),-6}   {hours.ToString("0.00"),-5}   {gross.ToString("$0,0.00"),9}";
        }

        /// <summary>
        /// Sets the hours worked for employee
        /// </summary>
        /// <param name="hours">Hours worked</param>
        public void SetHours(double hours)
        {
            this.hours = hours;
            gross = (decimal)this.hours * rate;
        }

        /// <summary>
        /// Sets the name of the employee
        /// </summary>
        /// <param name="name">Employee name</param>
        public void SetName(string name)
        {
            this.name = name;
        }

        /// <summary>
        /// Sets the employee number
        /// </summary>
        /// <param name="number">Employee Number</param>
        public void SetNumber(int number)
        {
            this.number = number;
        }

        /// <summary>
        /// Sets the pay rate for employee
        /// </summary>
        /// <param name="rate">Employee Pay Rate</param>
        public void SetRate(decimal rate)
        {
            this.rate = rate;
            gross = (decimal)hours * this.rate;
        }
    }
}
