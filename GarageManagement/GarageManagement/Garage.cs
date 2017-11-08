using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageManagement
{

    //public class Garage<T> : IEnumerable<T> where T : Vehicle
    //{
    //    public IEnumerator<T> GetEnumerator()
    //    {
    //        throw new NotImplementedException();
    //    }

    //    IEnumerator IEnumerable.GetEnumerator()
    //    {
    //        throw new NotImplementedException();
    //    }

        class Garage<T> : IEnumerable<T> where T : Vehicle
        {
            public  int ParkingNumber = 0;
            public int Id { get; set; }
            public string Name { get; set; }
            public List<T> Vehicles { get; set; }
            private  int capacity;
            private  string name;
            public int Capacity {get; set;}
      
            private static int parkingNumber = 0;
        

            public Garage(int maxCapacity)
            {
                this.Id = parkingNumber++;
                this.Name = name;
                this.Vehicles = new List<T>();
            this.Capacity = maxCapacity;
            }

                   
            public override string ToString()
            {
                //return string.Format("{1, 30} {2, 3}", Id, Name, Vehicles.Count);
                return string.Format(  Name, Vehicles.Count,Capacity);
            }


        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }



































       // private int maxCapacity;
       //// private T[] vehicles;
       // public int MaxCapacity { get; set; }
       // public Garage(int maxCapacity)
       // {
       //     MaxCapacity = maxCapacity;

       // }

       // //  Garage<T> s_Garage = new Garage<T>();
       // // s_Garage.Add(vehicles);
       
       // public string addVehicle(Vehicle vehicle)
       // {
       //     try
       //     {
       //         vehicles.Add(vehicle);
       //         return "Vehicle added to Garage";
       //     }
       //     catch (Exception ex)
       //     {
       //         return "Vehicle not added to Garage" + ex;
                
       //     }
       // }

       // public Vehicle getVehicle(string registrationNumber)
       // {
       //     foreach (Vehicle  vehi in vehicles)
       //     {
       //         if (vehi.RegistrationNumber == registrationNumber)
       //             return vehi;
       //     }
       //     return null;
       // }
       // public string removeVehicle(string registrationNumber)
       // {
       //     try
       //     {
       //         Vehicle vehi = getVehicle(registrationNumber);
       //         if (vehi != null)
       //             vehicles.Remove(vehi);
       //         return "Vehicle removed from Garage";
       //     }
       //     catch (Exception ex)
       //     {
       //         return "Vehicle not removed from Garage" + ex;

       //     }
       // }






       // private List<Vehicle> vehicles = new List<Vehicle>() {
       //     new Vehicle { RegistrationNumber="123",Color="Red",Number_Of_Wheels=4,ModelType="Version001" },
       //      new Vehicle { RegistrationNumber="456",Color="Green",Number_Of_Wheels=4,ModelType="Version002" },
             
       // };
        


    }


}
