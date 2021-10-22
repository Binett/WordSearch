using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordSearch.DataStructure
{
    public class Node
    {
        private readonly Result _result;
        private Node Left { get; set; }
        private Node Right { get; set; }

        public Node(Result result)
        {

            _result = result;
        }

        public void Insert(string word, string result)
        {
            //int compare = word.CompareTo(_result.Word);
            if (word[0] <= 'n')
            {
                if (Left == null)
                {
                    Left = new Node(new Result(word, result));
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
                    Right = new Node(new Result(word, result));
                }
                else
                {
                    Right.Insert(word, result);
                }
            }
        }


        public void PrintNodes()
        {
            Console.WriteLine($"{_result.Word} \n {_result.Results}");

            if (Left != null)
            {
                Left.PrintNodes();
            }
            if (Right != null)
            {
                Right.PrintNodes();
            }
        }


        //public Node(Result result)
        //{
        //    _result = result;
        //}

        //public Node GetLeftNode()
        //{
        //    return _leftNode;
        //}
        //public Node GetRightNode()
        //{
        //    return _rightNode;
        //}

        //public Node SetLeftNode(Node newNode)
        //{
        //    return _leftNode = newNode;
        //}

        //public Node SetRightNode(Node newNode)
        //{
        //    return _rightNode = newNode;
        //}

        //public override string ToString()
        //{

        //}

    }
}
