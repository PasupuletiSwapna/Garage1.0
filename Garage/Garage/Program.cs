using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageManagement
{
    public class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {

                Vehicle veh = new Vehicle();

                Console.Write("\n****************************************************************\n");
                Console.WriteLine("\n Enter |1|--> Navigate to all functionality of the Garage ");
                Console.WriteLine("\n Enter |2|--> To know the Garage Specific size ");
                Console.WriteLine("\n Enter |3|--> To Exit from this Menu ");
                Console.Write("\n*****************************************************************\n");
                string uinput = Console.ReadLine();

                int input = 0;
                if (!int.TryParse(uinput, out input))
                {
                    Console.WriteLine("Please enter valid input, number is expected!");
                }


                switch (input)
                {
                    case '1':
                        

                        break;
                    case '2': break;
                    case '3': return;




                }

          

            }
            }

        public void Listofvehicle()
        {
            
        }


    }
}
