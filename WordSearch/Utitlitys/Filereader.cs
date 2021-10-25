using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordSearch.Utitlitys
{
    public static class Filereader
    {
        /// <summary>
        /// Recieves a filepath. Reads the text and split the words with an array with separators.
        /// Creates a list containing the words.
        /// </summary>
        /// <param name="filepath">File folder path</param>
        /// <returns>if list exist return a list with the words from the text document, 
        /// if filepath dosent exist return an empty list</returns>
        public static List<string> TextToList(string filepath)
        {
            try
            {
                string[] separators = { "\r\n", "", " "};
                List<string> list = File.ReadAllText(filepath)                   
                    .Split(separators, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                return list;
            }
            catch (Exception e)
            {
                Console.WriteLine("Kunde inte läsa in textfilen: " + e.Message);
            }
            return new List<string> { };
        }
    }
}
