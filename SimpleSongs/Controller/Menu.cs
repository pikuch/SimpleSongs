using SimpleSongs.View;
using System;
using System.Collections.Generic;

namespace SimpleSongs.Controller
{
    public abstract class Menu
    {
        public IMenuView View { get; }
        protected bool IsRunning { get; set; }
        private int _cursor;
        public string Title { get; set; }
        public List<MenuOption> Options { get; }
        
        public Menu(IMenuView view)
        {
            View = view;
            _cursor = 0;
            Options = new List<MenuOption>();
        }

        protected abstract void SetupOptions();

        public void Run()
        {
            SetupOptions();

            IsRunning = true;

            while (IsRunning)
            {
                View.DisplayOptions(Title, Options, _cursor);
                DecodeUserAction();
            }
            
        }

        private void DecodeUserAction()
        {
            ConsoleKey key = Console.ReadKey(true).Key;
            switch (key)
            {
                case ConsoleKey.Enter:
                case ConsoleKey.Spacebar:
                    Options[_cursor].Action();
                    break;
                case ConsoleKey.UpArrow:
                    _cursor = (_cursor > 0) ? _cursor - 1 : Options.Count - 1;
                    break;
                case ConsoleKey.DownArrow:
                    _cursor = (_cursor < Options.Count - 1) ? _cursor + 1 : 0;
                    break;
            }
        }
    }
}