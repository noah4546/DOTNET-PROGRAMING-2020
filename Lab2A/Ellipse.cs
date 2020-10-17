/*
 * Noah Tomkins
 * October 11, 2020
 * 
 * Class: Ellipse
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
    class Ellipse : Shape
    {
        protected double SemiMajorAxis { get; set; }
        protected double SemiMinorAxis { get; set; }

        /// <summary>
        /// Calculates the area
        /// </summary>
        /// <returns>Area</returns>
        public override double CalculateArea()
        {
            return Math.PI * SemiMajorAxis * SemiMinorAxis; // A = πab
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
            SemiMajorAxis = Util.ValidateGetDouble("semi-major axis length");
            SemiMinorAxis = Util.ValidateGetDouble("semi-minor axis length");
        }

        /// <summary>
        /// Returns a string that represents the current shape.
        /// </summary>
        /// <returns>A string that represents the current shape.</returns>
        public override string ToString()
        {
            return $" | Area={CalculateArea(),-10:G10} | Volume={CalculateVolume(),-10:G10} | Major-Axis={SemiMajorAxis,-10:G10} | Minor-Axis={SemiMinorAxis,-10:G10}";
        }
    }
}
