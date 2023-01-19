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

        public Song(string name, Artist creator, string soundtrackPath, Genre genre, DateTime creationDate, TimeSpan duration)
        {
            Name = name;
            Creator = creator;
            SoundtrackPath = soundtrackPath;
            Genre = genre;
            CreationDate = creationDate;
            Duration = duration;
        }

        public Song() : this("", new Artist(), "", new Genre(), new DateTime(), new TimeSpan()) { }


    }



    public enum Genre { }
}
