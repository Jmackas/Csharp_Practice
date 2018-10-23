using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Write_a_Text_File
{
    class Program
    {
        static void Main(string[] args)
        {

            /*========================
            * 
            * Write an array of strings to a file.
            * 
            * ======================*/
            // Create a string array that consists of three lines.
            string[] lines = { "First line", "Second line", "Third line" };

            // WriteAllLines creates a file, writes a collection of strings to the file,
            // and then closes the file.  You do NOT need to call Flush() or Close().
            System.IO.File.WriteAllLines(@"C:\Users\James\Documents\Github\Csharp_Practice\Lab 2 Test Practice\File Read and Write\Write to a Text File\file.txt", lines);





            /*========================
           * 
           * Write a string to a text file
           * 
           * ======================*/
            // Example #2: Write one string to a text file.
            string text = "A class is the most powerful data type in C#. Like a structure, " +
                           "a class defines the data and behavior of the data type. ";

            // WriteAllText creates a file, writes the specified string to the file,
            // and then closes the file.    You do NOT need to call Flush() or Close().
            System.IO.File.WriteAllText(@"C:\Users\James\Documents\Github\Csharp_Practice\Lab 2 Test Practice\File Read and Write\Write to a Text File\file.txt", text);




            /*========================
           * 
           * Write only some strings in an array to a file.
           * 
           * ======================*/
            // The using statement automatically flushes AND CLOSES the stream and calls 
            // IDisposable.Dispose on the stream object.
            // NOTE: do not use FileStream for text files because it writes bytes, but StreamWriter

            // encodes the output as text.
            using (System.IO.StreamWriter file =
                new System.IO.StreamWriter(@"C:\Users\James\Documents\Github\Csharp_Practice\Lab 2 Test Practice\File Read and Write\Write to a Text File\file.txt"))
            {
                foreach (string line in lines)
                {
                    // If the line doesn't contain the word 'Second', write the line to the file.
                    if (!line.Contains("Second"))
                    {
                        file.WriteLine(line);
                    }
                }
            }





            /*========================
           * 
           * Append new text to an existing file.
           * 
           * ======================*/
            // The using statement automatically flushes AND CLOSES the stream and calls 
            // IDisposable.Dispose on the stream object.
            using (System.IO.StreamWriter file =
                new System.IO.StreamWriter(@"C:\Users\James\Documents\Github\Csharp_Practice\Lab 2 Test Practice\File Read and Write\Write to a Text File\file.txt", true))
            {
                file.WriteLine("Fourth line");
            }
        }
    }
}
