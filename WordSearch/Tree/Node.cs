using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordSearch.Tree
{
    public class Node
    {
        public Result Result { get; set; }
        public Node Next { get; set; }

        public Node(Result result, Node next = default)
        {
            Result = result;
            Next = next;
        }
    }
}
