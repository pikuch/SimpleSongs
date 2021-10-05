using SimpleSongs.Model;

namespace SimpleSongs.Controller
{
    public static class SongVerifier
    {
        public static string Verify(Song song)
        {
            if (song == null)
            {
                return "Song is null";
            }
            if (song.Title == null || (song.Title != null && song.Title.Length == 0))
            {
                return "Song title is empty";
            }
            if (song.Author == null || (song.Author != null && song.Author.Length == 0))
            {
                return "Song author is empty";
            }


            return "OK";
        }
    }
}
