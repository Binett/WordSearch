using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            if (word[0] <= 'n')
            {
                if (Left == null)
                {
                    Left = new Node(word, result);
                }
                else
                {
                    Left.Insert(word, result);
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
                    Right.Insert(word, result);
                }
            }
        }

        public void PrintNodes()
        {
            Console.WriteLine($"{_word}");
            foreach (var result in _results)
            {
                Console.WriteLine($"Name: {result.Item1} count: {result.Item2}");
            }

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
