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


namespace Lab4A
{
    class Employee
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
        }

        public override string ToString()
        {
            return $"{Name,-20}   {Number,-6}   {Rate,-6:$0.00}   {Hours,-5:0.00}   {Gross,9:0,0.00}";
        }

    }
}
