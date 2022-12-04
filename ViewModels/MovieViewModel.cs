using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Maui.Controls;
using MovieMaui.Views;

namespace MovieMaui.ViewModels
{
    class MovieViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<MovieModel> movieList;
        public ObservableCollection<MovieModel> ShowMovies { get; set; }

        public ObservableCollection<MovieModel> MovieList
        {
            get { return movieList; }
            set { movieList = value; }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        //public ObservableCollection<MovieModel> MovieList { get; set; }
        public MovieViewModel()
        {

            PopulateList();
        }
        public void PopulateList()
        {
            ShowMovies = new ObservableCollection<MovieModel>
            {
                new MovieModel { Title = "model_1", Directors = "Make1", Year = "", Imagepath = "image0.jpeg" },
                new MovieModel { Title = "model_1", Directors = "Make1", Year = "", Imagepath = "image1.jpeg" },
                new MovieModel { Title = "model_1", Directors = "Make1", Year = "", Imagepath = "image1.jpeg" },
                new MovieModel { Title = "model_1", Directors = "Make1", Year = "", Imagepath = "image1.jpeg" },
                new MovieModel { Title = "model_1", Directors = "Make1", Year = "", Imagepath = "image1.jpeg" },
                new MovieModel { Title = "model_1", Directors = "Make1", Year = "", Imagepath = "image1.jpeg" },
                new MovieModel { Title = "model_1", Directors = "Make1", Year = "", Imagepath = "image1.jpeg" },
                new MovieModel { Title = "model_1", Directors = "Make1", Year = "", Imagepath = "image1.jpeg" },
                new MovieModel { Title = "model_1", Directors = "Make1", Year = "", Imagepath = "image1.jpeg" },
                new MovieModel { Title = "model_1", Directors = "Make1", Year = "", Imagepath = "image1.jpeg" },
                new MovieModel { Title = "model_1", Directors = "Make1", Year = "", Imagepath = "image1.jpeg" },
                new MovieModel { Title = "model_1", Directors = "Make1", Year = "", Imagepath = "image1.jpeg" },
                new MovieModel { Title = "model_1", Directors = "Make1", Year = "", Imagepath = "image1.jpeg" },
                new MovieModel { Title = "model_1", Directors = "Make1", Year = "", Imagepath = "image1.jpeg" },
                new MovieModel { Title = "model_1", Directors = "Make1", Year = "", Imagepath = "image1.jpeg" },
                new MovieModel { Title = "model_1", Directors = "Make1", Year = "", Imagepath = "image1.jpeg" },
                new MovieModel { Title = "model_1", Directors = "Make1", Year = "", Imagepath = "image1.jpeg" },
                new MovieModel { Title = "model_1", Directors = "Make1", Year = "", Imagepath = "image2.jpeg" }
            };
        }

        public void OnPropertyChanged([CallerMemberName] string name = "") =>
         PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));


    }
}
