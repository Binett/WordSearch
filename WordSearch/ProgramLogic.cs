using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordSearch.DataStructure;
using static WordSearch.Utitlitys.Seeder;

namespace WordSearch
{
    public class ProgramLogic
    {
        Result res = new("Hallå","4 Bugg och en coca cola" );


        public void Run()
        {
            while (true)
            {
                Console.Write("Enter a word: ");
                var searchWord = Console.ReadLine();

                var num1 = HowManyWords(ListOne, searchWord);
                var num2 = HowManyWords(ListTwo, searchWord);
                var num3 = HowManyWords(ListThree, searchWord);

                Tuple<string, int>[] results =
                {
                new Tuple<string, int>("ListOne: ", num1),
                new Tuple<string, int>("ListTwo: ", num2),
                new Tuple<string, int>("ListThree: ", num3),
                };

                var sortedres = results.OrderByDescending(c => c.Item2);
                var resultString = "";
                foreach (var item in sortedres)
                {
                    resultString += $"{searchWord} occured in {item.Item1}: {item.Item2} times\n";
                }


                res.Insert(searchWord, resultString);
                Console.WriteLine(resultString);
                res.PrintTree();
                Console.ReadKey();
                Console.Clear();
            }

        }

        public int HowManyWords(List<string> textList, string searchWord)
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
