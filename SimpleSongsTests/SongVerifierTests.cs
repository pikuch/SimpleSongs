using NUnit.Framework;
using SimpleSongs.Controller;

namespace SimpleSongsTests
{
    public class SongVerifierTests
    {
        [Test]
        public void SongVerifier_ReturnsSongIsNullMessage_WhenSongIsNull()
        {
            string actual = SongVerifier.Verify(null);
            string expected = "Song is null";

            Assert.AreEqual(expected, actual);
        }
    }
}