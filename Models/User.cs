using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify.Models
{
    public class User
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public List<Playlist> Playlists { get; set; }
        public List<Song> LikedSongs { get; set; }

        public User(string fullName, string email, string password, List<Playlist> playlists, List<Song> likedSongs)
        {
            FullName = fullName;
            Email = email;
            Password = password;
            Playlists = playlists;
            LikedSongs = likedSongs;
        }

        public User(): this("", "", "", new List<Playlist>(), new List<Song>()) { }
    }
}
