using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordSearch.Utitlitys
{
    public static class InputHelper
    {
        private static string errorMsg = "";
        public static bool WordSearchInputHelper(string word, out string errorMsg)
        {
            
            if (string.IsNullOrWhiteSpace(word))
            {
                errorMsg = "We wont search for empty strings";
                return false;
            }
            errorMsg = "";
            return true;
        }

        public static bool InputMenuChoiche(string input, out string errorMsg, out int validNum)
        {
            if (IsInputANumber(input, out validNum))
            {
                errorMsg = "";
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
