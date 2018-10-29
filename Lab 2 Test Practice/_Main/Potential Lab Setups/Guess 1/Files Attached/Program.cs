using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using static System.Net.Mime.MediaTypeNames;

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
            double netCreditWrite;
            double netCreditRead;
            string cashOrCredit;
            double creditCharge;

            // Create new object using template
            Console.WriteLine("Are you buying on 'cash' or 'credit'? (please type the corresponding code)");
            cashOrCredit = Console.ReadLine();

            /*==============================
             * 
             * Cash Purchase
             * 
             * =============================*/

            // If-else statement for cash or credit purchase
            if (cashOrCredit == "cash")
            {
                //Set file name
                string Filename = "CashPurchases.txt";

                CashPurchase cashPurch = new CashPurchase();



                /*========== Create file ==========*/
                //Create File
                FileStream outFile = new FileStream(Filename, FileMode.Create, FileAccess.ReadWrite);
                StreamWriter writer = new StreamWriter(outFile);
                Console.WriteLine("Cash Purchase transaction");
                Console.WriteLine("Enter Supplier Code or END to quit: ");
                cashPurch.SupplierCode = Console.ReadLine();

                while (cashPurch.SupplierCode != "END")
                {
                    //Console.WriteLine("Enter Supplier Code: ");
                    //purch.SupplierCode = Console.ReadLine();
                    Console.WriteLine("Enter Item Code: ");
                    cashPurch.ItemCode = Console.ReadLine();

                    //read double
                    try
                    {
                        Console.WriteLine("Enter Cost Per Unit: ");
                        cashPurch.CostPerUnit = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Enter Quantity: ");
                        cashPurch.Quantity = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Enter Discount (eg 0.1 for 10%): ");
                        cashPurch.Discount = Convert.ToDouble(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Check Values, Numeric Values only for Cost Per Unit and Quantity");
                        Console.ReadLine();
                        Environment.Exit(0);
                    }

                    //Calculate cost
                    netSalesWrite = cashPurch.calculateCost();

                    //write to file
                    writer.WriteLine(cashPurch.SupplierCode + delim + cashPurch.ItemCode + delim + cashPurch.CostPerUnit + delim + cashPurch.Quantity + delim + cashPurch.Discount + delim + netSalesWrite);

                    // Closure of program
                    Console.WriteLine("Enter Another Supplier Code or END to quit: ");
                    cashPurch.SupplierCode = Console.ReadLine();
                }

                writer.Close();
                outFile.Close();



                /*========== Read from file ==========*/
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
                        cashPurch.SupplierCode = fields[0];
                        cashPurch.ItemCode = fields[1];
                        cashPurch.CostPerUnit = Convert.ToDouble(fields[2]);
                        cashPurch.Quantity = Convert.ToDouble(fields[3]);
                        cashPurch.Discount = Convert.ToDouble(fields[4]);
                        netSalesRead = Convert.ToDouble(fields[5]);


                        // Display on console
                        Console.WriteLine("Supplier Code: " + cashPurch.SupplierCode);
                        Console.WriteLine("Item Code:" + cashPurch.ItemCode);
                        Console.WriteLine("Cost per Unit: $" + cashPurch.CostPerUnit);
                        Console.WriteLine("Quantity:" + cashPurch.Quantity);
                        Console.WriteLine("Discount:" + cashPurch.Discount);
                        //write total sales
                        Console.WriteLine("Sales Total: $" + netSalesRead);
                        input = reader.ReadLine();
                    }
                }
                reader.Close();
                inFile.Close();

                Console.ReadLine();
            }








            /*==============================
             * 
             * Credit Purchase
             * 
             * =============================*/
            else if (cashOrCredit == "credit")
            {

                //Set file name
                string Filename = "CreditPurchases.txt";

                CreditPurchase creditPurch = new CreditPurchase();

                /*========== Create file ==========*/
                //Create File
                FileStream outFile = new FileStream(Filename, FileMode.Create, FileAccess.ReadWrite);
                StreamWriter writer = new StreamWriter(outFile);
                Console.WriteLine("Credit Purchase transaction");
                Console.WriteLine("Enter Supplier Code or END to quit: ");
                creditPurch.SupplierCode = Console.ReadLine();

                while (creditPurch.SupplierCode != "END")
                {
                    //Console.WriteLine("Enter Supplier Code: ");
                    //purch.SupplierCode = Console.ReadLine();
                    Console.WriteLine("Enter Item Code: ");
                    creditPurch.ItemCode = Console.ReadLine();

                    //read double
                    try
                    {
                        Console.WriteLine("Enter Cost Per Unit: ");
                        creditPurch.CostPerUnit = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Enter Quantity: ");
                        creditPurch.Quantity = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Enter Credit Charge (eg 0.1 for 10%): ");
                        creditPurch.CreditCharge = Convert.ToDouble(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Check Values, Numeric Values only for Cost Per Unit and Quantity");
                        Console.ReadLine();
                        Environment.Exit(0);
                    }

                    //Calculate cost
                    creditCharge = creditPurch.calculateCostofCharges();
                    netCreditWrite = creditPurch.calculateCost() ;

                    //write to file
                    writer.WriteLine(creditPurch.SupplierCode + delim + creditPurch.ItemCode + delim + creditPurch.CostPerUnit + delim + creditPurch.Quantity + delim + netCreditWrite);

                    // Closure of program
                    Console.WriteLine("Enter Another Supplier Code or END to quit: ");
                    creditPurch.SupplierCode = Console.ReadLine();
                }

                writer.Close();
                outFile.Close();


                /*========== Read from file ==========*/
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
                        creditPurch.SupplierCode = fields[0];
                        creditPurch.ItemCode = fields[1];
                        creditPurch.CostPerUnit = Convert.ToDouble(fields[2]);
                        creditPurch.Quantity = Convert.ToDouble(fields[3]);
                        netCreditRead = Convert.ToDouble(fields[4]);


                        // Display on console
                        Console.WriteLine("Supplier Code: " + creditPurch.SupplierCode);
                        Console.WriteLine("Item Code:" + creditPurch.ItemCode);
                        Console.WriteLine("Cost per Unit: $" + creditPurch.CostPerUnit);
                        Console.WriteLine("Quantity:" + creditPurch.Quantity);
                        //write total sales
                        Console.WriteLine("Sales Total: $" + netCreditRead);
                        input = reader.ReadLine();
                    }
                }
                reader.Close();
                inFile.Close();

                Console.ReadLine();
            }

            else
            {
                // Notice for people trying to enter something different
                Console.WriteLine("You can only enter either 'cash' or 'credit'.");
            }

        }
    }
}