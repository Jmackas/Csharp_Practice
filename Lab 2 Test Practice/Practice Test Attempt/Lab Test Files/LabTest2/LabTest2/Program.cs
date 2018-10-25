using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTest2
{
    class Program
    {
        static void Main(string[] args)
        {




            /*========== Question 1 ==========*/
            // Read each element into an array called "lines"
            string[] purchasesArray = System.IO.File.ReadAllLines(@"purchases.txt");

            /*========== Question 2 ==========*/
            // Display the file contents by using a foreach loop.
            System.Console.Write("Contents of WriteLines2.txt = ");
            foreach (string line in purchasesArray)
            {
                // Use a tab to indent each line of the file.
                Console.WriteLine("\t" + line);
            }

            /*========== Question 3 ==========*/
            // WriteAllLines creates a file, writes a collection of strings to the file,
            // and then closes the file.  You do NOT need to call Flush() or Close().
            System.IO.File.WriteAllLines(@"purchasesoutput.dat", purchasesArray);

        }
    }
}
