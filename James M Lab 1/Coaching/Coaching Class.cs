using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coaching2
{
    class Coaching2
    {
        private  int enrolment;
        public string CoachingType { get; set; }
        public int Numbers { get; set; }
        public string ClassTime { get; set; }
        public double Charges { get; set; }

        public Coaching2(string coachType, int numbers, string time, double cost)
        {
            CoachingType = coachType;
            Numbers = numbers;
            ClassTime = time;
            Charges = cost;
            enrolment = 0;

        }

        public int Enrolment
        {
            get
            {
                return enrolment;
            }
            set
            {
                
                    enrolment =  enrolment + value;
                    Console.WriteLine("Enrolment complete");
                
                    
            }
        }

        public void displayDetails()
        {
            Console.WriteLine(" Information regarding this class training");
            Console.WriteLine(" This coaching is for " + CoachingType);
            Console.WriteLine(" the enrolment is currently " + enrolment);
            Console.WriteLine(" The class enrolment is " + Numbers + " held at " + ClassTime);
            Console.WriteLine(" The cost per session is " + Charges.ToString("C"));

        }

        public override string ToString()
        {
            return string.Format(" Coaching {0}, \n Enrolment size is {1}, \n  Number currently enrolled is : {2}\n The cost per session is : {3}", CoachingType, Numbers, enrolment, Charges.ToString("c")); 
        }

    }

}

