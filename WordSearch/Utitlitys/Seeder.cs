using System.Collections.Generic;
using static WordSearch.Utitlitys.InputHelper;

namespace WordSearch.Utitlitys
{
    public static class Seeder
    {
        // Fält för listorna
        private static List<string> listOne;
        private static List<string> listTwo;
        private static List<string> listThree;

        // Static getters för varje lista då vi vill använda dem globalt
        internal static List<string> ListOne { get => listOne;  }
        internal static List<string> ListTwo { get => listTwo; }
        internal static List<string> ListThree { get => listThree; }

        /// <summary>
        /// Läser in txt filerna med hjälp av den angivna filvägen, separerar orden och spar varje texts ord i en separat lista.
        /// </summary>
        public static void Seed()
        {
            const string filepathOne = "Data\\TextOne.txt";
            const string filepathTwo = "Data\\TextTwo.txt";
            const string filepathThree = "Data\\TextThree.txt";

            listOne = Filereader.TextToList(filepathOne);
            listTwo = Filereader.TextToList(filepathTwo);
            listThree = Filereader.TextToList(filepathThree);

            EnterToContinue();
        }
    }
}
