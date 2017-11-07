using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageManagement
{
    public class Vehicle
    {                                                                                                               
        private int regnum;
        public int RegNum
        {
            get { return regnum; }
            set { regnum = value; }
        }

        private string color;
        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        private int noOfWheels;
        public int NoOfWheels
        {
            get { return noOfWheels; }
            set { noOfWheels = value; }
        }

        private int typeofmodel;
        public int TypeofModel
        {
            get { return typeofmodel; }
            set { typeofmodel = value; }

        }

        public Vehicle()
        { }

        public Vehicle(int reg, string col, int now, int tof)
        {
            RegNum = reg;
            Color = col;
            NoOfWheels = now;
            TypeofModel = tof;
        }

        public virtual string PrintVehicle()
        {
            return "\n Register Number of the"+GetType().Name+"is--" +RegNum+ "\n The color of this vehicle is--"+Color+
                   "\n And Its a" +NoOfWheels+ " vehicle.."+"\n Its a "+TypeofModel+ "model" ;
        }











    }
}
