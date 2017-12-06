using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Netflix.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private int count;
        public int Count
        {
            get { return count; }
            set { count = value;
                base.RaisePropertyChanged();
            }
        }

        private List<Movie> items;
        public List<Movie> Items
        {
            get { return items; }
            set { items = value; base.RaisePropertyChanged(); }
        }

        public RelayCommand DownloadFilmCommand { get; set; }

        public MainViewModel()
        {
            this.DownloadFilmCommand = new RelayCommand(DownloadFilmCommandExecute);
        }

        private async void DownloadFilmCommandExecute()
        {
            try
            {
                HttpClient client = new HttpClient();
                var json = await client.GetStringAsync
                    ("https://wpc-netflix-apis.azurewebsites.net/v2/Movies/GetMovies");
                MovieResponse response = JsonConvert.DeserializeObject<MovieResponse>(json);

                this.Count = response.TotalCount;
                this.Items = response.Result;
            }
            catch (Exception ex)
            {

            }
        }
    }
}