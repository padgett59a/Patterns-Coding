using System;

namespace IteratorPattern
{
    class Program //Radio Staion
    {
        static void Main(string[] args)
        {
            //Note ctors are seeding these collections
            SongsOfThe70s n70songs = new SongsOfThe70s();
            SongsOfThe80s n80songs = new SongsOfThe80s();
            SongsOfThe90s n90songs = new SongsOfThe90s();

            DiskJockey myDJ = new DiskJockey(n70songs, n80songs, n90songs);
            myDJ.showSongsViaIterators();
        }
    }
}
