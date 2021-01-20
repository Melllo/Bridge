using System;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            Book foresrSong = new PrideAndPrejudice();
            Console.WriteLine(foresrSong.Name);
            foresrSong.switchLanguage(new FrenchLanguage(), foresrSong);
            ILanguage lang = foresrSong.Language;
            Console.WriteLine(foresrSong.Name);

        }
    }
}
