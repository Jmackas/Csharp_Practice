using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Employee
    {
        public string FName {get; set;}
        public string LName {get;set;}
        public string EmpID { get; set; }

        public Employee (string first,string last, string ID)
        {
            FName = first;
            LName = last;
            EmpID = ID;
        }


        public Employee()
        {
        }

        public override string ToString()
        {
            return string.Format("{0} {1} \n Employee ID: {2}", FName, LName, EmpID);

        }

    }
}
