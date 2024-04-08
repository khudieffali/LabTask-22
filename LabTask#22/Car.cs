using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTask_22
{
    internal class Car : Vehicle
    {
        public double FuelCapacity { get; set; }
        public Car(string brand, string model, double millAge, double fuelCapacity, double restFuel) : base(brand, model, millAge, restFuel)
        {
            FuelCapacity = fuelCapacity;
        }

        public bool AddFuel(double fuel)
        {
            bool check = true;
            if ((RestFuel + fuel) > FuelCapacity)
            {
                check = false;
            }
            else
            {
                RestFuel += fuel;
            }
            return check;
        }
    }
}
