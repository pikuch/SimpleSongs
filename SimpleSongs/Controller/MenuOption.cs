using System;

namespace SimpleSongs.Controller
{
    public class MenuOption
    {
        public string Name { get; }
        public Action Action { get; }
        public MenuOption(string name, Action action)
        {
            Name = name;
            Action = action;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
