using WordSearch.ProgramFlow;
using WordSearch.Utitlitys;

namespace WordSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            Seeder.Seed();
            Menues menu = new();
            menu.Run();
        }
    }
}
