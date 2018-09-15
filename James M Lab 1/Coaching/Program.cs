using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coaching2
{
    class Program
    {
        static void Main(string[] args)
        {

            Coaching2 rugby = new Coaching2("Rugby", 15, " Tuesday 6.30pm", 10.00);
            Coaching2 tennis = new Coaching2("Tennis", 20, "Wedneday 4 pm", 20.00);

            rugby.displayDetails();
            Console.WriteLine("");
            tennis.displayDetails();
            Console.WriteLine("");

            rugby.ClassTime = " Tuesday 5.30 pm";
            Console.WriteLine(rugby.ClassTime);

            Console.WriteLine(rugby.Enrolment);
            if (rugby.Enrolment < rugby.Numbers)
                rugby.Enrolment = 1;
            else
                Console.WriteLine("session is full");

            Console.WriteLine("");

            Console.WriteLine(rugby.ToString());
            Console.WriteLine("");
            Console.WriteLine(tennis);

            Console.ReadLine();
        }
    }
}
