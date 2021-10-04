using SimpleSongs.DAL;
using SimpleSongs.Model;
using SimpleSongs.Utilities;
using SimpleSongs.View;
using System;

namespace SimpleSongs.Controller
{
    public class MainMenu : Menu
    {
        private ISongDao SongDao { get; }
        /// <summary>
        /// Initializes main menu
        /// </summary>
        /// <param name="view">MenuView to use</param>
        public MainMenu(IMenuView view, ISongDao songDao) : base(view)
        {
            SongDao = songDao;
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
            Song song = new Song();
            song.Author = UserInput.GetString("Who is the author of the song?", 1, int.MaxValue);
            song.Title = UserInput.GetString("What is the title of the song?", 1, int.MaxValue);
            song.AlbumName = UserInput.GetString("What is the album name of the song?", 1, int.MaxValue);
            song.Length = UserInput.GetInt("What is the song's length in seconds?", 1, int.MaxValue);
            SongDao.AddSong(song);
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
