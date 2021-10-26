using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WordSearch.DataStructure;
using static WordSearch.Utitlitys.InputHelper;
using static WordSearch.Utitlitys.Seeder;

namespace WordSearch
{
    public class ProgramLogic
    {
        private readonly Result res = new();

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

        internal void PrintFromList(List<string> list, int input)
        {
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

        internal void PrintResults()
        {
            Console.Clear();
            res.PrintTree();
            EnterToContinue();
        }

        internal void Search()
        {
            while (true)
            {
                Console.Clear();
                Console.Write("[e] to go back\nEnter a word: ");
                var input = Console.ReadLine();
                if (!WordSearchInputHelper(input, out var errorMsg, out string searchWord))
                {
                    Console.WriteLine(errorMsg);
                    EnterToContinue();
                    break;
                }
                res.Insert(searchWord, OrderedResults(searchWord));
                PrintResult(searchWord, OrderedResults(searchWord));
                if (AskSearchAgain())
                {
                    Search();
                }
                break;
            }
        }

        private bool AskSearchAgain()
        {
            Console.WriteLine("[Y/y] to search again\n[any key to go back to main menu]");
            var choice = Console.ReadKey().KeyChar;
            if (char.ToLower(choice) == 'y')
            {
                return true;
            }
            return false;
        }

        private Tuple<string, int>[] OrderedResults(string searchWord)
        {
            return Results(searchWord).OrderByDescending(c => c.Item2).ToArray();
        }

        private void PrintResult(string searchWord, Tuple<string, int>[] results)
        {
            //stringBuilder 0.002148 ms
            //cw i foreachen 0.004728 ms
            Console.WriteLine("\nYou Searched for: " + searchWord + "\n");          
            var sb = new StringBuilder();
            foreach (var (item1, item2) in results)
            {                
                sb.Append($"Text: {item1}  Count: {item2} times\n");               
            }
            Console.WriteLine(sb.ToString());         
        }

        private Tuple<string, int>[] Results(string searchWord)
        {
            var wordCountListOne = HowManyWords(ListOne, searchWord);
            var wordCountListTwo = HowManyWords(ListTwo, searchWord);
            var WordCountListThree = HowManyWords(ListThree, searchWord);

            Tuple<string, int>[] results =
            {
                new("ListOne", wordCountListOne),
                new("ListTwo", wordCountListTwo),
                new("ListThree", WordCountListThree),
                };
            return results;
        }
    }
}