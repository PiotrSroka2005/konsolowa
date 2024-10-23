namespace konsolowa
{
    public class Program
    {
        static void Main(string[] args)
        {
            AlbumMethods album = new AlbumMethods();

            album.DisplyAlbumData(album.GetDataFromFile());
        }
    }
}
