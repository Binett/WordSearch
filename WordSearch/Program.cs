using System;
using System.Collections.Generic;
using System.Linq;
using WordSearch.DataStructure;
using WordSearch.Utitlitys;

namespace WordSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            Seeder.Seed();
            ProgramLogic pl = new();
            pl.Run();
            
        }

        public static int HowManyWords(List<string> textList, string searchWord)
        {
            if (textList.Contains(searchWord))
            {
                var count = 0;
                for (int i = 0; i < textList.Count; i++)
                {
                    if (textList[i] == searchWord)
                        count++;
                }
                return count;
            }
            return 0;
        }
    }
}
