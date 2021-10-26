using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

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
                string[] separators = { "\r\n", "", " " }; // Array där vi bestämmer vart orden skall splittas
                List<string> list = File.ReadAllText(filepath)
                    .Split(separators, StringSplitOptions.RemoveEmptyEntries) // Separerar orden och tar bort de index där strängen är tom
                    .Select(str => Regex.Replace(str, "[^a-zA-Z_]+", "", RegexOptions.Compiled)) // Vi tar bort allt som int är bokstäver 
                    .ToList(); // Konverterar till lista eftsom vi vill returnera en lista som vi har valt att jobba med i första hand.
                // O(log n) tillhör sort
                // vi väljer att sortera listan redan här eftersom det inte är krav att skriva ut hela listan som orginaldokumentet.
                list.Sort(); // Vi skrev först en egen quicksort men kastade den då den presterade sämre än APIet
                //List<T>.Sort uses a quicksort algorithm, which is O(log n) space. https://en.wikipedia.org/wiki/Quicksort#Space_complexity
              
                Console.WriteLine($"{filepath} was succesfully converted to a list"); //Om det lyckas skriver vi ut det till konsolen
                return list;
            }
            catch (Exception e) // kastar exception om det inte lyckas
            {
                Console.WriteLine("Kunde inte läsa in textfilen: " + e.Message); // Skickar meddelande till konsolen 
                return new List<string>(); // returnerar en tom lista för att undvika krasch
            }
        }
    }
}

