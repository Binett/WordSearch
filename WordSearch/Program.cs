using WordSearch.ProgramFlow;
using WordSearch.Utitlitys;

namespace WordSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            Seeder.Seed();
            Menus menu = new();
            menu.Run();
        }
    }
}
