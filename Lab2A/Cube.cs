/*
 * Noah Tomkins
 * October 11, 2020
 * 
 * Class: Cube
 * 
 * I, Noah Tomkins, 000790079 certify that this material is my original work.  
 * No other person's work has been used without due acknowledgement.
 */
using Lab2A;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2A
{
    class Cube : Square
    {
        /// <summary>
        /// Calculates the suface area
        /// </summary>
        /// <returns>Surface area</returns>
        public override double CalculateArea()
        {
            return base.CalculateArea() * 6; // *6 beacuse as box has 6 sides
        }

        /// <summary>
        /// Calculates the volume
        /// </summary>
        /// <returns>Volume</returns>
        public override double CalculateVolume()
        {
            return base.CalculateArea() * Length; //
        }

        /// <summary>
        /// Sets the data for the shape through the console
        /// </summary>
        public override void SetData()
        {
            base.SetData();
        }

        /// <summary>
        /// Returns a string that represents the current shape.
        /// </summary>
        /// <returns>A string that represents the current shape.</returns>+
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
