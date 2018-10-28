using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BentleyLabTest2Alt
{
    [Serializable]
    class CreditPurchase: Purchase
    {
        private double creditCharge;

        public CreditPurchase(string scode, string icode, double q, double cp, double cc)
            : base(scode, icode, q, cp)
        {
            creditCharge = cc;
        }

        public CreditPurchase()
            : base()
        { }

        public double CreditCharge
        {
            get
            {
                return creditCharge;
            }
            set
            {
                creditCharge = value;
            }
        }

        public override double calculateCost()
        {
            return (Quantity * CostPerUnit) + creditCharge;
        }

        public override string ToString()
        {
            return string.Format("{0}: {1} \n{2}: {3}\n{4}: {5}\n{6}: {7} {8}", "Supplier Code:", SupplierCode,
              "Item Code", ItemCode, "Quantity", Quantity, "Cost Per Unit", CostPerUnit, CreditCharge);
        }

    }
}
