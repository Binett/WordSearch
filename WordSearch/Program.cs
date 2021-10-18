using System;
using System.Collections.Generic;
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

            var num1 = HowManyWords(text1);
            var num2 = HowManyWords(text2);
            var num3 = HowManyWords(text3);

            Console.ReadLine();
        }

        public static int HowManyWords(List<string> textList)
        {
            Console.WriteLine("Enter a searchword");
            var searchWord = Console.ReadLine();
            if (textList.Contains(searchWord))
            {
                var count = 0;
                for (int i = 0; i < textList.Count; i++)
                {
                    if (textList[i] == searchWord)
                        count++;
                }
                return count;
            }
            return 0;
        }
    }
}
