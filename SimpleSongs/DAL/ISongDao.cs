using SimpleSongs.Model;
using System.Collections.Generic;

namespace SimpleSongs.DAL
{
    public interface ISongDao
    {
        public void AddSong(Song song);
        IList<Song> GetAllSongs();
    }
}
