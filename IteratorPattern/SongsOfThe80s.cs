using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace IteratorPattern
{
    //SongInfo Array
    //public class SongsOfThe80s
    public class SongsOfThe80s : IEnumerable
    {
        SongInfo[] bestSongs;
        int bsIndex = 0;

        public SongsOfThe80s()
        {
            this.bestSongs = new SongInfo[]
            {
                new SongInfo("Roam", "B52s", 1989),
                new SongInfo("Cruel Summer", "Bananarama", 1984),
                new SongInfo("Head Over Heels", "Tears for Fears", 1985)
            };
        }

        public void addSong(String songName, string bandName, int yearReleased)
        {
            SongInfo newSong = new SongInfo(songName, bandName, yearReleased);
            bestSongs.Append(newSong);
        }

        //public IEnumerator createIterator()
        //{
        //    return bestSongs.GetEnumerator();
        //}

        //OldWay
        public SongInfo[] getBestSongs()
        {
            return bestSongs;
        }
        public IEnumerator GetEnumerator()
        {
            return bestSongs.GetEnumerator();
        }

    }
}
