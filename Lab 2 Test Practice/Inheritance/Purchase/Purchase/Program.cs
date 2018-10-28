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
            Purchase purchase = new Purchase("test", "esketit", 1.0, 8.9);

            Console.WriteLine(purchase.Quantity);
            Console.WriteLine(purchase.Quantity);
            Console.WriteLine(purchase.Quantity);
            Console.WriteLine(purchase.Quantity);

        }
    }
}
