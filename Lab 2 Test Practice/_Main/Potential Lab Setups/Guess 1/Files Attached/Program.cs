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

            // Variables to determine net sales
            double netSalesWrite;
            double netSalesRead;
            string cashOrCredit;

            //Set file name
            string Filename = "CashPurchases.txt";

            // Create new object using template
            Console.WriteLine("Are you buying on 'cash' or 'credit'? (please type the corresponding code)");
            cashOrCredit = Console.ReadLine();

            // If-else statement for cash or credit purchase
            if (cashOrCredit == "cash")
            {
                CashPurchase purch = new CashPurchase();



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
                purch.SupplierCode = Console.ReadLine();

                while (purch.SupplierCode != "END")
                {
                    //Console.WriteLine("Enter Supplier Code: ");
                    //purch.SupplierCode = Console.ReadLine();
                    Console.WriteLine("Enter Item Code: ");
                    purch.ItemCode = Console.ReadLine();

                    //read double
                    try
                    {
                        Console.WriteLine("Enter Cost Per Unit: ");
                        purch.CostPerUnit = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Enter Quantity: ");
                        purch.Quantity = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Enter Discount (eg 0.1 for 10%): ");
                        purch.Discount = Convert.ToDouble(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Check Values, Numeric Values only for Cost Per Unit and Quantity");
                        Console.ReadLine();
                        Environment.Exit(0);
                    }

                    //Calculate cost
                    netSalesWrite = purch.calculateCost();

                    //write to file
                    writer.WriteLine(purch.SupplierCode + delim + purch.ItemCode + delim + purch.CostPerUnit + delim + purch.Quantity + delim + purch.Discount + delim + netSalesWrite);

                    // Closure of program
                    Console.WriteLine("Enter Another Supplier Code or END to quit: ");
                    purch.SupplierCode = Console.ReadLine();
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

                while (input != null)
                {
                    input = reader.ReadLine();
                    while (input != null)
                    {
                        fields = input.Split(delim);
                        purch.SupplierCode = fields[0];
                        purch.ItemCode = fields[1];
                        purch.CostPerUnit = Convert.ToDouble(fields[2]);
                        purch.Quantity = Convert.ToDouble(fields[3]);
                        purch.Discount = Convert.ToDouble(fields[4]);
                        netSalesRead = Convert.ToDouble(fields[5]);


                        // Display on console
                        Console.WriteLine("Supplier Code: " + purch.SupplierCode);
                        Console.WriteLine("Item Code:" + purch.ItemCode);
                        Console.WriteLine("Cost per Unit: $" + purch.CostPerUnit);
                        Console.WriteLine("Quantity:" + purch.Quantity);
                        Console.WriteLine("Discount:" + purch.Discount);
                        //write total sales
                        Console.WriteLine("Sales Total: $" + netSalesRead);
                        input = reader.ReadLine();
                    }
                }
                reader.Close();
                inFile.Close();

                Console.ReadLine();
            }







            

            else if (cashOrCredit == "credit")
            {
                CreditPurchase purch = new CreditPurchase();

                /*===========================
                 * 
                 * Create file
                 * 
                 * =========================*/

                //Create File
                FileStream outFile = new FileStream(Filename, FileMode.Create, FileAccess.ReadWrite);
                StreamWriter writer = new StreamWriter(outFile);
                Console.WriteLine("Credit Purchase transaction");
                Console.WriteLine("Enter Supplier Code or END to quit: ");
                purch.SupplierCode = Console.ReadLine();

                while (purch.SupplierCode != "END")
                {
                    //Console.WriteLine("Enter Supplier Code: ");
                    //purch.SupplierCode = Console.ReadLine();
                    Console.WriteLine("Enter Item Code: ");
                    purch.ItemCode = Console.ReadLine();

                    //read double
                    try
                    {
                        Console.WriteLine("Enter Cost Per Unit: ");
                        purch.CostPerUnit = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Enter Quantity: ");
                        purch.Quantity = Convert.ToDouble(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Check Values, Numeric Values only for Cost Per Unit and Quantity");
                        Console.ReadLine();
                        Environment.Exit(0);
                    }

                    //Calculate cost
                    netSalesWrite = purch.calculateCost();

                    //write to file
                    writer.WriteLine(purch.SupplierCode + delim + purch.ItemCode + delim + purch.CostPerUnit + delim + purch.Quantity + delim + netSalesWrite);

                    // Closure of program
                    Console.WriteLine("Enter Another Supplier Code or END to quit: ");
                    purch.SupplierCode = Console.ReadLine();
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

                while (input != null)
                {
                    input = reader.ReadLine();
                    while (input != null)
                    {
                        fields = input.Split(delim);
                        purch.SupplierCode = fields[0];
                        purch.ItemCode = fields[1];
                        purch.CostPerUnit = Convert.ToDouble(fields[2]);
                        purch.Quantity = Convert.ToDouble(fields[3]);
                        netSalesRead = Convert.ToDouble(fields[4]);


                        // Display on console
                        Console.WriteLine("Supplier Code: " + purch.SupplierCode);
                        Console.WriteLine("Item Code:" + purch.ItemCode);
                        Console.WriteLine("Cost per Unit: $" + purch.CostPerUnit);
                        Console.WriteLine("Quantity:" + purch.Quantity);
                        //write total sales
                        Console.WriteLine("Sales Total: $" + netSalesRead);
                        input = reader.ReadLine();
                    }
                }
                reader.Close();
                inFile.Close();

                Console.ReadLine();
            }



        }
    }
}