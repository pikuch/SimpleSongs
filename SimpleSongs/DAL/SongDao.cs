using SimpleSongs.Model;
using System.Collections.Generic;
using System.Linq;

namespace SimpleSongs.DAL
{
    /// <summary>
    /// Provides data access methods for songs
    /// </summary>
    public class SongDao : ISongDao
    {
        /// <summary>
        /// Add a new song to the database
        /// </summary>
        /// <param name="song">song to add</param>
        public void AddSong(Song song)
        {
            using (var context = new SimpleSongsDbContext())
            {
                context.Songs.Add(song);
                context.SaveChanges();
            }
        }

        public IList<Song> GetAllSongs()
        {
            using (var context = new SimpleSongsDbContext())
            {
                return context.Songs.ToList();
            }
        }
    }
}
