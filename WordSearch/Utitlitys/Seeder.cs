using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordSearch.Utitlitys
{
    public static class Seeder
    {
        private static List<string> listOne;
        private static List<string> listTwo;
        private static List<string> listThree;

        internal static List<string> ListOne { get => listOne;  }
        internal static List<string> ListTwo { get => listTwo; }
        internal static List<string> ListThree { get => listThree; }

        public static void Seed()
        {
            const string filepathOne = "Data\\TextOne.txt";
            const string filepathTwo = "Data\\TextTwo.txt";
            const string filepathThree = "Data\\TextThree.txt";

            listOne = Filereader.TextToList(filepathOne);
            listTwo = Filereader.TextToList(filepathTwo);
            listThree = Filereader.TextToList(filepathThree);

            Console.Write("\nPress Enter to continue");
            Console.ReadLine();
        }
    }
}
