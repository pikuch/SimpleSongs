using SimpleSongs.Model;
using System.Collections.Generic;

namespace SimpleSongs.DAL
{
    public interface ISongDao
    {
        public void AddSong(Song song);
        IList<Song> GetAllSongs();
        IList<Song> GetAllSongsSorted();

        public void DeleteSong(Song song);
    }
}
