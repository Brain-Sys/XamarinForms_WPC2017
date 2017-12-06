using Netflix.ViewModels;
using Plugin.MediaManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Netflix
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VideoPage : ContentPage
    {
        private Movie movie;
        public Movie Movie
        {
            get { return movie; }
            set { movie = value; this.Title = movie.Title; }
        }

        public VideoPage()
        {
            InitializeComponent();
            this.Appearing += VideoPage_Appearing;
        }

        private async void VideoPage_Appearing(object sender, EventArgs e)
        {
            try
            {
                string oldUrl = "https://wpc-netflix-apis.azurewebsites.net/videostream?id=1";
                string url1 = "http://www.montemagno.com/sample.mp3";
                string url2 = "http://techslides.com/demos/sample-videos/small.mp4";
                //await CrossMediaManager.Current.Play(url2, Plugin.MediaManager.Abstractions.Enums.MediaFileType.Video, Plugin.MediaManager.Abstractions.Enums.ResourceAvailability.Remote);
                this.Player.Source = new Uri(oldUrl);
            }
            catch (Exception ex)
            {

            }
        }
    }
}