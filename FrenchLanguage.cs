using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    class FrenchLanguage : ILanguage
    {
        public ILanguage Translation(ILanguage language, Book book)
        {
            String s = language.getName();
            Console.WriteLine("Translate from " + s + " to English");
            switch (book.Name)
            {
                case "Лісова пісня": book.Name = "Chanson de la forêt"; break;
                case "Notre-Dame de Paris": book.Name = "It's already in French"; break;
                case "Pride And Prejudice": book.Name = "Orgueil et préjugés"; break;
                default: break;
            }
            return new FrenchLanguage();
        }
        public string getName()
        {
            return "French";
        }
    }
}
