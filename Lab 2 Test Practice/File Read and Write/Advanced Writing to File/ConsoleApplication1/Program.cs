using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            //writing to the file ; default location used
            char delim = ',';

            // String used
            string FileName = "Employee.txt";

            // Creation of new employee object
            Employee emp = new Employee();

            // Invocation of file reader
            FileStream outFile = new FileStream(FileName, FileMode.Create, FileAccess.ReadWrite);
            StreamWriter writer = new StreamWriter(outFile);

            // Reading items from 
            Console.WriteLine("Enter Employee  Last Name or END to quit");
            emp.LName = Console.ReadLine();

            while (emp.LName != "END")
            {
                Console.WriteLine("Enter first name ");
                emp.FName = Console.ReadLine();
                Console.WriteLine("Enter Employee ID ");
                emp.EmpID = Console.ReadLine();
                writer.WriteLine(emp.LName + delim + emp.FName + delim + emp.EmpID);
                Console.WriteLine("Enter next employee last name or END to quit ");
                emp.LName = Console.ReadLine();
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
                    emp.FName = fields[0];
                    emp.LName = fields[1];
                    emp.EmpID = fields[2];
                    Console.WriteLine(emp);
                    input = reader.ReadLine();
                }
               
            }
            reader.Close();  // Error occurs if
            inFile.Close(); //these two statements are reversed

            Console.ReadLine();
        }
    }
}
