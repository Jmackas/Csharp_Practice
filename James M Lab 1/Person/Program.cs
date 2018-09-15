using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    class Program
    {
        static void Main(string[] args)
        {
            Personality happy = new Personality("feeling good", "laughing");

            Console.WriteLine(happy.Action);

            Console.WriteLine(happy.Emotion);

            Console.ReadLine();
        }
    }
}
