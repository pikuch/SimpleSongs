using SimpleSongs.Controller;
using System;
using System.Collections.Generic;

namespace SimpleSongs.View
{
    class MenuView : IMenuView
    {
        const ConsoleColor _normalColor = ConsoleColor.Gray;
        const ConsoleColor _activeColor = ConsoleColor.Cyan;

        void IMenuView.DisplayOptions(string title, List<MenuOption> options, int cursor)
        {
            Console.Clear();
            Console.WriteLine(title);
            for (int index = 0; index < options.Count; index++)
            {
                DisplayMenuOption(options[index], index == cursor);
            }
            Console.ForegroundColor = _normalColor;
        }

        private void DisplayMenuOption(MenuOption menuOption, bool isCurrent)
        {
            Console.ForegroundColor = isCurrent ? _activeColor : _normalColor;
            Console.WriteLine(menuOption);
        }
    }
}
