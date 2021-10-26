using System;
using System.Linq;
using System.Text;

namespace WordSearch.Utitlitys
{
    public static class InputHelper
    {
        /// <summary>
        /// Tar in input från användaren, kontrollerar IsNullOrEmpty, om så är fallet skickas ett errormeddelande.
        /// Tar bort alla whitespaces och returnerar en trimmad sträng
        /// </summary>
        /// <param name="word">Input från användare</param>
        /// <param name="errorMsg">Felmeddelande</param>
        /// <param name="searchWord">Trimmad sträng</param>
        /// <returns></returns>
        public static bool WordSearchInputHelper(string word, out string errorMsg, out string searchWord)
        {
            errorMsg = "";
            searchWord = TrimWord(word);
            if (string.IsNullOrWhiteSpace(word))
            {
                errorMsg = "We wont search for empty strings";
                return false;
            }
            return true;
        }

        /// <summary>
        /// Kontrollerar om menyvalet är en integer.
        /// </summary>
        /// <param name="input">Användar input</param>
        /// <param name="errorMsg">Felmeddelande</param>
        /// <param name="validNum">int menyval</param>
        /// <returns>true om int, false om sträng</returns>
        public static bool InputMenuChoiche(string input, out string errorMsg, out int validNum)
        {
            errorMsg = "";

            if (IsInputANumber(input, out validNum))
            {
                return true;
            }
            else
            {
                errorMsg = "Please enter a valid number";
                return false;
            }
        }

        /// <summary>
        /// Hjälpmetod för att stanna upp programet och invänta bekräftelse från användaren
        /// </summary>
        public static void EnterToContinue()
        {
            Console.WriteLine("\n[Any key to continue]");
            Console.ReadLine();
        }

        /// <summary>
        /// Trimmar sökordet från användaren
        /// Ville testa lite stringBuilder istället ett API
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        private static string TrimWord(string input)
        {
            //ordovärde: O(n)
            var sb = new StringBuilder();
            for (int i = 0; i < input.Length; i++)
            {
                if (!char.IsWhiteSpace(input, i))
                {
                    sb.Append(input[i]);
                }
            }
            return sb.ToString();
        }

        /// <summary>
        /// Hjälpmetod som kontroller om strängen kan konverteras till en int
        /// </summary>
        /// <param name="input">Input från änvändare</param>
        /// <param name="validNum">Int om success</param>
        /// <returns>True || False</returns>
        private static bool IsInputANumber(string input, out int validNum)
        {
            return int.TryParse(input, out validNum);
        }

    }
}
