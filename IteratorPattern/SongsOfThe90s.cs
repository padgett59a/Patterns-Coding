using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace IteratorPattern
{
    //Hash Table
    //public class SongsOfThe90s
    //public class SongsOfThe90s : ISongIterator
    public class SongsOfThe90s : IEnumerable
    {
        Dictionary<int, SongInfo> bestSongs;
        //int bsIndex = 0;

        public SongsOfThe90s()
        {
            this.bestSongs = new Dictionary<int, SongInfo>()
            {
                { 0, new SongInfo("Losing", "Losers", 1991)},
                { 1, new SongInfo("Tying", "Shoestrings", 1994) },
                { 2, new SongInfo("Flying", "Wings", 1995) }
            };
        }

        public void addSong(String songName, string bandName, int yearReleased)
        {
            SongInfo newSong = new SongInfo(songName, bandName, yearReleased);
            bestSongs.Add(bestSongs.Count, newSong);
        }

        //public IEnumerator createIterator()
        //{
        //    return bestSongs.Values.GetEnumerator();
        //}

        //OldWay
        public Dictionary<int, SongInfo> getBestSongs()
        {
            return bestSongs;
        }

        public IEnumerator GetEnumerator()
        {
            return bestSongs.Values.GetEnumerator();
        }
    }
}
