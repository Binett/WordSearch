using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordSearch.Utitlitys
{
    public static class Filereader
    {
        public static IEnumerable<string> ReadText(string filePath)
        {
            using (TextReader reader = File.OpenText(filePath))
            {
                string text;
                while((text = reader.ReadLine()) != null)
                {
                    yield return text;
                }
            }
        }
    }
}
