using System;
using System.Collections.Generic;
using System.Linq;
using WordSearch.DataStructure;
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


            Console.WriteLine("Enter a searchword");
            var searchWord = Console.ReadLine();

            var num1 = HowManyWords(text1, searchWord);
            var num2 = HowManyWords(text2, searchWord);
            var num3 = HowManyWords(text3, searchWord);


            int[] numbers = { num1, num2, num3 };
            string[] fileName = { filepath1, filepath2, filepath3 };
            Result res = new(searchWord, numbers, fileName);

            Node node = new(res);
            Console.WriteLine(node.ToString());

            //var result = new List<Result>
            //{
            //    new Result("List1", num1),
            //    new Result("List2",num2),
            //    new Result("List3", num3),
            //    new Result("List4", num4),
            //};

            //var sortedRes = result.OrderByDescending(x => x.Count);

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item.Name} contains {item.Count} times {searchWord}");
            //}


            Console.ReadLine();
        }

        public static int HowManyWords(List<string> textList, string searchWord)
        {

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
