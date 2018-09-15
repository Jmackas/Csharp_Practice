using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Friend
{
    class Program
    {
        static void Main(string[] args)
        {
            Friend John = new Friend("Anderson", "John", 5, 33, 1980, 0292992112);

            John.displayDetails();
        }

        
    }
}
