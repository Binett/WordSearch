using System;

namespace WordSearch.DataStructure
{
    public class Result
    {
        private Node root;       

        public void Insert(string searchword, Tuple<string, int>[] result)
        {
            if (root != null)
            {
                root.Insert(searchword, result);
            }
            else
            {
                root = new Node(searchword, result);
            }
        }
     
        public void PrintTree()
        {
            if (root != null)
            {
                root.PrintNodes();
            }
        }
    }
}
