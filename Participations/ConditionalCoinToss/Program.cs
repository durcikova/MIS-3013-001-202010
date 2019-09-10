using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalCoinToss
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 = heads
            //2 = tails

            Random rand = new Random();
            // Just checking to see if it really just generates values that are either 1 or 2
            //for (int i = 1; i < 50; i++)
            //{
            //    int roll = rand.Next(1, 3);
            //    Console.WriteLine(roll.ToString("N0"));
            //}
            int roll = rand.Next(1, 3);
            int userGuess = 0;
            Console.WriteLine("Call it in the air, heads or tails? >>");
            string answer = Console.ReadLine();

            if (answer == "heads")
            {
                userGuess = 1;
            }
            else if(answer == "tails")
            {
                userGuess = 2;
            }
            else
            {
                Console.WriteLine("Sorry invalid guess. Goodbye.");
                Environment.Exit(0);
            }

            if (userGuess == roll)
            {
                Console.WriteLine($"Congratulations, it came up {answer} you guessed right!");
            }
            else
            {
                if(roll == 1)
                {
                    Console.WriteLine("Sorry, the coin came up heads");
                }
                else
                {
                    Console.WriteLine("Sorry, the coin came up tails");
                }
            }

            Console.ReadKey();
        }
    }
}
