// Generic array variable is "arrayVar" for these examples.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Friend
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Array General
             */

            // Array declaration
            int[] arrayVar;

            // Assigning values to an array + declaration
            int[] arrayVar = { 1, 2, 3, 4, 5 };

            // Determining array length
            int arrayVar = numbers.Length;

            // Assigning variables to an array
            int [] arrayVar = {99, 28, 22, 4};
		
            // Accessing items of an array and displaying them
            foreach (int i in arrayVar)
            {
                System.Console.Write(i + " ");
            }

            /*
            Arrays and classes
             */
            // Initiation of an object within an array
            object[] arrayVar = new object[5]{1,1.1111,"Sharad",'c',2.79769313486232};
            
            // Accessing items of an array and displaying them
            foreach (int i in arrayVar)
            {
                System.Console.Write(i + " ");
            }



        }


    }
}



