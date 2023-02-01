using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Spotify.Models
{
    public class Song: INotifyPropertyChanged
    {
        public string name;
        public Artist Creator { get; set; }
        public string SoundtrackPath { get; set; }
        public Genre Genre { get; set; }
        public readonly DateTime CreationDate;
        public TimeSpan Duration { get; set; }
        public BitmapImage image;

        public string Name
        {
            get => name;
            set
            {
                name = value;
                OnPropertyChanged("Name");
            }
        }

        public BitmapImage Image
        {
            get => image;
            set
            {
                image = value;
                OnPropertyChanged("Image");
            }
        }

        public Song(string name, Artist creator, string soundtrackPath, Genre genre, DateTime creationDate, TimeSpan duration, string imSource)
        {
            Name = name;
            Creator = creator;
            SoundtrackPath = soundtrackPath;
            Genre = genre;
            CreationDate = creationDate;
            Duration = duration;
            var path = new DirectoryInfo(Environment.CurrentDirectory).Parent.Parent.Parent + "\\Views\\Resources\\" + imSource;
            Image = new BitmapImage(new Uri(imSource));
        }

        public Song() : this("", new Artist(), "", new Genre(), new DateTime(), new TimeSpan(), "") { }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }



    public enum Genre { }
}
