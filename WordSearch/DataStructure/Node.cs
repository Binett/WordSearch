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
        private  Node _rightNode;
        private  Node _leftNode;

        public Node(Result result)
        {
            _result = result;
        }

        public Node GetLeftNode()
        {
            return _leftNode;
        }
        public Node GetRightNode()
        {
            return _rightNode;
        }

        public Node SetLeftNode(Node newNode)
        {
            return _leftNode = newNode;
        }

        public Node SetRightNode(Node newNode)
        {
            return _rightNode = newNode;
        }

        public override string ToString()
        {
            return (_result != null) ? $"{_result.Word} {string.Join(" ",_result.WordCount) + string.Join("}\n",_result.FileName)}" : "Empty";
        }

    }
}
