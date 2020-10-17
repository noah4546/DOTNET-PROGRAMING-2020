/*
 * Noah Tomkins
 * October 11, 2020
 * 
 * Class: Tetrahedron
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
    class Tetrahedron : Shape
    {
        protected double Length { get; set; }

        /// <summary>
        /// Calculates the suface area
        /// </summary>
        /// <returns>Surface area</returns>
        public override double CalculateArea()
        {
            return Math.Sqrt(3) * Length * Length; // A = sqrt(3) * l^2
        }

        /// <summary>
        /// Calculates the volume
        /// </summary>
        /// <returns>Volume</returns>
        public override double CalculateVolume()
        {
            return (Length * Length * Length) / (6 * Math.Sqrt(2)); // V = (l^3)/(6 * sqrt(2))
        }

        /// <summary>
        /// Sets the data for the shape through the console
        /// </summary>
        public override void SetData()
        {
            Length = Util.ValidateGetDouble("height");
        }

        /// <summary>
        /// Returns a string that represents the current shape.
        /// </summary>
        /// <returns>A string that represents the current shape.</returns>
        public override string ToString()
        {
            return $" | Area={CalculateArea(), -12:G7} | Volume={CalculateVolume(), -12:G7} | Length={Length, -12:G7}";
        }
    }
}
