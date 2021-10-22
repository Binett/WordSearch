using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordSearch.DataStructure
{
    public class Result
    {
        private Node root;

        public string Word { get; set; }
        public string Results { get; set; }

     
        public Result(string word, string results)
        {
            Word = word;
            Results = results;
        }

        public void Insert(string searchword, string result)
        {
            if (root != null)
            {
                root.Insert(searchword, result);
            }
            else
            {
                root = new Node(new Result(searchword, result));
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
