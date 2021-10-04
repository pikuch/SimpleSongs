using SimpleSongs.Controller;
using System.Collections.Generic;

namespace SimpleSongs.View
{
    /// <summary>
    /// Menu view interface
    /// </summary>
    public interface IMenuView
    {
        internal void DisplayOptions(string title, List<MenuOption> options, int cursor);
    }
}
