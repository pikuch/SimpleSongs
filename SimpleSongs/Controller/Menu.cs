using SimpleSongs.View;
using System;
using System.Collections.Generic;

namespace SimpleSongs.Controller
{
    internal abstract class Menu
    {
        private IMenuView _view;
        private bool _isRunning;
        private int _cursor;
        public string Title { get; set; }
        public List<MenuOption> Options { get; }
        
        public Menu(MenuView view)
        {
            _view = view;
            _cursor = 0;
        }

        protected abstract void SetupOptions();

        public void Run()
        {
            SetupOptions();

            _isRunning = true;

            while (_isRunning)
            {
                _view.DisplayOptions(Title, Options, _cursor);
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
                    _cursor = (_cursor > 0) ? 0 : Options.Count - 1;
                    break;
                case ConsoleKey.DownArrow:
                    _cursor = (_cursor < Options.Count - 1) ? _cursor + 1 : 0;
                    break;
            }
        }
    }
}