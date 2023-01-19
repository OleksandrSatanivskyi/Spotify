using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify.Models
{
    internal class MusicTrack
    {
        public string Name { get; set; }
        public Artist Creator { get; set; }
        public string SoundtrackPath { get; set; }
        public Genre Genre { get; set; }
        public readonly DateTime CreationDate;

    }
}
