using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    class Personality
    {
        // Auto-implemented property - this returns the property without any logic
        public string Emotion { get; set; }

        // This variable is used in the below getter and setter
        private string action;

        // This is somewhat confusing, but a constructor is effectively initialising the class.
        public Personality(string aEmotion, string aAction)
        {
            Emotion = aEmotion;

            // This constructor has the action set via the getter and setter below...
            Action = aAction;
        }

        


        // Property with logic 
        public string Action
        {
            // This collects the private variable "action"
            get { return action; }

            // Checks if the action is valid
            set
            {
                if (value == "laughing" || value == "smiling")
                {
                    action = value;
                }

                else
                {
                    action = "Not valid... sorry.";
                }
            }
        }

    }
}
