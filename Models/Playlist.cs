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
        public int SongsCount { get; set; }
        public int Duration { get; set; }
    }
}
