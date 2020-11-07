/*
 * Noah Tomkins
 * September 21, 2020
 * 
 * I, Noah Tomkins, 000790079 certify that this material is my original work.  
 * No other person's work has been used without due acknowledgement.
 */

using System;

namespace MidtermB
{
    /// <summary>
    /// Weather class: Used to store infromation about a weather
    /// Including the month, year, rainfall, and temperature
    /// Also Implements IComparable
    /// </summary>
    class Weather : IComparable<Weather>
    {
        public string Month { get; private set; }
        public int Year { get; private set; }
        public double RainFall { get; private set; }
        public double Temperature { get; private set; }

        /// <summary>
        /// Creates a new Weather object
        /// </summary>
        /// <param name="month">Month</param>
        /// <param name="year">Year</param>
        /// <param name="rainFall">Amount of rainfall in mm</param>
        /// <param name="temperature">Temperature in degrees celcius</param>
        public Weather(string month, int year, double rainFall, double temperature)
        {
            Month = month;
            Year = year;
            RainFall = rainFall;
            Temperature = temperature;
        }

        /// <summary>
        /// Returns a string that repersents the weather values
        /// </summary>
        /// <returns>Weather string</returns>
        public override string ToString()
        {
            // Displayed in this format beacuse ListBox does not like format {value, -x}
            if (Month == "September" || Month == "November" || Month == "December")
                return $"{Month}\t| {Year}\t| {RainFall}mm\t\t| {Temperature}°c";
            else
                return $"{Month}\t\t| {Year}\t| {RainFall}mm\t\t| {Temperature}°c";
        }

        /// <summary>
        /// Compares this rainfall to another rainfall
        /// Used for sorting rainfall
        /// </summary>
        /// <param name="rhs">Right hand side</param>
        /// <returns>Value to indicate greater, less, or equal</returns>
        public int CompareTo(Weather rhs)
        {
            return RainFall.CompareTo(rhs.RainFall) * -1;
        }
    }
}
