namespace SimpleSongs.Model
{
    /// <summary>
    /// Song model for database mapping
    /// </summary>
    public class Song
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string AlbumName { get; set; }
        public double Length { get; set; }
        public override string ToString()
        {
            return $"[{Id}] Title: {Title} Author: {Author} AlbumName: {AlbumName} Length: {Length}s";
        }
    }
}
