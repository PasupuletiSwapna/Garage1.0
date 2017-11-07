using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageManagement
{

    public class Garage<T> : IEnumerable<T> where T : Vehicle
    {
        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    
        private int maxCapacity;
       // private T[] vehicles;
        public int MaxCapacity { get; set; }
        public Garage(int maxCapacity)
        {
            MaxCapacity = maxCapacity;

        }
        private List<Vehicle> vehicles = new List<Vehicle>() {
            new Vehicle { RegistrationNumber=123,Color="Red",Number_Of_Wheels=4,ModelType="Version001" },
             new Vehicle { RegistrationNumber=456,Color="Green",Number_Of_Wheels=4,ModelType="Version002" },
              new Vehicle { RegistrationNumber=789,Color="Blue",Number_Of_Wheels=2,ModelType="Version003" },
               new Vehicle { RegistrationNumber=1011,Color="Yellow",Number_Of_Wheels=4,ModelType="Version004" },
                new Vehicle { RegistrationNumber=1213,Color="Black",Number_Of_Wheels=0,ModelType="Version005" },
                new Vehicle { RegistrationNumber=1213,Color="Black",Number_Of_Wheels=0,ModelType="Version005"}

        };
        


    }


}
