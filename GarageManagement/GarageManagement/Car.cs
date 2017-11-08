using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageManagement
{
    public class Car:Vehicle
    {
        private string fuelType;
        public string  FuelType {get; set; }
        public Car()
        {

        }
        public Car(string registrationNumber, string color, int number_Of_Wheels, string modelType, string fuelType):base(registrationNumber, color, number_Of_Wheels, modelType)
        {
            FuelType = fuelType;
        }

    }
}
