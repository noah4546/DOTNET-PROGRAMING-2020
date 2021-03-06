﻿/*
 * Noah Tomkins
 * October 11, 2020
 * 
 * Class: Triangle
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
    class Triangle : Shape
    {
        protected double Base { get; set; }
        protected double Height { get; set; }

        /// <summary>
        /// Calculates the area
        /// </summary>
        /// <returns>Area</returns>
        public override double CalculateArea()
        {
            return (Height * Base); // A = (hb)/2
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
            Base = Util.ValidateGetDouble("base");
            Height = Util.ValidateGetDouble("height");
        }

        /// <summary>
        /// Returns a string that represents the current shape.
        /// </summary>
        /// <returns>A string that represents the current shape.</returns>
        public override string ToString()
        {
            return $" | Area={CalculateArea(), -12:G7} | Volume={CalculateVolume(), -12:G7} | Base={Base, -12:G7} | Height={Height, -12:G7}";
        }
    }
}
