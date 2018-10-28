using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BentleyLabTest2Alt
{
    class Program
    {
        static void Main(string[] args)
        {
            Purchase purchase = new Purchase("test", "esketit", -2.0, -8);

            Console.WriteLine(purchase.Quantity);
            Console.WriteLine(purchase.CostPerUnit);
            Console.WriteLine(purchase.SupplierCode);
            Console.WriteLine(purchase.ItemCode);

            Console.WriteLine(purchase.calculateCost());

        }
    }
}
