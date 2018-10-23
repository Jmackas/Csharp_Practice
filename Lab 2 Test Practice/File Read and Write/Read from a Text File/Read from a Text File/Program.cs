using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Read_from_a_Text_File
{
    class Program
    {
        static void Main(string[] args)
        {
            /*========================
             * 
             * Read each element
             * 
             * ======================*/
            // Read the file as one string.
            string text = System.IO.File.ReadAllText(@"C:\Users\James\Documents\Github\Csharp_Practice\Lab 2 Test Practice\File Read and Write\Read from a Text File\file.txt");

            // Display the file contents to the console. Variable text is a string.
            System.Console.WriteLine("Contents of WriteText.txt = {0}", text);



            Console.WriteLine("/*============================*/");



            /*========================
             * 
             * Read each element to an array
             * 
             * ======================*/

            // Read each element into an array called "lines"
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\James\Documents\Github\Csharp_Practice\Lab 2 Test Practice\File Read and Write\Read from a Text File\file.txt");

            // Display the file contents by using a foreach loop.
            System.Console.Write("Contents of WriteLines2.txt = ");
            foreach (string line in lines)
            {
                // Use a tab to indent each line of the file.
                Console.Write("\t" + line);
            }
        }
    }
}
