using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example
{
    abstract class Shape
    {
        public string Name { get; set; }

        // Pronounce information on name assigned
        public virtual void GetInfo()
        {
            Console.WriteLine("This is a " + Name);
        }

        public abstract double Area();



    }
}
