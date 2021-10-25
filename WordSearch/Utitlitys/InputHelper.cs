using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            return true;
        }
    }
}
