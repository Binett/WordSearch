using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordSearch
{
    public class Result
    {
        public Result(string name, int count)
        {
            Name = name;
            Count = count;
        }
        public string Name { get; set; }
        public int Count { get; set; }
    }
}
