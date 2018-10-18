using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spam_Scanner
{
    class Program
    {
        static void Main(string[] args)
        {
            // Counter variable declaration
            double counter = 0;

            // 30 Common spam words and phrases to an array (source - https://emailmarketing.comm100.com/email-marketing-ebook/spam-words.aspx)
            string[] spamTerms = { "Money", "No questions asked", "4U", "Winner", "Click below", "Compare rates", "Free website", "Free offer", "Free investment", "Do it today", "No selling", "Save $", "Opt in", "Stop snoring", "No age restrictions", "Pure profit", "We honor all", "You have been selected", "We hate spam", "Your income", "Winning", "They keep your money — no refund!", "Unlimited", "Viagra and other drugs", "Urgent", "No medical exams", "Multi level marketing", "Outstanding values", "Strong buy", "Stuff on sale" };

            // Make all terms lower case in the array
            spamTerms = spamTerms.Select(s => s.ToLowerInvariant()).ToArray();

            // Take user input
            Console.WriteLine("Please enter an e-mail message");
            var userSpam = Console.ReadLine();
            var userSpamLower = userSpam.ToLower();

            // Cycling the message through the various spam terms
            foreach (string i in spamTerms)
            {
                // Determining if the string is contained within the e-mail
                if (userSpamLower.Contains(i))
                {
                    counter++;
                }
            }

            // Spam score algorithm
            double spamScore = (counter / 30) * 100;
            
            // Spam score output
            Console.WriteLine("The email is currently " + spamScore + "% spam");

            // Determining if the message is spam
            if (spamScore > 10)
            {
                Console.WriteLine("This message is most likely spam.");
            }

            else if (spamScore < 10) 
            {
                Console.WriteLine("This is most likely not spam.");
            }

        }
    }
}
