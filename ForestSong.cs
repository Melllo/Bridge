using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    class ForestSong : Book
    { 
        public ForestSong():base() {
            language = new UkranianLanguage();
            Name = "Лісова пісня";
        } 
    }
}
