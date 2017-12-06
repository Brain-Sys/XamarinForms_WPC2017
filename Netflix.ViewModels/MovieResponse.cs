using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netflix.ViewModels
{
    public class MovieResponse
    {
        public bool HasNextPage { get; set; }
        public bool HasPreviousPage { get; set; }
        public int PageIndex { get; set; }
        public int PageSize { get; set; }
        public int TotalCount { get; set; }
        public int TotalPages { get; set; }

        public List<Movie> Result { get; set; }
    }

    public class Movie : ObservableObject
    {
        private string id;
        public string ID
        {
            get { return id; }
            set { id = value; base.RaisePropertyChanged(); }
        }

        private string title;
        public string Title
        {
            get { return title; }
            set { title = value; base.RaisePropertyChanged(); }
        }

        private int year;
        public int Year
        {
            get { return year; }
            set { year = value; base.RaisePropertyChanged(); }
        }

        private double? rating;
        public double? Rating
        {
            get { return rating; }
            set { rating = value; base.RaisePropertyChanged(); }
        }

        private Poster poster;
        public Poster Poster
        {
            get { return poster; }
            set { poster = value; base.RaisePropertyChanged(); }
        }
    }
}