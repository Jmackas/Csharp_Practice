using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DieRoll
{
    class Program
    {
        static void Main(string[] args)
        {
            // Invocation of random math class
            var rnd = new Random();

            // Array of frequency counters
            var dieRollOne = new int[7];
            var dieRollTwo = new int[7];

            // Roll die 36,000 times 
            for (int roll = 1; roll <= 36000; ++roll)
            {
                // Get a random value for the 6 items in the array
                for (int numInc = 1; numInc <= 6; numInc++)
                {
                    dieRollOne[numInc] = rnd.Next(1, 7);
                    dieRollTwo[numInc] = rnd.Next(1, 7);
                }
            }

            // Declaration of new arrays
            var outputOne = new int[7];
            var outputTwo = new int[7];
            var outputThree = new int[7];
            var outputFour = new int[7];
            var outputFive = new int[7];
            var outputSix = new int[7];

            // Add the arrays together
            for (int numInc = 1; numInc <= 6; numInc++)
            {
                outputOne[numInc] = dieRollOne[1] + dieRollTwo[numInc];
                outputTwo[numInc] = dieRollOne[2] + dieRollTwo[numInc];
                outputThree[numInc] = dieRollOne[3] + dieRollTwo[numInc];
                outputFour[numInc] = dieRollOne[4] + dieRollTwo[numInc];
                outputFive[numInc] = dieRollOne[5] + dieRollTwo[numInc];
                outputSix[numInc] = dieRollOne[6] + dieRollTwo[numInc];
            }

            /* Outputting to the matrix */

            // Numbers at the top 
            Console.WriteLine("  1 2 3 4 5 6");

            Console.Write("1 ");

            for (var face = 1; face < outputOne.Length; ++face)
            { 
                Console.Write(outputOne[face] + " ");

            }

            // Add line space
            Console.WriteLine("");

            Console.Write("2 ");

            for (var face = 1; face < outputTwo.Length; ++face)
            {
                Console.Write(outputTwo[face] + " ");

            }

            // Add line space
            Console.WriteLine("");

            Console.Write("3 ");

            for (var face = 1; face < outputThree.Length; ++face)
            {
                Console.Write(outputThree[face] + " ");

            }

            // Add line space
            Console.WriteLine("");

            Console.Write("4 ");

            for (var face = 1; face < outputFour.Length; ++face)
            {
                Console.Write(outputFour[face] + " ");

            }

            // Add line space
            Console.WriteLine("");

            Console.Write("5 ");

            for (var face = 1; face < outputFive.Length; ++face)
            {
                Console.Write(outputFive[face] + " ");

            }

            // Add line space
            Console.WriteLine("");

            Console.Write("6 ");

            for (var face = 1; face < outputSix.Length; ++face)
            {
                Console.Write(outputSix[face] + " ");

            }

            Console.ReadLine();

        }
    }
}
