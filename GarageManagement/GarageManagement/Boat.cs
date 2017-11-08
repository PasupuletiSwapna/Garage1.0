using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageManagement
{
  public class Boat:Vehicle
    {
        private int length;
        public int Length { get; set; }
        public Boat()
        {

        }
        public Boat(string registrationNumber, string color, int number_Of_Wheels, string modelType, int length):base(registrationNumber,color,number_Of_Wheels,modelType)
        {
            Length = length;
        }

    }
}

     