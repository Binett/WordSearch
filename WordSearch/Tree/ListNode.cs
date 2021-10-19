using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordSearch.Tree
{
    public class ListNode
    {
        private Node start;

        public ListNode()
        {
            start = default;
        }

        public bool IsEmpty()
        {
            return start == default;
        }

        public Node GetStart()
        {
            return start;
        }

        public Node GetLast()
        {
            if (IsEmpty())
            {
                return default;
            }
            Node p = start;
            while(p.Next != default)
            {
                p = p.Next;
            }
            return p;
        }

        public void Insert(Result result)
        {
            if (IsEmpty())
            {
                start = (new Node(result));
            }
            else if(!Search(result))
            {
                Node end = GetLast();
                end.Next = new Node(result);
            }
        }

        public bool Search(Result result)
        {
            Node p = start;
            while (p != default)
            {
                if (result.Name == result.Name)
                {
                    break;
                }
                p = p.Next;
            }
            return p != default;
        }
    }
}
