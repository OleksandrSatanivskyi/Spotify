using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify.Models
{
    public class Playlist
    {
        public string Name { get; set; }
        public List<Song> Songs { get; set; }
        public int SongsCount => Songs.Count;
        public TimeSpan Duration { get; set; }

        public Playlist(string name, List<Song> songs)
        {
            Name = name;
            Songs = songs;
            Duration = new TimeSpan();
            for (int i = 0; i < Songs.Count; i++)
                Duration += Songs[i].Duration;
        }

        public Playlist() : this("", new List<Song>()) { }
    }
}
