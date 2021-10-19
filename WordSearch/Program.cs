using System;
using System.IO;
using System.Linq;
using WordSearch.Utitlitys;

namespace WordSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            


            char[] text = File.ReadAllText("Data/testOne.txt").ToArray();
            foreach (var item in text)
            {
                new Result("List1", num1),
                new Result("List2", num2),
                new Result("List3", num3),
                new Result("List4", num4 ),
            };

            var sortedRes = result.OrderByDescending(x =>x.Count);

            foreach (var item in result)
            {
                Console.WriteLine($"{item.Name} contains {item.Count} times {searchWord}");
            }


            text2.Sort();

            var number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                Console.WriteLine(text2[i]);
            }

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
        }
    }
}
