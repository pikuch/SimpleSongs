using SimpleSongs.DAL;
using SimpleSongs.Model;
using SimpleSongs.View;
using System;

namespace SimpleSongs.Controller
{
    public class SongMenu : Menu
    {
        public SongMenu(IMenuView view) : base(view)
        {
        }

        protected override void SetupOptions()
        {
            Title = "Which song to delete?";
            SongDao songDao = new SongDao();
            var songs = songDao.GetAllSongs();
            foreach (var song in songs)
            {
                Options.Add(new MenuOption(song.ToString(), () => DeleteSong(song)));
            }
        }

        private void DeleteSong(Song song)
        {
            SongDao songDao = new SongDao();
            songDao.DeleteSong(song);
            IsRunning = false;
        }
    }
}
