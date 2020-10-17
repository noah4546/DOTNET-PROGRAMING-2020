using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3A
{
    class Car
    {

        public string Make { get; }
        public string Model { get; }
        public double FuelAmmount { get; }
        public double Mileage { get; }

        public Car(string make, string model, double fuelAmmount, double mileage)
        {
            Make = make;
            Model = model;
            FuelAmmount = fuelAmmount;
            Mileage = mileage;
        }

        public double calculateFuelEfficiency() { return FuelAmmount/Mileage * 100; }

        public override string ToString()
        {
            return $"[{Make}, {Model}, Fuel Used={FuelAmmount}, Mileage={Mileage}, Fuel Efficiency={calculateFuelEfficiency()}]";
        }
    }
}
