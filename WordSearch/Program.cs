using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using WordSearch.Utitlitys;

namespace WordSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Filereader.TextToList("Data/testThree.txt");

            Console.WriteLine(string.Join(" ", text));
        }
    }
}
