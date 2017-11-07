using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageManagement
{
    public class Motorcycle : Vehicle
    {

        private float cylindervolume;
        public float CylinderVolume
        {
            get { return cylindervolume; }
            set { cylindervolume = value; }
        }

        public Motorcycle(int reg, string col, int now, int tof, float cyv) : base(reg, col, now, tof)
        {
            CylinderVolume = cyv;
        }

        public override string PrintVehicle()
        {
            return base.PrintVehicle() + "\n The cylinder volume of the"  +GetType().Name +  "is" +CylinderVolume ;
        }
    }
}
