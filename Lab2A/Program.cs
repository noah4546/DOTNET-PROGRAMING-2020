/*
 * Noah Tomkins
 * October 11, 2020
 * 
 * Class: Program, Main class of the program
 * 
 * I, Noah Tomkins, 000790079 certify that this material is my original work.  
 * No other person's work has been used without due acknowledgement.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2A
{
    class Program
    {

        /// <summary>
        /// Main Class, Runs at startup
        /// </summary>
        static void Main()
        {
            List<Shape> shapes = new List<Shape>();

            while (true)
            {
                DisplayMenu(shapes.Count);

                string userInput = Console.ReadLine().ToUpper();

                Shape tempShape = null;
                switch (userInput)
                {
                    case "A": //Rectangle
                        tempShape = new Rectangle();
                        break;
                    case "B": //Square
                        tempShape = new Square();
                        break;
                    case "C": //Box
                        tempShape = new Box();
                        break;
                    case "D": //Cube
                        tempShape = new Cube();
                        break;
                    case "E": //Ellipse
                        tempShape = new Ellipse();
                        break;
                    case "F": //Circle
                        tempShape = new Circle();
                        break;
                    case "G": //Cylinder
                        tempShape = new Cylinder();
                        break;
                    case "H": //Sphere
                        tempShape = new Sphere();
                        break;
                    case "I": //Triangle
                        tempShape = new Triangle();
                        break;
                    case "J": //Tetrahedron
                        tempShape = new Tetrahedron();
                        break;
                    case "0": //List all shapes
                        DisplayAllShapes(shapes.ToArray());
                        break;
                    case "1": //Exit
                        Environment.Exit(0);
                        break;
                    default: //None selected
                        Console.WriteLine("\nSorry you must enter a letter between A - J or a number 0 - 1");
                        break;
                }

                if (tempShape != null)
                {
                    Console.WriteLine();
                    tempShape.SetData();

                    Console.WriteLine("\n\nAdded new shape:");
                    Console.WriteLine($"{tempShape.GetType().Name} {tempShape}");
                    Console.WriteLine("\nPress any key to continue");
                    Console.ReadKey();

                    shapes.Add(tempShape);
                }
            }
        }

        /// <summary>
        /// Displays the menu to the console
        /// </summary>
        /// <param name="numOfShapes">Number of shapes created</param>
        private static void DisplayMenu(int numOfShapes)
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Noah's Shapes:");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nA - Rectangle\tE - Ellipse\tI - Triangle");
            Console.WriteLine("B - Square\tF - Circle\tJ - Tetrahedron");
            Console.WriteLine("C - Box\t\tG - Cylinder");
            Console.WriteLine("D - Cube\tH - Sphere");

            Console.WriteLine("\n0 - List all shapes");
            Console.WriteLine("1 - Exit");

            Console.WriteLine($"\n({numOfShapes} shapes entered so far)");
            Console.Write("Enter your choice: ");
        }

        /// <summary>
        /// Displays all shapes to the console
        /// </summary>
        /// <param name="shapes">Shapes to display</param>
        private static void DisplayAllShapes(Shape[] shapes)
        {
            Console.WriteLine();

            if (shapes.Length > 0)
                foreach (Shape shape in shapes)
                    Console.WriteLine($"{shape.GetType().Name, -12} {shape}");
            else
                Console.WriteLine("No shapes added");

            Console.WriteLine("\nPress any key to continue");
            Console.ReadKey();
        }
    }
}
