/*
 * Noah Tomkins
 * October 11, 2020
 * 
 * Class: Circle
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
    class Circle : Shape
    {
        protected double Radius { get; set; }

        /// <summary>
        /// Calculates the area
        /// </summary>
        /// <returns>Area</returns>
        public override double CalculateArea()
        {
            return Math.PI * Radius * Radius; // A = pi*r*r
        }

        /// <summary>
        /// Calculates the volume
        /// </summary>
        /// <returns>Volume</returns>
        public override double CalculateVolume()
        {
            return 0; // 0 because it is 2D and volume is a 3D attribute
        }

        /// <summary>
        /// Sets the data for the shape through the console
        /// </summary>
        public override void SetData()
        {
            Radius = Util.ValidateGetDouble("radius");
        }

        /// <summary>
        /// Returns a string that represents the current shape.
        /// </summary>
        /// <returns>A string that represents the current shape.</returns>
        public override string ToString()
        {
            return $" | Area={CalculateArea(),-10:G10} | Volume={CalculateVolume(),-10:G10} | Radius={Radius,-10:G10}";
        }
    }
}
