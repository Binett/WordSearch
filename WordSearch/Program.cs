using System;
using System.IO;
using System.Linq;
using WordSearch.Utitlitys;

namespace WordSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            var test = Filereader.ReadText("Data\\testOne.txt").ToList();
        }
    }
}
