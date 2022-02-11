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
            //TO CHECK NUMBER IS ODD OR EVEN 
            Console.Write("Enter a number to check odd or even: ");
            int oddEvenToBeChecked = Convert.ToInt32(Console.ReadLine());
            //Calling method to check odd even number.
            checkEvenOdd(oddEvenToBeChecked);
        }
        static void checkEvenOdd(int Number)
        {
            if (Number > 0)
            {
                if (Number % 2 != 0)
                {
                    Console.WriteLine($"{Number} is odd");
                }
                else
                {
                    Console.WriteLine($"{Number} is even");
                }
            }
            else
            {
                Console.WriteLine("Please enter positive number");
            }
        }

    }
}
