using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
* 10 Sep
* CSC 253
* Edmund Gonzales
* CarClass
*/

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            int year1 = 0;

            AutoLibrary.Car Mycar = new AutoLibrary.Car();

            Console.Write("What make is the vehicle? ");
            string make1  = Console.ReadLine();
            Mycar.Make = make1;

            Console.Write("What is the vehicle year? ");
            string input = Console.ReadLine();
            if (int.TryParse(input, out year1))
            {
                Mycar.Year = year1;
            }
            else
            {
                Console.WriteLine("");
            }

            bool exit = false;

            do
            {
                Console.Write("Is the car going faster or braking? ");
                Console.Write("Enter anything else to exit: ");
            string input0 = Console.ReadLine();

            if (input0 == "faster")
            {
                Console.WriteLine("yes");
                Mycar.Accelarate(5);
                Console.WriteLine($"Your {Mycar.Year} { Mycar.Make} is going {Mycar.Speed} mph!");
                Console.WriteLine("");

                }
            else if (input0 == "braking")
            {
                Console.WriteLine("no");
                Mycar.Brake(5);
                Console.WriteLine($"Your {Mycar.Year} { Mycar.Make} is going {Mycar.Speed} mph!");
                Console.WriteLine("");
                }
            else
            {
                    exit = true;
            }

            } while (exit == false);

            Console.WriteLine($"Your {Mycar.Year} { Mycar.Make}'s final speed is {Mycar.Speed} mph!");

            Console.ReadLine();
        }
    }
}
