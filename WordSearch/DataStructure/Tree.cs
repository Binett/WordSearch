using System;

namespace WordSearch.DataStructure
{
    public class Tree
    {
        private Node root;     

        /// <summary>
        /// Tar in ett sökord och en tupel med resultat.
        /// Om roten inte är lika med null så kallar den på Insert metoden i Node klassen
        /// och skickar med sökordet och resultatet.
        /// Annars sätts en ny node men sökordet och resultatet.
        /// </summary>
        /// <param name="searchword">Sökordet</param>
        /// <param name="result">En tuple med resultatet</param>
        public void Insert(string searchword, Tuple<string, int>[] result)
        {
            if (root != null)
            {
                root.Insert(searchword, result);
            }
            else
            {
                root = new Node(searchword, result);
            }
        }
     
        /// <summary>
        /// Om roten inte är lika med null kallar den på PrintNodes metoden i Node klassen.
        /// Annars skrivs det ut att det inte finns något träd än (ingen rot node är satt ännu).
        /// </summary>
        public void PrintTree()
        {
            if (root != null)
            {
                root.PrintNodes();
            }
            else
            {
                Console.WriteLine("The tree hasent been planted yet, search for some words first :)");
            }
        }  
    }
}
