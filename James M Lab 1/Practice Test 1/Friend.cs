using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Friend
{
    class Friend
    {
        // Declaration of friend's last name
        public string LastName { get; set; }
        // Declaration of friend's first name
        public string FirstName { get; set; }
        // Friend's DOB - date
        public int Day;
        // Friend's DOB - month
        public int Month;
        // Friend's DOB - year
        public int Year { get; set; }
        // Friend's mobile contact number
        public int Mobile { get; set; }


        // Constructor initialisation
        public Friend(string lastName, string firstName, int day, int month, int year, int mobile)
        {
            LastName = lastName;
            FirstName = firstName;
            _Day = day;
            _Month = month;
            Year = year;
            Mobile = Mobile;
        }

        // Property for day
        public int _Day
        {
            get { return Day; }

            set
            {
                // Validating the range retrieved
                if (value < 1 || value > 31)
                {
                    throw new System.ArgumentException("Parameter cannot be null", "original");
                }

                else
                {
                    Day = value;
                }
            }
        }

        // Property for month
        public int _Month
        {
            get { return Month; }

            set
            {
                // Validating the range retrieved
                if (value < 1 || value > 12)
                {
                    throw new System.ArgumentException("Parameter cannot be null", "original");
                }

                else
                {
                    Month = value;
                }
            }
        }

        // Displaying the output (invoked in the main class)
        public void displayDetails()
        {
            Console.WriteLine(LastName);
            Console.WriteLine(FirstName);
            Console.WriteLine(Day);
            Console.WriteLine(Month);
            Console.WriteLine(LastName);
            Console.WriteLine(FirstName);
        }



    }
}
