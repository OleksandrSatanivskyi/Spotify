using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify.Models
{
    public class Song
    {
        public string Name { get; set; }
        public Artist Creator { get; set; }
        public string SoundtrackPath { get; set; }
        public Genre Genre { get; set; }
        public readonly DateTime CreationDate;
        public TimeSpan Duration { get; set; }
    }



    public enum Genre { }
}
