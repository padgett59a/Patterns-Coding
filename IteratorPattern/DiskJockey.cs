using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    public class DiskJockey
    {
        IEnumerable songs70s;
        IEnumerable songs80s;
        IEnumerable songs90s;

        public DiskJockey(IEnumerable p70sSongs, IEnumerable p80sSongs, IEnumerable p90sSongs)
        {
            this.songs70s = p70sSongs;
            this.songs80s = p80sSongs;
            this.songs90s = p90sSongs;
        }

        //Before Pattern
        //public void showTheSongs()
        //{
        //    //OLD WAY before Iterator Pattern
        //    List<SongInfo> list70songs = this.songs70s.getBestSongs();
        //    Console.WriteLine($"\nSongs of the 70s");
        //    list70songs.ForEach(s => Console.WriteLine($"Song: {s.songName} by {s.bandName} from year {s.yearReleased}."));

        //    SongInfo[] arr80songs = this.songs80s.getBestSongs();
        //    Console.WriteLine($"\nSongs of the 80s");
        //    foreach (SongInfo s in arr80songs) {
        //        Console.WriteLine($"Song: {s.songName} by {s.bandName} from year {s.yearReleased}.");
        //    }

        //    Dictionary<int, SongInfo> dict90songs = this.songs90s.getBestSongs();
        //    Console.WriteLine($"\nSongs of the 90s");
        //    dict90songs.ToList().ForEach(s => Console.WriteLine($"Song: {s.Value.songName} by {s.Value.bandName} from year {s.Value.yearReleased}."));
        //}

        //New Way
        public void showSongsViaIterators()
        {
            IEnumerator s70sIterator = this.songs70s.GetEnumerator();
            IEnumerator s80sIterator = this.songs80s.GetEnumerator();
            IEnumerator s90sIterator = this.songs90s.GetEnumerator();

            Console.WriteLine($"\nSongs of the 70s");
            printTheSongs(s70sIterator);

            Console.WriteLine($"\nSongs of the 80s");
            printTheSongs(s80sIterator);

            Console.WriteLine($"\nSongs of the 90s");
            printTheSongs(s90sIterator);

        }

        public void printTheSongs(IEnumerator pIterator)
        {
            while (pIterator.MoveNext())
            {
                SongInfo cSong = (SongInfo)pIterator.Current;
                Console.WriteLine($"Song: {cSong.songName} by {cSong.bandName} from year {cSong.yearReleased}.");
            }
        }
    }
}
