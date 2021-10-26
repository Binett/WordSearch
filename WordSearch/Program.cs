using WordSearch.ProgramFlow;
using WordSearch.Utitlitys;

namespace WordSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            // Seedar Textfilerna
            Seeder.Seed();
            // Instansierar meny klassen 
            Menus menu = new();
            // Anropar Run
            menu.Run();
        }
    }
}
