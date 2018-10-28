using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BentleyLabTest2Alt
{
    [Serializable]
    class CashPurchase : Purchase
    {

        private double discount { get; set; } // discount for cash purchase
                                              // constructor initializes data members
        public CashPurchase(string scode, string icode, double q, double cp, double dis)
                            : base(scode, icode, q, cp)
        {
            discount = dis;
        }

        public CashPurchase() : base()
        { }
        //Discount property
        public double Discount
        {
            get
            {
                return discount;
            } // end get
            set
            {
                if (value >= 0.0)
                    discount = value;
                else
                    throw new ArgumentOutOfRangeException("Discount", value, "Discount must be >= 0");

            } // end set
        } // end property

        public override double calculateCost()
        {
            double cost = base.calculateCost();
            double netCost = cost - cost * Discount;
            return netCost;
        } // end function calculateCost

        public override string ToString()
        {
            return string.Format("Purchase {0} {1} \n{2:C}", base.ToString(), "Discount", Discount.ToString(), "Cost", calculateCost().ToString());
        }


    }
}
