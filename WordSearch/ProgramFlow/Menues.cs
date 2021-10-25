using System;
using static WordSearch.Utitlitys.Seeder;

namespace WordSearch.ProgramFlow
{
    public class Menues
    {
        private ProgramLogic pl = new();

        public void Run()
        {
            while (true)
            {
                Console.WriteLine("1.search\n2.Print results\n3. Print Words by x\n4.Exit");
                var choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        pl.Search();
                        break;
                    case "2":
                        pl.PrintResults();
                        break;
                    case "3":
                        PrintWords();
                        break;
                    case "4":
                        Environment.Exit(0);
                        break;
                    default:
                        break;
                }
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
                    pl.PrintFromList(ListOne, number);
                    break;
                case 2:
                    pl.PrintFromList(ListTwo, number);
                    break;
                case 3:
                    pl.PrintFromList(ListThree, number);
                    break;
                default:
                    break;
            }
        }
    }
}
