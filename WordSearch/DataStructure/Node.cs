using System;
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
        /// jämföra värdet på noderna tills vi hamnar på en tom nod, utgår från root noden. 
        /// Och där skapar vi upp en ny nod där strängens värde blir "key" och den skall hålla 
        /// tuplen med sökresultat i sig.
        /// 
        /// Valde rekursivt för att bryta ned sökning till mindre och mindre delar för varje itteration.
        /// Med rekursivt får vi bättre tidskomplexitet än om vi hade valt en loop.
        /// 
        /// Tidskomplexitet: O(1) + O(1) + O(1) + O(log n)
        /// 
        /// Asymptotisk analys: O(log n)
        /// </summary>
        /// <param name="word">Värde på noden</param>
        /// <param name="result">Sökresultat</param>
        public void Insert(string word, Tuple<string, int>[] result)
        {
            if (word == this._word)
            {
                Console.WriteLine("Already added to to the datastructure, but heres your result: ");
                return;
            }

            if (string.Compare(word, this._word, StringComparison.InvariantCulture) < 0)
            {
                if (this.Left == null)
                {
                    this.Left = new Node(word, result);
                }
                else
                {
                    this.Left.Insert(word, result);
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
                    this.Right.Insert(word, result);
                }
            }
        }

        /// <summary>
        /// rekursiv metod för att printa ut trädet med sökresultatet
        /// 
        /// tidskomplexitet: O(log n).
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
                Left.PrintNodes();
            }
            if (Right != null)
            {
                Right.PrintNodes();
            }
        }
    }
}
