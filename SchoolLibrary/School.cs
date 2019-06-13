using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolLibrary
{
    public class School
    {
        public string SchoolName;
        public string Name { get; set; } // auto property, to add encapsulation
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string PhoneNumber { get; set; }

        private string _twitterAddress; // backing value, protected with access mod private
        public string TwitterAddress // exposed with access mod public
        {
            // make sure the twitter address starts with @
            get { return _twitterAddress; }
            set
            {
                if(value.StartsWith("@")) // value is a given variable which only works within the context of getters and setters
                {
                    _twitterAddress = value;
                }
                else
                {
                    throw new Exception("The twitter address must begin with @");
                }
            }
        }

        // contsructor is a function which runs immmedietley when an object is instantiated
        // ie new keyword()
        public School() // no return type required
        {
            Name = "Untitled School"; // sets initial values
            PhoneNumber = "555-1234";
        }

        // overloading, same name but different method signatures
        // method signatures: return type, mname and name and type of arguments
        public School(string SchoolName, string SchoolPhoneNumber) // as many as you want
            // variants have to be unique, ie different numbers of inputs
        {
            Name = SchoolName;
            PhoneNumber = SchoolPhoneNumber;
        }

        // methods! aka functions
        //public float AverageThreeScores(float a, float b, float c)
        //{
        //    var result = (a + b + c) / 3;
        //    return result;
        //}

        // static meaning can be accessed with instanttiation
        public static int AverageThreeScores(int a, int b, int c) // void for a function which doesn't return
        {
            var result = (a + b + c) / 3;
            return result;
        }

        // function bodied expression (different way of writing a method)
        // returns the expression after the arrow
        public static float AverageThreeScores(float a, float b, float c) => (a + b + c) / 3;

        // overide toString method
        // every object in C# inherits from baseclass
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine(Name);
            sb.AppendLine(Address);
            sb.AppendLine(City);
            sb.Append(", ");
            sb.Append(State);
            sb.Append("  ");
            sb.Append(Zip);
            return sb.ToString();
        }
    }
}


