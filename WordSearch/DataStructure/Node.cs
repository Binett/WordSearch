using System;
using System.Collections.Generic;
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
