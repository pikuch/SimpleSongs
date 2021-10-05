using NUnit.Framework;
using SimpleSongs.Controller;
using SimpleSongs.Model;

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

        [Test]
        public void SongVerifier_ReturnsSongTitleIsEmptyMessage_WhenSongTitleIsNull()
        {
            Song song = new Song { Title = null, Author = "a", AlbumName = "b", Length = 1 };
            string actual = SongVerifier.Verify(song);
            string expected = "Song title is empty";

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void SongVerifier_ReturnsSongTitleIsEmptyMessage_WhenSongTitleHasLength0()
        {
            Song song = new Song { Title = string.Empty, Author = "a", AlbumName = "b", Length = 1 };
            string actual = SongVerifier.Verify(song);
            string expected = "Song title is empty";

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void SongVerifier_ReturnsSongAuthorIsEmptyMessage_WhenSongAuthorIsNull()
        {
            Song song = new Song { Title = "a", Author = null, AlbumName = "b", Length = 1 };
            string actual = SongVerifier.Verify(song);
            string expected = "Song author is empty";

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void SongVerifier_ReturnsSongAuthorIsEmptyMessage_WhenSongAuthorHasLength0()
        {
            Song song = new Song { Title = "a", Author = string.Empty, AlbumName = "b", Length = 1 };
            string actual = SongVerifier.Verify(song);
            string expected = "Song author is empty";

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void SongVerifier_ReturnsSongAlbumNameIsEmptyMessage_WhenSongAlbumNameIsNull()
        {
            Song song = new Song { Title = "a", Author = "b", AlbumName = null, Length = 1 };
            string actual = SongVerifier.Verify(song);
            string expected = "Album name is empty";

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void SongVerifier_ReturnsSongAlbumNameIsEmptyMessage_WhenSongAlbumNameHasLength0()
        {
            Song song = new Song { Title = "a", Author = "b", AlbumName = string.Empty, Length = 1 };
            string actual = SongVerifier.Verify(song);
            string expected = "Album name is empty";

            Assert.AreEqual(expected, actual);
        }

        [TestCase(-1)]
        [TestCase(0)]
        [TestCase(0.9)]
        public void SongVerifier_ReturnsSongLengthBelowOneSecondMessage_WhenSongLengthIsBelowOneSecond(double length)
        {
            Song song = new Song { Title = "a", Author = "b", AlbumName = "c", Length = length };
            string actual = SongVerifier.Verify(song);
            string expected = "Song length is below one second";

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void SongVerifier_ReturnsOKMessage_WhenSongDataIsValid()
        {
            Song song = new Song { Title = "a", Author = "b", AlbumName = "c", Length = 10 };
            string actual = SongVerifier.Verify(song);
            string expected = "OK";

            Assert.AreEqual(expected, actual);
        }
    }
}