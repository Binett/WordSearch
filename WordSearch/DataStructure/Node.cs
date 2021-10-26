using System;
using System.Text;

namespace WordSearch.DataStructure
{
    public class Node
    {
        private string _word;
        private Tuple<string, int>[] _results;

        private Node Left { get; set; }
        private Node Right { get; set; }

        public Node(string word, Tuple<string, int>[] results)
        {
            _word = word;
            _results = results;
        }

        public void Insert(string word, Tuple<string, int>[] result)
        {         

            if (word[0] <= _word[0])
            {

                if (Left == null)
                {

                    Left = new Node(word, result);
                }
                else
                {
                    if (Left._word == word)
                    {
                        Console.WriteLine("Already added, but heres the result: ");
                    }
                    else
                    {
                        Left.Insert(word, result);
                    }
                }
            }
            else
            {

                if (Right == null)
                {
                    Right = new Node(word, result);
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
                        Right.Insert(word, result);
                    }
                }
            }
        }

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
