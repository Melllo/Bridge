using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    class EnglishLanguage : ILanguage
    {
        public string getName(){
                return "English";
             }
        public ILanguage Translation(ILanguage language, Book book)
        {
            String s = language.getName();
            Console.WriteLine("Translate from " + s +" to English");
            switch(book.Name){
                case "Лісова пісня": book.Name = "Forest Song"; break;
                case "Notre-Dame de Paris": book.Name = "Notre-Dame de Paris(eng)"; break;
                case "Pride And Prejudice": book.Name = "It is already in English"; break;
                default: break;
            }
            return new EnglishLanguage();
        }
    }
}
