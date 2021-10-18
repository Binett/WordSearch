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
            char[] text = File.ReadAllText("Data/testOne.txt").ToArray();
            foreach (var item in text)
            {
                Console.WriteLine(item);
            }
        }
    }
}
