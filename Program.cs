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
            //TO GET THE PRIME FACTORS OF A NUMBER !
            Console.Write("Enter a number to get prime factors: ");
            int primeFactorNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(PrimeFactors(primeFactorNumber));
        }
        public static string PrimeFactors(int Number)
        {
            int i = 2;
            string rv = "";

            while (i < Number)
            {
                if (Number % i == 0)
                {
                    int n = 2;
                    int flag = 0;
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
                        rv = $"{Convert.ToString(i)} {rv}";
                    }
                }
                i++;
            }
            return rv;
        }
    }
}
