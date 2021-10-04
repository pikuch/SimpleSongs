using SimpleSongs.View;
using System;

namespace SimpleSongs.Controller
{
    public class MainMenu : Menu
    {
        /// <summary>
        /// Initializes main menu
        /// </summary>
        /// <param name="view">MenuView to use</param>
        public MainMenu(IMenuView view) : base(view)
        {
        }

        protected override void SetupOptions()
        {
            Title = "Choose an option";
            Options.Add(new MenuOption("Add a new song", AddNewSong));
            Options.Add(new MenuOption("Delete existing song", DeleteExistingSong));
            Options.Add(new MenuOption("Display song", DisplaySong));
            Options.Add(new MenuOption("Display all songs", DisplayAllSongs));
            Options.Add(new MenuOption("Sort songs by titles", SortByTitles));
            Options.Add(new MenuOption("Exit", ExitMenu));
        }

        protected void AddNewSong()
        {
            throw new NotImplementedException();
        }

        protected void DeleteExistingSong()
        {
            throw new NotImplementedException();
        }

        protected void DisplaySong()
        {
            throw new NotImplementedException();
        }

        protected void DisplayAllSongs()
        {
            throw new NotImplementedException();
        }

        protected void SortByTitles()
        {
            throw new NotImplementedException();
        }
        protected void ExitMenu()
        {
            IsRunning = false;
        }
    }
}
