﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageManagement
{
   public class Vehicle
    {
        private string registrationNumber;
        private string color;
        private int number_Of_Wheels;
        private string modelType;
        public string RegistrationNumber { get; set; }
        public string Color { get; set; }
        public int Number_Of_Wheels { get; set; }
        public string ModelType { get; set; }
        public Vehicle()
        {

        }
        public Vehicle(string registrationNumber, string color,int number_Of_Wheels,string modelType)
        {
            RegistrationNumber = registrationNumber;
            Color = color;
            Number_Of_Wheels = number_Of_Wheels;
            ModelType = modelType;

        }

     


    }
}
