using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    abstract class Book
    {
        protected string name;
        protected ILanguage language;

        public string Name{ get; set; }
        public ILanguage Language
        {
            get; set;
        }
        public Book(){}
        public virtual void switchLanguage(ILanguage lang, Book book)
        {   
            Language = lang.Translation(language, book);
        }
    }
}
