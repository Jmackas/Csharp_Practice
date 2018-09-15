using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Query_Array
{
    // Linq Samples https://code.msdn.microsoft.com/101-LINQ-Samples-3fb9811b

    class Program
    {
        static void Main(string[] args)
        {
            // Creation of objects added to an array
            var invoices = new[]
            {
                new Invoice(83,"Electric sander", 7, 57.98m),
                new Invoice(24, "Power saw", 18, 99.99m),
                new Invoice(7, "Sledge hammer", 11, 21.50m),
                new Invoice(77, "Hammer", 76, 11.99m),
                new Invoice(39, "Lawn mower", 3, 79.50m),
                new Invoice(68, "Screwdriver", 106, 6.99m),
                new Invoice(56, "Jig saw", 21, 11m),
                new Invoice(3, "Wrench", 34, 7.50m),
            };

            // Display all elements
            Console.WriteLine("Original Invoice Details:");
            foreach (var element in invoices) 
            {
                Console.WriteLine(element);
               
            }

            // Line space
            Console.WriteLine("");

            /*
             * Sort by Part Description Ascending
             */
            // LINQ Query
            var descSorted =
                from e in invoices
                orderby e.PartDescription
                select e;

            // Display results
            Console.WriteLine("Sort by Part Description ascending");
            foreach (var element in descSorted)
            {
                Console.WriteLine(element);
            }

            // Line space
            Console.WriteLine("");

            /*
             * Sort the array by price
             */
             // LINQ Query
            var priceSorted =
                from e in invoices
                orderby e.Price
                select e;

            // Display results
            Console.WriteLine("Sort by Price ascending");
            foreach (var element in priceSorted)
            {
                Console.WriteLine(element);
            }

            // Line space
            Console.WriteLine("");

            /*
             * Select Part Description and Quantity, and sort results by quantity
             */
            // LINQ Query
            var quantitySelected =
                from e in invoices
                orderby e.Quantity
                select new { e.Quantity, e.PartDescription };

            // Display results
            Console.WriteLine("Sort Part Description and Quantity by Quantity");
            foreach (var element in quantitySelected)
            {
                Console.WriteLine(element);
            }

            // Line space
            Console.WriteLine("");

            /*
             * Finds the value of invoices from Part Description. Calculated to Invoice Total.
             */


            // LINQ Query
            var totalInvoice =
                from e in invoices
                let invoiceTotal = e.Quantity * e.Price
                select new { e.Quantity, e.PartDescription, invoiceTotal };

            // Display results
            Console.WriteLine("Total Invoice Calculation");
            foreach (var element in totalInvoice)
            {
                Console.WriteLine(element);
            }

            /*
            * Select Part Description and Quantity, and sort results by quantity
            */
            // LINQ Query
            var invoiceTotalRange =
                from e in totalInvoice
                //
                select totalInvoice;

            // Display results
            Console.WriteLine("Display range of InvoiceTotals between $200 and $500");
            foreach (var element in invoiceTotalRange)
            {
                Console.WriteLine(element);
                
            }

            // Line space
            Console.WriteLine("");


            Console.ReadLine();
        }
    }
}
