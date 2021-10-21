using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static WordSearch.Utitlitys.Seeder;

namespace WordSearch
{
    public class ProgramLogic
    {
        public void Run()
        {          
            Console.Write("Enter a word: ");
            var searchWord = Console.ReadLine();

            var num1 = Program.HowManyWords(ListOne,searchWord);
            var num2 = Program.HowManyWords(ListTwo,searchWord);
            var num3 = Program.HowManyWords(ListThree,searchWord);

            Tuple<string, int>[] results =
            {
                new Tuple<string, int>("ListOne: ", num1),
                new Tuple<string, int>("ListTwo: ", num2),
                new Tuple<string, int>("ListThree: ", num3),
            };

            var sortedres = results.OrderByDescending(c => c.Item2);
           
            foreach (var item in sortedres)
            {
                Console.WriteLine($"{searchWord} occured in {item.Item1}: {item.Item2} times");
            }
        }
    }
}
