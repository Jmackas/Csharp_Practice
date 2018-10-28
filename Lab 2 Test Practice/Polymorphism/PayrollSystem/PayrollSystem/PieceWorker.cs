using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollSystemTest
{
    class PieceWorker : Employee 
    {
        private int PiecesCreated;
        private int Wage;
        private int Pieces;


        public PieceWorker(string firstName, string lastName, string socialSecurityNumber) : base(firstName, lastName, socialSecurityNumber)
        {

        }

        public override decimal Earnings()
        {
            throw new NotImplementedException();
        }
    }
}
