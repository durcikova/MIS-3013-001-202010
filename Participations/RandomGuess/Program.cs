/*Create a new console application (using the .NET Framework and not .NET Core).  
 * Name your project and solution RandomGuess.  Generate a random number between 1 and 100, 
 * 
 * using the Random (Links to an external site.) class.  Prompt the user to guess the random number until 
 * they successfully guess it.

 Author = Alex

Extra's:

Allow the user to input the range for the random number (between X and Y)
Validate that the user actually input a valid number, if they did not, prompt them to input a valid number
 * 
 * 
 */

using System;

namespace RandomGuess
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var rand = new Random();
            int roll = rand.Next(1, 100);
            Console.WriteLine(roll);



            Console.WriteLine("Please guess a random number between 1 and 100");
            string answerAsString = Console.ReadLine();
            int Uanswer = Convert.ToInt32(answerAsString);



            while (roll != Uanswer)

            {

                Console.WriteLine("Sorry, this is not the correct number");
                Console.WriteLine("Please guess another random number between 1 and 100");
                answerAsString = Console.ReadLine();
                Uanswer = Convert.ToInt32(answerAsString);


            }

            Console.WriteLine("Congratulation! You guessed the correct number!");
        }
    }
}
