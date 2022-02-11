using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic
{
    internal class ProblemStatements
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the solutions of basic MATHEMATICAL PROBLEM STATEMENTS");
            //TO GET THE FACTORIAL OF NUMBER !
            Console.Write("Enter a number to get factorial: ");
            int factoialOfNumber = Convert.ToInt32(Console.ReadLine());
            // Calling method to check Factorial of a number.
            getfactorial(factoialOfNumber);
        }
        static void getfactorial(int Number)
        {
            //VARIABLES
            int i = Number;
            double factorialResult = 1;

            while (i > 0)
            {
                factorialResult = (double)i * factorialResult;
                i--;
            }
            Console.WriteLine($"The factorial of {Number} is {factorialResult}");

        }
    }
}
