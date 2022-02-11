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
            //TO GET THE RANGE OF PRIME NUMBER !
            Console.Write("Enter a number to find prime number range: ");
            int primeNumberRange = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(primeNoRange(primeNumberRange));
        }
        public static string primeNoRange(int Number)
        {
            int i = 2;
            string primeNumber = "";
            int flag = 0;
            while (i < Number)
            {
                int n = 2;
                while (n < i)
                {
                    if (i % n == 0)
                    {
                        flag = 1;
                        break;
                    }
                    else
                    {
                        flag = 0;
                    }
                    n++;
                }
                if (flag == 0)
                {
                    primeNumber = primeNumber + " " + Convert.ToString(i);
                }
                i++;
            }

            return primeNumber;
        }
    }
}
