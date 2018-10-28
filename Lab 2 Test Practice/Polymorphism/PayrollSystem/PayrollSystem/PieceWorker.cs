using System;
using System.Collections.Generic;

class PieceWorker : Employee
{
    private int Wage { get; set; }
    private int Pieces { get; set; }


    public PieceWorker(string firstName, string lastName, string socialSecurityNumber) : base(firstName, lastName, socialSecurityNumber)
    {

    }

    public override decimal Earnings()
    {
        return Wage * Pieces;
    }

    public override decimal Earnings()
    {
        throw new NotImplementedException();
    }
}
