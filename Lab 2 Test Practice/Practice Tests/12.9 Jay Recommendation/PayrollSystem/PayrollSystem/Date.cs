using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollSystem
{
    class Date : Employee
    {
        public Date(string firstName, string lastName, string socialSecurityNumber, int birthDate) : base(firstName, lastName, socialSecurityNumber, birthDate)
        {
            
        }

        public override decimal Earnings()
        {
            /////
        }
    }
}
