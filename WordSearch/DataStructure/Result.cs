using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordSearch.DataStructure
{
    public class Result
    {
        private Node rootNode;        

        public string Word { get; set; }
        public int[] WordCount { get; set; }
        public string[] FileName { get; set; }

        public Result(string word, int[] count, string[] fileName)
        {
            Word = word;
            WordCount = count;
            FileName = fileName;
        }



    }
}
