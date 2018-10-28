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
            //"CashPurchase"Writing Contents to file / default location

            char delim = ',';
            double saleTotal;

            //Set file name
            string Filename = "CashPurchases.txt";

            // Create new object using template
            CashPurchase pur = new CashPurchase();

            /*===========================
            * 
            * Create file
            * 
            * =========================*/

            //Create File
            FileStream outFile = new FileStream(Filename, FileMode.Create, FileAccess.ReadWrite);
            StreamWriter writer = new StreamWriter(outFile);
            Console.WriteLine("Cash Purchase transaction");
            Console.WriteLine("Enter Supplier Code or END to quit: ");
            pur.SupplierCode = Console.ReadLine();

            while (pur.SupplierCode != "END")
            {
                // For all string inputs
                Console.WriteLine("Enter Supplier Code: ");
                pur.SupplierCode = Console.ReadLine();
                Console.WriteLine("Enter Item Code; ");
                pur.ItemCode = Console.ReadLine();

                // For all double inputs
                try
                {
                    Console.WriteLine("Enter Cost Per Unit: ");
                    pur.CostPerUnit = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter Quantity: ");
                    pur.Quantity = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter Cash Discount");
                    pur.Discount = Convert.ToDouble(Console.ReadLine());
                }

                // Validating the entered data
                catch
                {
                    Console.WriteLine("Please only enter numeric values.");
                    Console.ReadLine();
                    Environment.Exit(0);
                }

                saleTotal = pur.calculateCost();

                //write to file
                writer.WriteLine(pur.SupplierCode + delim + pur.ItemCode + delim + pur.CostPerUnit + delim + pur.Quantity + delim + pur.Discount + delim + saleTotal);
                Console.WriteLine("Enter Supplier Code or END to quit: ");
                pur.SupplierCode = Console.ReadLine();
            }

            writer.Close();
            outFile.Close();













           /*===========================
            * 
            * Read from file
            * 
            * =========================*/
            Console.WriteLine("Reading from file");

            FileStream inFile = new FileStream(Filename, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(inFile);
            string input = "";
            string[] fields;

            Console.WriteLine("\n{0,-30}{1,-20}{2,20}{3,30}{4,40}\n", "Supplier Code", "Item Code", "Item Cost Per Unit", "Item Quanitiy", "Sale total $");

            while (input != null)
            {
                input = reader.ReadLine();
                while (input != null)
                {
                    fields = input.Split(delim);
                    pur.SupplierCode = fields[0];
                    pur.ItemCode = fields[1];
                    pur.CostPerUnit = Convert.ToDouble(fields[2]);
                    pur.Quantity = Convert.ToDouble(fields[3]);
                    pur.Discount = Convert.ToDouble(fields[4]);
                    saleTotal = Convert.ToDouble(fields[5]);
                    Console.WriteLine(pur);
                    input = reader.ReadLine();
                }
            }
            reader.Close();
            inFile.Close();

            Console.ReadLine();
        }
    }
}
