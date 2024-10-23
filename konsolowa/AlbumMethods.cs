using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace konsolowa
{
    public class AlbumMethods
    {
        string path = "./Data.txt";

        List<AlbumData> albumDatas = new List<AlbumData>();

        public List<AlbumData> GetDataFromFile()
        {
            if(File.Exists(path))
            {
                string[] lines = File.ReadAllLines(path).Where(e=>e!="").ToArray();

                for(int i = 0; i < lines.Length; i+=5)
                {
                    AlbumData newAlbumData = new()
                    {
                        artist = lines[i],
                        album = lines[i+1],
                        songsNumber = int.Parse(lines[i+2]),
                        year = int.Parse(lines[i+3]),
                        dowlandNumber = int.Parse(lines[i+4]),
                    };
                    albumDatas.Add(newAlbumData);
                }
            }
            return albumDatas;
        }
    }
}
