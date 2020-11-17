using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week10_Collections
{
    public class Car
    {
        private string make;
        private string model;
        private double fuelAmount;
        private double mileage;
        private static int count;

        public int Id { get; set; }

        public Car(string make, string model, double fuelAmount, double mileage)
        {
            this.make = make;
            this.model = model;
            this.fuelAmount = fuelAmount;
            this.mileage = mileage;
            Id = ++count;
        }

        public string getMake() { return make; }
        public string getModel() { return model; }
        public double calculateFuelEfficiency() { return fuelAmount / mileage * 100; }
        public override string ToString()
        {
            return $"[{Id},{make,-15},{model,-15},Fuel Used={fuelAmount,2},Mileage={mileage,3}," +
                    $"FuelEfficiency={calculateFuelEfficiency(),5:f}]";
        }
    }
}
