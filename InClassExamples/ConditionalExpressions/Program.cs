/* In class example over conditional statements (if statements)
 * 
 * @author Adam Ackerman
 */
using System;

namespace ConditionalExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            string weightAsString, distanceAsString, containsHazardousAsString; // don't need distanceAsString since we read and converted the user's input all in one statment
            double weight, distance;
            bool containsHazardous;

            Console.WriteLine("What is the weight of your shipment? >>");
            weightAsString = Console.ReadLine();
            weight = Convert.ToDouble(weightAsString);

            Console.WriteLine("What is the distance of your shipment? >>");
            distance = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Does your shipment contain hazardous material (yes/no)? >>");
            containsHazardousAsString = Console.ReadLine();

            double quote = distance * 0.55 + weight * 0.73;
            double hazardousCost = 0;

            containsHazardousAsString = containsHazardousAsString.ToLower();
            if (containsHazardousAsString == "yes") 
            {
                // this is the only place in our code that we know for sure that the user typed "yes" for their shipment containing hazardous material
                containsHazardous = true;
                hazardousCost = 0.15 * weight;
            }
            else if (containsHazardousAsString == "no")
            {
                containsHazardous = false;
                hazardousCost = 0;
            }
            else
            {
                Console.WriteLine("Invalid input for hazardous material, please contact support for help.");
                Environment.Exit(-1);
            }

            double netTotal = quote + hazardousCost;
            double discount = 0;

            if (distance < 150 && weight > 500)
            {
                discount = netTotal * .10;
            }

            double total = netTotal - discount;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Hazardous Cost:\t{hazardousCost.ToString("C2")}");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Discount:\t{discount.ToString("C2")}");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Total:\t\t{total.ToString("C2")}");

            Console.ReadKey();
        }
    }
}
