/*
 * Create a Visual C# Console application, name your Solution CustomerReceipt and your project CashRegister.  
 * Your application should prompt the user for the customer’s name, the sales tax (read this in as a decimal and not a %) and the net amount.  Output a sentence to the user with their name, the sales tax, the amount of sales tax for the receipt and the total amount for the bill.  
 * Output all values appropriately (e.g. percentages should be a percent, dollar amounts should have 2 decimal places, commas and currency symbol
 * 
 * @Author Adam Ackerman
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesAndInputAndConversionAndFormatting
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare variables (reserving memory so that we have places to store our values)
            const double cSalesTax = 0.086;//Creates a constant with the value of 8.6% and keeps it from changing.
            double salesTax;//Can declare variables one at a time
            double netTotal;
            double totalAmount;
            string name, salesTaxAsString, netTotalAsString; // or you can declare variables with the same datatype all on one line

            // Get input from the user
            Console.WriteLine("Please enter your name. >>");//Write to the console asking the user for their name
            name = Console.ReadLine();//Read the response from the user and store it in a variable

            Console.WriteLine("Enter sales tax (as a decimal) >>");
            salesTaxAsString = Console.ReadLine();

            Console.WriteLine("Enter your net total >>");
            netTotalAsString = Console.ReadLine();

            // Convert strings to number data types
            salesTax = Convert.ToDouble(salesTaxAsString);
            netTotal = Convert.ToDouble(netTotalAsString);

            double taxTotal = salesTax * netTotal; // declare a variable and assign a value at once
            totalAmount = netTotal + taxTotal;

            string sentence = name + " with a sales tax of " + salesTax.ToString("P") +
                              " you will pay " + taxTotal.ToString("C2") +
                              " in tax making your grand total to be " + totalAmount.ToString("C"); //Concatenate a bunch of strings together into a single one
            // Output
            Console.WriteLine(sentence); //output our string to the user
            /*Can write a single statement to concatenate and output in one step
             * Console.WriteLine(name + " with a sales tax of " + salesTax.ToString("P") +
                              " you will pay " + taxTotal.ToString("C2") +
                              " in tax making your grand total to be " + totalAmount.ToString("C"));*/
            Console.ReadKey();//Stopping point so the application doesn't close
        }
    }
}
