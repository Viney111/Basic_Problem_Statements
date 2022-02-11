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
            //TO CHECK TWO NUMBERS ARE PALLINDROME OR NOT !
            Console.WriteLine("Enter two numbers to check if they are palindrome or not");
            Console.Write("Enter first number= ");
            int palNumber1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number= ");
            int palNumber2 = Convert.ToInt32(Console.ReadLine());

            checkNumberPallindrome(palNumber1, palNumber2);
        }
        static void checkNumberPallindrome(int num1, int num2)
        {
            string rem1 = "";
            while (num1 > 0)
            {
                int rem = num1 % 10;
                rem1 = rem1 + Convert.ToString(rem);
                num1 /= 10;
            }
            if (Convert.ToInt32(rem1) == num2)
            {
                Console.WriteLine("Two numbers are pallindrome");
            }
            else
            {
                Console.WriteLine("Two numbers are not pallindrome");
            }

        }
    }
}
