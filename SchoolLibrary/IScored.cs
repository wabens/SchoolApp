using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolLibrary
{
    public interface IScored 
        // a way to enforce certain conventions without the restrictions of abstract class
        // an object can adhere to mulitple interfaces
    {
        float Score { get; set; }
        float MaxScore { get; set; }
    }
}
