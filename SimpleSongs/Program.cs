using SimpleSongs.Controller;
using SimpleSongs.DAL;
using SimpleSongs.View;

namespace SimpleSongs
{
    class Program
    {
        static void Main(string[] args)
        {
            var mainMenu = new MainMenu(new MenuView());
            mainMenu.Run();
        }
    }
}
