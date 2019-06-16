using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolLibrary
{
    public class ScoreUtility
    {
        // BestOfTwo takes in anything of the type IScored (i.e f
        public static IScored BestOfTwo(IScored Assignment1, IScored Assignment2)
        {
            var score1 = Assignment1.Score/Assignment1.MaxScore;
            var score2 = Assignment2.Score / Assignment2.MaxScore;
            if (score1 > score2)
            {
                return Assignment1;
            }
            else
            {
                return Assignment2;
            }
        }
    }
}
