using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    class PrideAndPrejudice : Book
    {
        public PrideAndPrejudice() : base()
        {
            language = new EnglishLanguage();
            Name = "Pride And Prejudice";
        }
    }
}
