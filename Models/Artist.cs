using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify.Models
{
    public class Artist: User
    {
        public List<Song> CreatedSingleSongs { get; set; }
        public List<Playlist> CreatedPlaylists { get; set; }
    }
}
