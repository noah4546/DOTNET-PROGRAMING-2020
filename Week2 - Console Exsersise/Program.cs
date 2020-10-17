using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2___Console_Exsersise
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Car[] myCars = new Car[]
            {
                new Car("Honda", "Civic", 40, 550),
                new Car("Ford", "Mustang", 45, 432),
                new Car("VW", "Golf", 34, 667),
                new Car("Ford", "Focus", 39, 600),
                new Car("Chevrolet", "Cruz", 40, 525),
                new Car("Dodge", "Charger", 60, 300)
            };
            */

            Car[] myCars = LoadCars();

            if(myCars != null)
            {
                CarView carView = new CarView(myCars);
                carView.ProcessUserSelection();
            }
            
        }

        private static Car[] LoadCars()
        {
            Car[] myCars = new Car[6];
            int count = 0;

            try
            {
                FileStream fs = new FileStream("../../cars.csv", FileMode.Open);
                StreamReader sr = new StreamReader(fs);

                while (!sr.EndOfStream && count < myCars.Length)
                {
                    // Read next line
                    string input = sr.ReadLine();

                    // Parse the values
                    string[] values = input.Split(',');
                    string make = values[0];
                    string model = values[1];
                    if (double.TryParse(values[2], out double fuelAmount) == false)
                    {
                        Console.WriteLine("Failed to parse fuelAmount from file, car:" + make + ", " + model);
                        return null; // log an error
                    }

                    if (double.TryParse(values[3], out double mileage) == false)
                    {
                        Console.WriteLine("Failed to parse mileage from file, car:" + make + ", " + model);
                        return null; // log an error
                    }

                    // Create new car
                    myCars[count] = new Car(make, model, fuelAmount, mileage);
                    count++;
                }

                fs.Close();
                sr.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Exeption loading cars from file due to: {e.Message}");
            }

            return myCars;
        }
    }
}
