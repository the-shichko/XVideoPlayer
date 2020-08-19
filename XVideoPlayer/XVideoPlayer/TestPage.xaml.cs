using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XVideoPlayer.VideoClasses;

namespace XVideoPlayer
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TestPage : ContentPage
    {
        public TestPage()
        {
            InitializeComponent();

            BindingContext = new ViewModel("https://scontent-frx5-1.cdninstagram.com/v/t50.12441-16/117820066_226016672092512_1757045097407744760_n.mp4?cb=ae824530-94c5e946&efg=eyJxZV9ncm91cHMiOiJbXCJpZ19wcm9ncmVzc2l2ZV91cmxnZW4ucHJvZHVjdF90eXBlLnN0b3J5XCJdIn0&_nc_ht=scontent-frx5-1.cdninstagram.com&_nc_cat=100&_nc_ohc=KrGSEtnDB4IAX-QKxTW&oe=5F3F772C&oh=add7733328a77d34f8cbea0ca36b48db");
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            if ((sender as VideoPlayer).Status != VideoStatus.Playing)
                (sender as VideoPlayer).Play();
            else
                (sender as VideoPlayer).Pause();
        }
    }

    public class ViewModel
    {
        public ViewModel(string uri)
        {
            UriSource = new UriVideoSource()
            {
                Uri = uri
            };
        }
        public UriVideoSource UriSource { get; protected set; }
    }
}