using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2___Forms
{
    class Car
    {
        private string make;
        private string model;
        private double fuelAmmount;
        private double mileage;

        public Car(string make, string model, double fuelAmmount, double mileage)
        {
            this.make = make;
            this.model = model;
            this.fuelAmmount = fuelAmmount;
            this.mileage = mileage;
        }

        public string getMake()
        {
            return this.make;
        }

        public string getModel()
        {
            return this.model;
        }

        public double calculateFuelEfficiency()
        {
            return this.fuelAmmount / this.mileage * 100;
        }

        public override string ToString()
        {
            return $"[{make}, {model}, Fuel Used={fuelAmmount}, Mileage={mileage}, Fuel Efficiency={calculateFuelEfficiency()}]";
        }
    }
}
