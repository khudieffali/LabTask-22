using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTask_22
{
    internal class Vehicle
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public double Millage { get; set; }
        public double RestFuel { get; set; }
        public Vehicle(string brand, string model,double millAge,double restFuel)
        {
                Brand = brand;
                Model = model;
                Millage = millAge;
                RestFuel = restFuel;
        }

    }
}
