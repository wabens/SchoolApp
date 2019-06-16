using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolLibrary
{
    class EnglishPaper
    {
        public string Name { get; set; }
        public string PaperText { get; set; }
        public int WordCount
        {
            get { return PaperText.WordCount(); }
        }
    }
}
