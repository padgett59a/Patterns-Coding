using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    public class SongInfo
    {
        public string songName {get; set;}
        public string bandName { get; set; }
        public int yearReleased{ get; set; }

        public SongInfo(string pSongName, string pBandName, int pYearReleased)
        {
            this.songName = pSongName;
            this.bandName = pBandName;
            this.yearReleased = pYearReleased;
        }

    }
}
