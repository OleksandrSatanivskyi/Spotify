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

        public Artist(string fullName, string email, string password, List<Playlist> playlists, List<Song> likedSongs, List<Song> createdSingleSongs, List<Playlist> createdPlaylists)
        {
            FullName = fullName;
            Email = email;
            Password = password;
            Playlists = playlists;
            LikedSongs = likedSongs;
            CreatedSingleSongs = createdSingleSongs;
            CreatedPlaylists = createdPlaylists;
        }

        public Artist(): this("", "", "", new List<Playlist>(), new List<Song>(), new List<Song>(), new List<Playlist>()) { }
    }
}
