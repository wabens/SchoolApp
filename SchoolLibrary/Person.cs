using System;
using System.Collections.Generic;
using System.Text;

//base class

namespace SchoolLibrary
{
   public abstract class Person // abstract prevents direct instantiation
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        // an abstract method to be overridden with specific implenetaiton for sub classes
        // sub classes are required to override with this particular method
        public abstract float ComputeGradeAverage();

        public virtual string SendMessage(string message) // optional override
        {
            var sb = new StringBuilder();
            var timestamp = String.Format("Sent on {0:D} at {0:t}", DateTime.Now);
            sb.AppendLine("");
            sb.AppendLine("Dear " + FirstName + ",");
            sb.AppendLine(message);
            return sb.ToString();

        }
    }
}
