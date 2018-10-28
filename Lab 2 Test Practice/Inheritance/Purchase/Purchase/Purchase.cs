using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BentleyLabTest2Alt
{
    [Serializable]
    class Purchase
    {

        // data members to store factory, item and the supplier's details
        public string SupplierCode { get; set; }
        public string ItemCode { get; set; }

        private double quantity; // quantity of material
        private double costPerUnit; // cost per unit of the material

        // constructor initializes data members
        public Purchase(string scode, string icode, double q, double cp)
        {
            SupplierCode = scode;
            ItemCode = icode;

            quantity = q;
            costPerUnit = cp;
        }


        public Purchase()
        { }

        public double Quantity
        {
            get
            {
                return quantity;
            } // end get
            set
            {
                if (value >= 0.0)
                    quantity = value;
                else
                    throw new ArgumentOutOfRangeException("Quantity", value, "Quantity must be >= 0");
            } // end set
        } // end property

        public double CostPerUnit
        {
            get
            {
                return costPerUnit;
            } // end get
            set
            {
                if (value >= 0)
                    costPerUnit = value;
                else throw new ArgumentOutOfRangeException("Cost Per Unit", value, "Cost per unit must be >= 0");
            } // end set
        } // end property

        public virtual double calculateCost()
        {
            return Quantity * CostPerUnit;
        }

        public override string ToString()
        {
            return string.Format("{0}: {1} \n{2}: {3}\n{4}: {5} {6} { 7} ", "Supplier Code:", SupplierCode,
              "Item Code", ItemCode, "Quantity", Quantity, "Cost Per Unit", CostPerUnit);
        }

    }



}



