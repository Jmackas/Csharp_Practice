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
            string line;
            List Purchase = new List();

            // Read the file and display it line by line.
            System.IO.StreamReader file =
                new System.IO.StreamReader(@"file.txt");
            while ((line = file.ReadLine()) != null)
            {
                string[] words = line.Split(',');
                listOfPersons.Add(new Purchase(words[0], words[1], words[2], words[3]));
            }


        }
    }
}
