using System;
using WordSearch.Utitlitys;

namespace WordSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            const string filepath1 = "Data/testOne.txt";
            const string filepath2 = "Data/testTwo.txt";
            const string filepath3 = "Data/testThree.txt";

            var text1 = Filereader.TextToList(filepath1);
            var text2 = Filereader.TextToList(filepath2);
            var text3 = Filereader.TextToList(filepath3);

            Console.WriteLine("Enter a searhword");
            var searchWord = Console.ReadLine();

            if (text1.Contains(searchWord))
            {
                var count = 0;
                for (int i = 0; i < text1.Count; i++)
                {
                    if (text1[i] == searchWord)
                        Console.WriteLine(text1[i]);
                }
                Console.WriteLine($"Text 1 {searchWord} occured {count} times");
            }

            Console.ReadLine();
        }
    }
}
