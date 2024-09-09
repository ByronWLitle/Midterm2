using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Initialize variables to hold values
            int units = 0;
            double cost = 0;
            //Prompts user on units consumed 
            Console.WriteLine("Number of units consumed");
            //Converts user input to integer variable and stores in memory
            units = Convert.ToInt32(Console.ReadLine());
            //Divides prompt for visibility
            if (units > 500)
            {
                cost = (100 * 0.5); //Calculates 100 units at 0.5 (0-100 units)
                cost = cost + (200 * 0.75); //Adds cost from previous and calculates 200 units at 0.75 (101-300 units)
                cost = cost + (200 * 1.20); //Adds cost from previous and calculates 200 units at 1.20 (301-500 units)
                units -= 500; //Removes 500 from units to calculate remainder
                cost = cost + (units * 1.50); //Adds cost from previous and calculates remainder units at 1.50 (>500 units)


            }
            else if (units > 300)
            {
                cost = (100 * 0.5); //Calculates 100 units at 0.5 (0-100 units)
                cost = cost + (200 * 0.75); //Adds cost from previous and calculates 200 units at 0.75 (101-300 units)
                units -= 300; //Removes 300 from units to calculate remainder
                cost = cost + (units * 1.20); //Adds cost from previous and calculates remainder units at 1.20 (>300 units)
            }
            else if (units > 100)
            {
                cost = (100 * 0.5); //Calculates 100 units at 0.5 (0-100 units)
                units -= 100; //Removes 100 from units to calculate remainder
                cost = cost + (units * 0.75); //Adds cost from previous and calculates remainder units at 0.75 (>100 units)
            }
            else 
            {
                cost = units * 0.5; //Calculate units at 0.5 (<100)
            }
            //Adds surcharge
            cost += 50;
            //Outputs bill total
            Console.WriteLine($"The bill total is: ${cost}");
            //Allows user to view program before ending
            Console.ReadLine();
        }
    }
}
