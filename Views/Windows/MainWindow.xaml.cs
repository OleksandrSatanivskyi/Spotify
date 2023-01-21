using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Spotify
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
             
            ImageBrush imageBrush = new ImageBrush();
            var a = new DirectoryInfo(Environment.CurrentDirectory).Parent.Parent.Parent + "\\Views\\Resources\\Spotify_Logo_RGB_White.png";
            imageBrush.ImageSource = new BitmapImage(new Uri(a));
            logo.Source = new BitmapImage(new Uri(a));
        }
    }
}
