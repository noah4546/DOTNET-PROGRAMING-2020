using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3A
{
    class CarView
    {
        private Car[] cars;

        public CarView(Car[] cars)
        {
            this.cars = cars;
        }

        public bool ProcessUserSelection()
        {

            while (true)
            {

                Console.WriteLine("CAR APPLICATION");
                Console.WriteLine("===============");
                Console.WriteLine("\n MENU");
                Console.WriteLine("1 - Display all of the Cars");
                Console.WriteLine("2 - List car with best Mileage");
                Console.WriteLine("3 - List all Cars from Ford");
                Console.WriteLine("4 - Exit application");
                Console.WriteLine("\n Enter Option:");

                string input = Console.ReadLine();
                if ((int.TryParse(input, out int userSelection) == false) || userSelection < 1 || userSelection > 4)
                {
                    Console.WriteLine("Input invalid. Please enter a value between 1 and 4.");
                    continue;
                }

                if (userSelection == 1)
                    DisplayAll();
                else if (userSelection == 2)
                    DisplayBestMileage();
                else if (userSelection == 3)
                    DisplayMake("Ford");
                else //userSelection must be 4, so exit
                    break;

                Console.WriteLine("\nPress any key to continue");
                _ = Console.ReadLine();
                Console.Clear();

            }
            return true;
        }

        private void DisplayMake(string make)
        {
            foreach (Car car in cars)
            {
                if(car.Make == make)
                    Console.WriteLine(car);
            }
        }

        private void DisplayBestMileage()
        {
            int minIndex = 0;
            double min = 10000;
            for (int i = 0; i < cars.Length; i++)
            {
                double fuelEfficiency = cars[i].calculateFuelEfficiency();
                if(fuelEfficiency < min)
                {
                    min = fuelEfficiency;
                    minIndex = i;
                }
            }
            Console.WriteLine(cars[minIndex]);
        }

        private void DisplayAll()
        {
            var filterOrderedCars = from car in cars
                                    where car.calculateFuelEfficiency() > 2
                                    orderby car.calculateFuelEfficiency() descending
                                    select car;


            foreach (Car car in filterOrderedCars)
                Console.WriteLine(car);
        }
    }
}
