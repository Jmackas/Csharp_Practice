using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LabTest2
{
    class Program
    {
        static void Main(string[] args)
        {

            /*=========================
             * 
             * Writing to the file
             * 
             * ======================*/

            //writing to the file ; default location used
            char delim = ',';

            // String used
            string FileName = "Employee.txt";

            // Creation of new employee object
            Purchase RandomPurchase = new Purchase();

            // Invocation of file reader
            FileStream outFile = new FileStream(FileName, FileMode.Create, FileAccess.ReadWrite);
            StreamWriter writer = new StreamWriter(outFile);

            // Reading items from 
            Console.WriteLine("Enter Employee  Last Name or END to quit");
            RandomPurchase.SupplierCode = Console.ReadLine();

            while (RandomPurchase.SupplierCode != "END")
            {
                Console.WriteLine("Enter first name ");
                RandomPurchase.ItemCode = Console.ReadLine();
                Console.WriteLine("Enter next employee last name or END to quit ");
                RandomPurchase.SupplierCode = Console.ReadLine();


                writer.WriteLine(RandomPurchase.SupplierCode + delim + RandomPurchase.ItemCode);
            }
            writer.Close();
            outFile.Close();
















            // Reading the previously created file
            Console.WriteLine("Reading from the file");

            FileStream inFile = new FileStream(FileName,
                     FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(inFile);
            string input = "";
            string[] fields;

            Console.WriteLine("\n{0,-15}{1,-12}{2,8}\n",
                    "LastName", "FirstName", "EmployeeID");

            while (input != null)
            {
                input = reader.ReadLine();
                while (input != null)
                {
                    fields = input.Split(delim);
                    RandomPurchase.SupplierCode = fields[0];
                    RandomPurchase.ItemCode = fields[1];
                    Console.WriteLine(RandomPurchase);
                    input = reader.ReadLine();
                }

            }
            reader.Close();  // Error occurs if
            inFile.Close(); //these two statements are reversed

            Console.ReadLine();
        }
    }
}
