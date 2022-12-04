using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MovieMaui.ViewModels
{
    internal class MovieCollectionsViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public ICommand NewCommand { private set; get; }
        public ICommand SubmitCommand { private set; get; }
        public ICommand CancelCommand { private set; get; }
        public IList<MovieViewModel> Persons { get; } = new ObservableCollection<MovieViewModel>();
        public MovieCollectionsViewModel()
        {
            //Persons.Add(new MovieViewModel());
            //Persons.Add(new MovieViewModel());
        }
        //[ObservableProperty]
        public ObservableCollection<MovieViewModel> Movielist = new()
        {
            //new MovieViewModel("","",""),
            //new MovieViewModel("","",""),
            //new MovieViewModel("","",""),
            
        };

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


    }
}
