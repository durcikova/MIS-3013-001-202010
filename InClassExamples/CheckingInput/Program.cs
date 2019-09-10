using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckingInput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your favorite # >>");
            string answer = Console.ReadLine();
            int answerAsInteger;

            bool isSuccess = int.TryParse(answer, out answerAsInteger);
            
            if (isSuccess == true)
            {
                Console.WriteLine("Congratulations, you entered a valid number!");
            }
            else
            {
                Console.WriteLine("Sorry that was not a number, you lose");
            }

            Console.ReadKey();
        }
    }
}
