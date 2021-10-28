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
        /// <summary>
        /// Instansierar Tree klassen.
        /// </summary>
        private readonly Tree tree = new();

        /// <summary>
        /// Tar in en lista och ett sökord. Räknar hur många gånger sökordet finns i listan.
        /// </summary>
        /// <param name="textList">Lista med ord</param>
        /// <param name="searchWord">Ordet som jämförs mot listan</param>
        /// <returns>Retunerar 0 om listan inte inehåller sökordet. Retunerar antalet om ordet finns</returns>
        internal int HowManyWords(List<string> textList, string searchWord)
        {
            if (!textList.Contains(searchWord)) return 0; // Om listan inte innehåller sökord, retunera 0.
            var count = 0;

            // Ordovärde: O(n)
            for (int i = textList.Count - 1; i >= 0; i--)
            {
                if (textList[i] == searchWord)
                    count++;
            }
            return count;
        }

        /// <summary>
        /// Skriver ut x antal från listan beroende på input. Om input är högre än listans längd skrivs hela listan ut.
        /// </summary>
        /// <param name="list">Lista</param>
        /// <param name="input">Antal ord som ska skrivas ut</param>
        internal void PrintFromList(List<string> list, int input)
        {
            if (input <= list.Count)
            {
                // Ordovärde: O(n)
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

        /// <summary>
        /// Skriver ut resultatet från trädet.
        /// </summary>
        internal void PrintResults()
        {
            Console.Clear();
            tree.PrintTree();
            EnterToContinue();
        }

        /// <summary>
        /// Tar input från användare efter ett sökord, jämför sedan med de tre texterna hur många gånger ordet förekommer.
        /// Rangordnar dessa och skickar in det till datastrukturen. Skriver även ut resultatet till konsolen.
        /// </summary>
        internal void Search()
        {
            while (true)
            {
                Console.Clear();
                Console.Write("Searh for a word, your result will be added to the datastructure\n\nEnter a word: ");
                var input = Console.ReadLine();
                if (!WordSearchInputHelper(input, out var errorMsg, out string searchWord))
                {
                    Console.WriteLine(errorMsg);
                    EnterToContinue();
                    break;
                }
                tree.Insert(searchWord, OrderedResults(searchWord));
                PrintResult(searchWord, OrderedResults(searchWord));
                if (AskSearchAgain())
                {
                    Search();
                }
                break;
            }
        }

        /// <summary>
        /// Hjälpmetod till search metod som ger användare nmöjlighet att söka på ett till ord.
        /// </summary>
        /// <returns>Retunerar sant om användaren skriver in Y/y. Retunerar falskt om något annat skrivs in</returns>
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

        /// <summary>
        /// Rangordnar resultaten för att kunna avgöra vilken listan som inheåller flest sökträffar.
        /// </summary>
        /// <param name="searchWord">De sökta ordet</param>
        /// <returns>Retunerar sorterad tupel</returns>
        private Tuple<string, int>[] OrderedResults(string searchWord)
        {
            return Results(searchWord).OrderByDescending(c => c.Item2).ToArray();
        }

        /// <summary>
        /// Bygger upp en sträng av resultaten och skriver ut den.
        /// </summary>
        /// <param name="searchWord">Det sökta ordet</param>
        /// <param name="results">En tupel av resultaten</param>
        private void PrintResult(string searchWord, Tuple<string, int>[] results)
        {
            // Stringbuilder är snabbare i detta läge.
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

        /// <summary>
        /// Sammlar ihop resultatet och lägger det i en liten låda(tupel).
        /// </summary>
        /// <param name="searchWord">Det sökta ordet</param>
        /// <returns>Retunerar tupeln med det sparade resultatet</returns>
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