using System;
using System.Collections.Generic;
using WordSearch.DataStructure;
using static WordSearch.Utitlitys.Seeder;
using static WordSearch.Utitlitys.InputHelper;
using System.Linq;

namespace WordSearch
{
    public class ProgramLogic
    {
        readonly Result res = new();
        
        
        internal void PrintResults()
        {
            res.PrintTree();
        }
       

        internal void PrintFromList(List<string> list, int input)
        {
            list.Sort();
            if (input <= list.Count)
            {
                for (int i = 0; i < input; i++)
                {
                    Console.WriteLine(list[i]);
                }
            }
            Console.WriteLine($"The list dosent contain {input} words, so i will give you the entire list.");
            Console.WriteLine(string.Join("\n", list));
        }

        internal void Search()
        {
            while (true)
            {
                Console.Write("[e] to go back\nEnter a word: ");
                var searchWord = Console.ReadLine();
                if (!WordSearchInputHelper(searchWord, out string errorMsg))
                {
                    Console.WriteLine(errorMsg);
                    break;
                }
                if (searchWord == "e")
                {
                    break;
                }

                var num1 = HowManyWords(ListOne, searchWord);
                var num2 = HowManyWords(ListTwo, searchWord);
                var num3 = HowManyWords(ListThree, searchWord);

                Tuple<string, int>[] results =
                {
                new Tuple<string, int>("ListOne: ", num1),
                new Tuple<string, int>("ListTwo: ", num2),
                new Tuple<string, int>("ListThree: ", num3),
                };

                var sorted = results.OrderByDescending(c => c.Item2).ToArray();
                res.Insert(searchWord, sorted); 
                Console.ReadKey();
                Console.Clear();
            }
        }


        internal int HowManyWords(List<string> textList, string searchWord)
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
