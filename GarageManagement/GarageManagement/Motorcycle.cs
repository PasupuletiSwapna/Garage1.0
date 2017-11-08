using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageManagement
{
    public class Motorcycle:Vehicle
    {
        private float cylinder_Volume;
        public float Cylinder_Volume { get; set; }

        public Motorcycle()
        {

        }

        public Motorcycle(string registrationNumber, string color, int number_Of_Wheels, string modelType, float cylinder_Volume):base(registrationNumber, color, number_Of_Wheels, modelType)
        {
            Cylinder_Volume = cylinder_Volume;
        }
       

    }
}
