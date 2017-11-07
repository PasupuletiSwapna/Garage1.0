using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageManagement
{
    public class Car : Vehicle
    {

        private string fueltype;
        public string FuelType
        {
            get { return fueltype; }
            set { FuelType = value; }
        }

        public Car(int reg, string col, int now, int tof, string fut) : base(reg, col, now, tof)
        {
            FuelType = fut;
        }

        public override string PrintVehicle()
        {
            return base.PrintVehicle() + "\n Its a " + FuelType + GetType().Name;
        }

    }
}
