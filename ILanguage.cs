using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    interface ILanguage
    {
         ILanguage Translation(ILanguage lang, Book book);
         string getName();
    }
}
