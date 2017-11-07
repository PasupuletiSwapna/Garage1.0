using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageManagement
{
    public class Airplane: Vehicle
    {

        private int number_Of_Engines;
        public int Number_Of_Engines { get; set; }

        public Airplane()
        {

        }
        public Airplane(int registrationNumber, string color, int number_Of_Wheels, string modelType,int number_Of_Engines):base(registrationNumber, color, number_Of_Wheels, modelType)
        {
            Number_Of_Engines = number_Of_Engines;
        }




    }
}
