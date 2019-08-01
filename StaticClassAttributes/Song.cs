using System;
using System.Collections.Generic;
using System.Text;

namespace StaticClassAttributes
{
    class Song
    {
        public string title; //normal attributes
        public string artist;
        public int duration;
        public static int songCount = 0;

        public Song (string aTitle, string aArtist, int aDuration)
        {
            title = aTitle;
            artist = aArtist;
            duration = aDuration; //constructor 
            songCount++;//so every time a song object gets created the songcount gets incremented
        }

        public int getSongCount()
        {
            return songCount;
        }

    }
}
