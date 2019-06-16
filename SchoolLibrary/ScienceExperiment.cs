using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolLibrary
{
    class ScienceExperiment : IScored // add more interfaces or a base class with comma seperated list
    {
        public string Hypothesis { get; set; }
        public string Materials { get; set; }
        public string Method { get; set; }
        public string Conclusion { get; set; }
        
        // Score and MaxScor are part of IScored interface
        public float Score { get; set; }
        public float MaxScore { get; set; }
    }
}
