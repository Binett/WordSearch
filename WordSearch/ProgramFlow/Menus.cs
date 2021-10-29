using System;
using static WordSearch.Utitlitys.InputHelper;
using static WordSearch.Utitlitys.Seeder;

namespace WordSearch.ProgramFlow
{
    public class Menus
    {
        /// <summary>
        /// Instansierar ProgramLogic klassen.
        /// </summary>
        private readonly ProgramLogic pl = new();

        /// <summary>
        /// Metod som används i Program filen för att starta igång flödet.
        /// </summary>
        public void Run()
        {
            MainMenu();
        }

        /// <summary>
        /// Huvudmeny där olika val kan göras. Användarens input kontrolleras med en hjälpmetod.
        /// </summary>
        private void MainMenu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("1. Search for word\n2. Print results\n3. Print a specific number of words\n4. Exit\n");
                Console.Write("Input: ");
                InputMenuChoiche(Console.ReadLine(), out var errorMsg, out var choice);
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
                        Console.WriteLine(!string.IsNullOrEmpty(errorMsg) ? errorMsg : "Enter a number between 1-4");
                        EnterToContinue();
                        break;
                }
            }
        }

        /// <summary>
        /// Menu som används för att välja vilken lista som orden ska skrivas ut ifrån. Användarens input kontrolleras med en hjälpmetod.
        /// </summary>
        private void PrintWordsMenu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Print words from: \n1. TextOne\n2. TextTwo\n3. TextThree");
                if (InputMenuChoiche(Console.ReadLine(), out var errorMsg, out var choice))
                {
                    if (choice is <= 0 or > 3)
                    {
                        Console.WriteLine("Enter a valid menu choice");
                    }
                    else
                    {
                        Console.Write("How many words to print: ");
                        if (InputMenuChoiche(Console.ReadLine(), out errorMsg, out var number))
                        {
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
                            }

                            EnterToContinue();
                            break;
                        }

                        Console.WriteLine(errorMsg);
                    }
                }
                else
                {
                    Console.WriteLine(errorMsg);
                }
                Console.ReadLine();
            }
        }
    }
}