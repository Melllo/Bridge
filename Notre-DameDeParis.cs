using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    class Notre_DameDeParis : Book
    {
        public Notre_DameDeParis() : base()
        {
            language = new FrenchLanguage();
            Name = "Notre-Dame de Paris";
        }
    }
}
