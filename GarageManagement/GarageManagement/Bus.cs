using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageManagement
{
   public class Bus:Vehicle
    {
        private int number_Of_Seats;
        public int Number_Of_Seats { get; set; }
        public Bus()
        {

        }
        public Bus(string registrationNumber, string color, int number_Of_Wheels, string modelType, int number_Of_Seats) : base(registrationNumber, color, number_Of_Wheels, modelType)
        {
            Number_Of_Seats = number_Of_Seats;
        }
        




    }
}
