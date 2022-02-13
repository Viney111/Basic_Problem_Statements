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
            //CONSTANTS
            const int NUMBEROFDIEROLL = 40;

            //VARIABLES
            int dieRoll = 1;

            IDictionary<int,int> valuesOfDie = new Dictionary<int,int>();
            while (dieRoll <= NUMBEROFDIEROLL)
            {
                //VARIABLES
                Random random = new Random();
                int dieNumber = random.Next(1, 7);
                valuesOfDie[dieRoll] = dieNumber;
                //Console.WriteLine($"The die number is {dieNumber}");
            dieRoll++;
            }
            foreach (KeyValuePair<int,int> entry in valuesOfDie)
            {
                Console.WriteLine(entry.Key +" : " +entry.Value);
            }
        }

    }
}
