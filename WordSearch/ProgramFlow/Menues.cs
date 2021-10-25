﻿using System;
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
                        Console.WriteLine(errorMsg);
                        Console.ReadLine();
                        break;
                }
            }
        }

        private void PrintWordsMenu()
        {
            Console.Clear();
            Console.WriteLine("Print words from: \n1. TextOne\n2. TextTwo\n3. TextThree");
            if (InputMenuChoiche(Console.ReadLine(), out var errorMsg, out var choice))
            {
                Console.Write("How many words to print: ");
                if(InputMenuChoiche(Console.ReadLine(), out  errorMsg, out var number)){
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
            Console.ReadLine();
            Console.WriteLine(errorMsg);
        }
    }
}
