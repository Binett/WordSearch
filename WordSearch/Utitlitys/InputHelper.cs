using System;
using System.Linq;
using System.Text;

namespace WordSearch.Utitlitys
{
    public static class InputHelper
    {
       
        public static bool WordSearchInputHelper(string word, out string errorMsg)
        {
            errorMsg = "";
            if (string.IsNullOrWhiteSpace(word))
            {
                errorMsg = "We wont search for empty strings";
                return false;
            }
            TrimWord(word);
            return true;
        }

        private static string TrimWord(string input)
        {
            var sb = new StringBuilder();
            for (int i = 0; i < input.Length; i++)
            {
                if (!char.IsWhiteSpace(input,i))
                {
                    sb.Append(input[i]);
                }
            }
            return sb.ToString();
        }

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

        private static bool IsInputANumber(string input, out int validNum)
        {
            return int.TryParse(input, out validNum);
        }
    }
}
