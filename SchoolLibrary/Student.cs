using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolLibrary
{
    public class Student : Person  // inheriting from person
    {
        public enum GradeLevels { Freshman, Sophomore, Junior, Senior};
        public GradeLevels GradeLevel { get; set; }

        public override float ComputeGradeAverage()
        {
            return 4.0f;
        }
    }
}
