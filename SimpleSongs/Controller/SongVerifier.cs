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

            return "OK";
        }
    }
}
