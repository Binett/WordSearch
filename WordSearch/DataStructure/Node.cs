using System;
using System.Collections.Generic;
using System.Text;

namespace WordSearch.DataStructure
{
    public class Node
    {
        // Fält för word, som är nodens värde
        private string _word;
        // En tuple med resultat som vi får baserat på sökord
        private Tuple<string, int>[] _results;

        // Getters och setters för Noderna
        private Node Left { get; set; }
        private Node Right { get; set; }

        //Konstruktor för node klassen
        public Node(string word, Tuple<string, int>[] results)
        {
            _word = word;
            _results = results;
        }


        /// <summary>
        /// Tar in en sträng med ett värde som vi vill tilldela noden,
        /// Här har vi använt oss av en rekursiv metod som kommer gå igenom noderna och
        /// jämföra värdet på noderna tills vi hamnar på en tom nod och där, utgår från root noden. 
        /// skapar vi upp en ny nod med där strängens värde blir "key" och den skall hålla 
        /// tuplen med sökresultat i sig. 
        /// 
        /// Valde rekursivt för att bryta ned sökning till mindre och mindre delar för varje itteration.
        /// 
        /// Tidskomplexitet: O(1) + O(1) + O(1) + O(log n)
        /// 
        /// Asymptotisk analys: O(log n)
        /// </summary>
        /// <param name="word">Värde på noden</param>
        /// <param name="result">Sökresultat</param>
        public void Insert(string word, Tuple<string, int>[] result)
        {         

            if (string.Compare(word, this._word, StringComparison.InvariantCulture) < 0)
            {
                if (this.Left == null)
                {
                    this.Left = new Node(word, result);
                }
                else
                {
                    if (this.Left._word == word)
                    {
                        Console.WriteLine("Already added, but heres the result: ");
                    }
                    else
                    {
                        this.Left.Insert(word, result);
                    }
                }
            }
            else
            {

                if (this.Right == null)
                {
                    this.Right = new Node(word, result);
                }
                else
                {
                    if (word == Right._word)
                    {
                        Console.WriteLine("Already added, but heres the result:");
                        return;
                    }
                    else
                    {
                        this.Right.Insert(word, result);
                    }
                }
            }
        }

        /// <summary>
        /// rekursiv metod för att printa ut trädet med sökresultatet
        /// </summary>
        public void PrintNodes()
        {
            Console.WriteLine($"Searched word {_word}");
            var sb = new StringBuilder();
            foreach (var (item1, item2) in _results)
            {
                sb.Append($"\tText: {item1}  Count: {item2} times\n");
            }
            Console.WriteLine(sb.ToString());
            Console.WriteLine();

            if (Left != null)
            {
                Console.WriteLine("Left Node");
                Left.PrintNodes();
            }
            if (Right != null)
            {
                Console.WriteLine("Right Node");
                Right.PrintNodes();
            }
        }
    }
}
