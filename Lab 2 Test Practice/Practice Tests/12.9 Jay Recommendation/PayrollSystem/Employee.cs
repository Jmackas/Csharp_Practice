// Fig. 12.4: Employee.cs
// Employee abstract base class.
public abstract class Employee
{
    public string FirstName { get; }
    public string LastName { get; }
    public string SocialSecurityNumber { get; }
    private string BirthDate { get; }

    // four-parameter constructor
    public Employee(string firstName, string lastName,
       string socialSecurityNumber, string birthDate)
    {
        FirstName = firstName;
        LastName = lastName;
        SocialSecurityNumber = socialSecurityNumber;
        BirthDate = birthDate;
    }

    public Employee(string firstName, string lastName, string socialSecurityNumber)
    {
        FirstName = firstName;
        LastName = lastName;
        SocialSecurityNumber = socialSecurityNumber;
    }

    // return string representation of Employee object, using properties
    public override string ToString() => $"{FirstName} {LastName}\n" +
       $"social security number: {SocialSecurityNumber}";

    // abstract method overridden by derived classes
    public abstract decimal Earnings(); // no implementation here

    public abstract string BirthDayRaise();
}


/**************************************************************************
 * (C) Copyright 1992-2017 by Deitel & Associates, Inc. and               *
 * Pearson Education, Inc. All Rights Reserved.                           *
 *                                                                        *
 * DISCLAIMER: The authors and publisher of this book have used their     *
 * best efforts in preparing the book. These efforts include the          *
 * development, research, and testing of the theories and programs        *
 * to determine their effectiveness. The authors and publisher make       *
 * no warranty of any kind, expressed or implied, with regard to these    *
 * programs or to the documentation contained in these books. The authors *
 * and publisher shall not be liable in any event for incidental or       *
 * consequential damages in connection with, or arising out of, the       *
 * furnishing, performance, or use of these programs.                     *
 **************************************************************************/
