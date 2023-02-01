using Spotify.Models;
using Spotify.ViewModels;
using System;
using System.IO;
using System.Windows.Controls;


namespace Spotify.Views
{
    /// <summary>
    /// Interaction logic for MediaList.xaml
    /// </summary>
    public partial class MediaList : UserControl
    {
        public MediaList()
        {
            InitializeComponent();
            var l = new SongsViewModel();
            l.Songs.Add(new Song("Super song", new Artist(), "", new Genre(), DateTime.Today, new TimeSpan(100), new DirectoryInfo(Environment.CurrentDirectory).Parent.Parent.Parent + "\\Views\\Resources\\Spotify_Logo_RGB_White.png"));

            l.Songs.Add(new Song("Super song", new Artist(), "", new Genre(), DateTime.Today, new TimeSpan(100), new DirectoryInfo(Environment.CurrentDirectory).Parent.Parent.Parent + "\\Views\\Resources\\Spotify_Logo_RGB_White.png"));
            l.Songs.Add(new Song("Super song", new Artist(), "", new Genre(), DateTime.Today, new TimeSpan(100), new DirectoryInfo(Environment.CurrentDirectory).Parent.Parent.Parent + "\\Views\\Resources\\Spotify_Logo_RGB_White.png"));
            l.Songs.Add(new Song("Super song", new Artist(), "", new Genre(), DateTime.Today, new TimeSpan(100), new DirectoryInfo(Environment.CurrentDirectory).Parent.Parent.Parent + "\\Views\\Resources\\Spotify_Logo_RGB_White.png"));
            l.Songs.Add(new Song("Super song", new Artist(), "", new Genre(), DateTime.Today, new TimeSpan(100), new DirectoryInfo(Environment.CurrentDirectory).Parent.Parent.Parent + "\\Views\\Resources\\Spotify_Logo_RGB_White.png"));
            l.Songs.Add(new Song("Super song", new Artist(), "", new Genre(), DateTime.Today, new TimeSpan(100), new DirectoryInfo(Environment.CurrentDirectory).Parent.Parent.Parent + "\\Views\\Resources\\Spotify_Logo_RGB_White.png"));
            l.Songs.Add(new Song("Super song", new Artist(), "", new Genre(), DateTime.Today, new TimeSpan(100), new DirectoryInfo(Environment.CurrentDirectory).Parent.Parent.Parent + "\\Views\\Resources\\Spotify_Logo_RGB_White.png"));

            DataContext = l;
        }
    }
}
