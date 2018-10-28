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
            //Varible for total purchase
            double totalCashPurchases = 0;
            double totalCreditPurchase = 0;
            double discountRate = 0;

            //create object for CashPurchase
            CashPurchase cp = new CashPurchase("Tech365", "MSC-001", 5, 20, 0.1);
            //calc discount
            discountRate = cp.Discount * 100;
            // display purchase discount
            Console.WriteLine("Cash Purchase discount is {0:C}", discountRate);
            //cacl cost
            totalCashPurchases = cp.calculateCost();
            Console.WriteLine("Total Cash Purchase: {0:C}", totalCashPurchases);

            //create object for CreditPurchase
            CreditPurchase ap = new CreditPurchase("Tech365", "KB-001", 3, 30, 2.5);
            //display Credit Charge
            Console.WriteLine("Credit Purcahse Surcharge {0:C}", ap.CreditCharge);
            //calc cost
            totalCreditPurchase = ap.calculateCost();
            //display Credit purchase
            Console.WriteLine("Credit Purchase total {0:C}", totalCreditPurchase);

            //Hold
            Console.ReadLine();

        }

    }
}
