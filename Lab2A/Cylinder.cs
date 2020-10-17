/*
 * Noah Tomkins
 * October 11, 2020
 * 
 * Class: Cylinder
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
    class Cylinder : Circle
    {
        protected double Height { get; set; }

        /// <summary>
        /// Calculates the suface area
        /// </summary>
        /// <returns>Surface area</returns>
        public override double CalculateArea()
        {
            return (2 * Math.PI * Radius * Height) + (2 * base.CalculateArea()); // A = 2πrh + 2πr*r
        }

        /// <summary>
        /// Calculates the volume
        /// </summary>
        /// <returns>Volume</returns>
        public override double CalculateVolume()
        {
            return base.CalculateArea() * Height;
        }

        /// <summary>
        /// Sets the data for the shape through the console
        /// </summary>
        public override void SetData()
        {
            base.SetData();

            Height = Util.ValidateGetDouble("height");
        }

        /// <summary>
        /// Returns a string that represents the current shape.
        /// </summary>
        /// <returns>A string that represents the current shape.</returns>
        public override string ToString()
        {
            return base.ToString() + $" | Height={Height,-10:G10}";
        }
    }
}
