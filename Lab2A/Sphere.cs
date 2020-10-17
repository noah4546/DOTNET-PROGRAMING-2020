/*
 * Noah Tomkins
 * October 11, 2020
 * 
 * Class: Sphere
 * 
 * I, Noah Tomkins, 000790079 certify that this material is my original work.  
 * No other person's work has been used without due acknowledgement.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2A
{
    class Sphere : Circle
    {
        /// <summary>
        /// Calculates the suface area
        /// </summary>
        /// <returns>Surface area</returns>
        public override double CalculateArea()
        {
            return base.CalculateArea() * 4; // A = 4πr^2
        }

        /// <summary>
        /// Calculates the volume
        /// </summary>
        /// <returns>Volume</returns>
        public override double CalculateVolume()
        {
            return (4/3) * Math.PI * Radius * Radius * Radius; // V = 4/3 * π * r^3
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
        /// <returns>A string that represents the current shape.</returns>
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
