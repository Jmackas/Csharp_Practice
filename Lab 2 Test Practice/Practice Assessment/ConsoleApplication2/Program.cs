using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;


namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //writing to a binary file
            const string FILENAME = "Data.dat";
            Employee emp = new Employee();
            FileStream outFile = new FileStream(FILENAME,
               FileMode.Create, FileAccess.Write);
            BinaryFormatter bFormatter = new BinaryFormatter();
            Console.WriteLine("Enter employee last name or END to quit ");
            emp.LName = Console.ReadLine();
            while (emp.LName != "END")
            {
                Console.WriteLine("Enter first name ");
                emp.FName = Console.ReadLine();
                Console.WriteLine("Enter employee ID ");
                emp.EmpID = Console.ReadLine();
                bFormatter.Serialize(outFile, emp);
                Console.Write("Enter employee last name or END to quit ");
                emp.LName = Console.ReadLine();
            }
            outFile.Close();

            //reading from a binary file

            FileStream inFile = new FileStream(FILENAME,
               FileMode.Open, FileAccess.Read);
            Console.WriteLine("\n{0,-15}{1,-12}{2,8}\n","LastName", "First Name", "EmployeeID");

            while (inFile.Position < inFile.Length)
            {
                emp = (Employee)bFormatter.Deserialize(inFile);
                Console.WriteLine(emp);
            }
            inFile.Close();
            Console.ReadLine();
        }
    }
}
