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
            else
            {
                Console.WriteLine(string.Join("\n", list));
                Console.WriteLine($"The list dosent contain {input} words, so i gave you the entire list.");
            }
        }

        internal void Search()
        {
            while (true)
            {
                Console.Write("[e] to go back\nEnter a word: ");
                var searchWord = Console.ReadLine();
                if (!WordSearchInputHelper(searchWord, out var errorMsg))
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
                new("ListOne: ", num1),
                new("ListTwo: ", num2),
                new("ListThree: ", num3),
                };

                var sorted = results.OrderByDescending(c => c.Item2).ToArray();
                res.Insert(searchWord, sorted);
                Console.WriteLine("You Searched for: " + searchWord+ "\n");
                foreach (var (item1, item2) in sorted)
                {
                    Console.WriteLine($"{item1} contained {item2} times");
                }
                Console.ReadKey();
                Console.Clear();
            }
        }


        internal int HowManyWords(List<string> textList, string searchWord)
        {
            if (!textList.Contains(searchWord)) return 0;
            var count = 0;
            for (int i = textList.Count - 1; i >= 0; i--)
            {
                if (textList[i] == searchWord)
                    count++;
            }
            return count;
        }
    }
}
