using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace IteratorPattern
{
    //List<SongInfo>
    public class SongsOfThe70s : IEnumerable
    {
        List<SongInfo> bestSongs;

        public SongsOfThe70s()
        {
            this.bestSongs = new List<SongInfo>()
            {
                new SongInfo("Imagine", "John Lennon", 1971),
                new SongInfo("American Pie", "Don McLean", 1971),
                new SongInfo("I Will Survive", "Gloria Gaynor", 1971)
            };
        }

        public void addSong(String songName, string bandName, int yearReleased)
        {
            SongInfo newSong = new SongInfo(songName, bandName, yearReleased);
            bestSongs.Add(newSong);
        }

        //public IEnumerator createIterator()
        //{
        //    return bestSongs.GetEnumerator();
        //}

        //OLD WAY
        public List<SongInfo> getBestSongs()
        {
            return bestSongs;
        }
        public IEnumerator GetEnumerator()
        {
            return bestSongs.GetEnumerator();
        }
    }
}
