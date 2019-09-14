using System;

namespace FizzBuzzTest
{
    class Program
    {
        static void Main(string[] args)

           //Console.WriteLine("This program will perform FizzBuzz on your lucky number. Let's see if you can figure out how FizzBuzz works...");
           //Console.WriteLine("\nPlease input your lucky number now");

        Console.WriteLine("Please input your lucky number");
            string inputString = Console.ReadLine();
            int LNB = Convert.ToInt32(inputString);
          
            if (LNB % 3 == 0 && LNB % 5 == 0)
            {
                Console.WriteLine(LNB + "Fizzbuzz");
            }


            else if (LNB % 3 == 0)
            {
                Console.WriteLine(LNB + "Fizz");
            }
            else if (LNB % 5 == 0)
            {
                Console.WriteLine(LNB + "Buzz");
            }

        
    
    
}
