using Spotify.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Spotify.ViewModels
{
    class SongsViewModel: INotifyPropertyChanged
    {
        public ObservableCollection<Song> Songs { get; set; }


        public event PropertyChangedEventHandler PropertyChanged;

        public SongsViewModel()
        {
            Songs= new ObservableCollection<Song>();
        }

        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
