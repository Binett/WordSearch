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
    }
}
