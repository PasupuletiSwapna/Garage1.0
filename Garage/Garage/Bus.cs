using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageManagement
{
    public class Bus : Vehicle
    {
       

        private int noOfSeats;
        public int NoOfSeats
        {
            get {return noOfSeats; }
            set { NoOfSeats = value; }
        }

        public Bus(int reg, string col, int now, int tof, int nos) : base(reg, col, now, tof)
        {
            NoOfSeats = nos;
        }

        public override string PrintVehicle()
        {
            return base.PrintVehicle() + "\n The Bus contains" + NoOfSeats+ "seats\n";
        }



    }
}
