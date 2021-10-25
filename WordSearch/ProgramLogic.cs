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

        public void Run()
        {
            while (true)
            {
                Console.WriteLine("1.search\n2.Print results\n3. Print Words by x");
                var choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Search();
                        break;
                    case "2":
                        PrintResults();
                        break;
                    case "3":
                        PrintWords();
                        break;                   
                    default:
                        break;
                }
            }


        }

        private void PrintResults()
        {
            res.PrintTree();
        }

        public void SortSort<T>(IList<T> list)
        {
            List<T> tmp = new List<T>(list);
            tmp.Sort();
            for (int i = 0; i < tmp.Count; i++)
            {
                list[i] = tmp[i];
            }
        }


        private void PrintWords()
        {
            Console.WriteLine("Print words from: \n1.TextOne\n2.TextTwo\n3.TextThree");
            var choice = int.Parse(Console.ReadLine());
            Console.Write("How many words to print: ");
            var number = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    PrintFromList(ListOne, number);
                    break;
                case 2:
                    PrintFromList(ListTwo, number);
                    break;
                case 3:
                    PrintFromList(ListThree, number);
                    break;
                default:
                    break;
            }
        }

     

        private void PrintFromList(List<string> list, int input)
        {
            SortSort(list);
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

        private void Search()
        {
            while (true)
            {
                Console.Write("[e] to go back\nEnter a word: ");
                var errorMsg = "";
                var searchWord = Console.ReadLine();
                if (!WordSearchInputHelper(searchWord, out errorMsg))
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
