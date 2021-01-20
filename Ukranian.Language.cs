using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    class UkranianLanguage : ILanguage
    {
        public ILanguage Translation(ILanguage language, Book book)
        {
            String s = language.getName();
            Console.WriteLine("Translate from " + s + " to English");
            switch (book.Name)
            {
                case "Лісова пісня": book.Name = "It's already in Ukranian"; break;
                case "Notre-Dame de Paris": book.Name = "Собор Паризької Богоматері"; break;
                case "Pride And Prejudice": book.Name = "Гордість і упередження"; break;
                default: break;
            }
            return new UkranianLanguage();
        }
        public string getName()
        {
            return "Ukranian";
        }
    }
}
