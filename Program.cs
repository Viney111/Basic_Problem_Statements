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
            //TO CHECK NUMBER IS PRIME OR NOT !
            Console.Write("Enter a number to check if it is prime or not: ");
            int primeNoToBeChecked = Convert.ToInt32(Console.ReadLine());
            //Callng checkPrime method
            checkPrime(primeNoToBeChecked);
        }
        static void checkPrime(int Number)
        {
            if (Number > 0)
            {
                if (Number != 2)
                {
                    int flag = 0;
                    for (int i = 2; i < Number; i++)
                    {
                        if (Number % i == 0)
                        {
                            Console.WriteLine($"{Number} is not a prime number");
                            flag = 1;
                            break;
                        }
                    }
                    if (flag == 0)
                    {
                        Console.WriteLine($"{Number} is a prime number");
                    }
                }
                else
                    Console.WriteLine($"{Number} is a prime number");
            }
            else
                Console.WriteLine($"{Number} is a neagtive integer");
        }

    }
}
