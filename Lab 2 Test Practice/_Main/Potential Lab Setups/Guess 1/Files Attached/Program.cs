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
            double saleTotal = 0;
            double saleRead = 0;
            //double discountRate = 0;

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
                //Console.WriteLine("Enter Supplier Code: ");
                //pur.SupplierCode = Console.ReadLine();
                Console.WriteLine("Enter Item Code: ");
                pur.ItemCode = Console.ReadLine();

                //read double
                try
                {
                    Console.WriteLine("Enter Cost Per Unit: ");
                    pur.CostPerUnit = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter Quantity: ");
                    pur.Quantity = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter Cash Discount: ");
                    pur.Discount = Convert.ToDouble(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Check Values, Numeric Values only for Cost Per Unit and Quantity");
                    Console.ReadLine();
                    Environment.Exit(0);
                }
                //Calculate Discount
                // discountRate = pur.Discount * 100;
                //Calculate Cost
                saleTotal = pur.calculateCost();
                //write to file
                writer.WriteLine(pur.SupplierCode + delim + pur.ItemCode + delim + pur.CostPerUnit + delim + pur.Quantity + delim + pur.Discount + delim + saleTotal);
                Console.WriteLine("Enter Another Supplier Code or END to quit: ");
                pur.SupplierCode = Console.ReadLine();
            }

            writer.Close();
            outFile.Close();













            /*===========================
             * 
             * Read from file
             * 
             * =========================*/
            //Reading File and show on console
            Console.WriteLine("Reading from file");

            FileStream inFile = new FileStream(Filename, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(inFile);
            string input = "";
            string[] fields;

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
                    saleRead = Convert.ToDouble(fields[5]);
                    
                    
                    //write objects to console
                    Console.WriteLine("Supplier Code: " + pur.SupplierCode);
                    Console.WriteLine("Item Code: $" + pur.ItemCode);
                    Console.WriteLine("Cost per Unit: $" + pur.CostPerUnit);
                    Console.WriteLine("Quantity: $" + pur.Quantity);
                    Console.WriteLine("Cash Sale Discount: $" + pur.Discount);
                    //write total sales
                    Console.WriteLine("Sales Total: $" + saleRead);
                    input = reader.ReadLine();
                }
            }
            reader.Close();
            inFile.Close();

            Console.ReadLine();


        }
    }
}