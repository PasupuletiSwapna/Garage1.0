using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Please choose 1,2 or 3");
                Console.WriteLine("\n 1.Navigate to all functionality of the garage"
                    + "\n 2.Create a new garage with a specific size"
                    + "\n 3.Close the application from menu");
                string userinput = Console.ReadLine();
                int input = 0;
                if (!int.TryParse(userinput, out input))
                {
                    Console.WriteLine("Please enter valid input, number is expected!");
                }

                switch (input)
                {
                    case 1:
                        Console.WriteLine("Navigate to all functionality of the garage");

                        break;
                    case 2:
                        Console.WriteLine("Create a new garage with a specific size");
                        break;
                    case 3:
                        Console.WriteLine("Close the application from menu");
                       return;
                    default:
                        Console.WriteLine("Invalid Input!Choose among 1,2 or 3");
                        break;
                }
               
            }
            
        }
    }
}
