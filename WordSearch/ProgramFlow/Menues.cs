using System;
using static WordSearch.Utitlitys.Seeder;
using static WordSearch.Utitlitys.InputHelper;

namespace WordSearch.ProgramFlow
{
    public class Menues
    {
        private readonly ProgramLogic pl = new();

        public void Run()
        {
            while (true)
            {
                Console.WriteLine("1.search\n2.Print results\n3. Print Words by x\n4.Exit");
                InputMenuChoiche(Console.ReadLine(), out string errorMsg, out int choice);
                switch (choice)
                {
                    case 1:
                        pl.Search();
                        break;
                    case 2:
                        pl.PrintResults();
                        break;
                    case 3:
                        PrintWordsMenu();
                        break;
                    case 4:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine(errorMsg);
                        break;
                }
            }
        }

        private void PrintWordsMenu()
        {
            Console.WriteLine("Print words from: \n1.TextOne\n2.TextTwo\n3.TextThree");
            if (InputMenuChoiche(Console.ReadLine(), out string errorMsg, out int choice))
            {
                Console.Write("How many words to print: ");
                if(InputMenuChoiche(Console.ReadLine(), out  errorMsg, out int number)){
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
                            Console.WriteLine(errorMsg);
                            break;
                    }
                }
            }
            Console.WriteLine(errorMsg);
        }
    }
}
