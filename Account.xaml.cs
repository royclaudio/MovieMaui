using Microsoft.Maui.Controls;
using MovieMaui.ViewModels;
using MovieMaui.Views;
using System.Collections.ObjectModel;

namespace MovieMaui;

public partial class Account : ContentPage
{
    //ObservableCollection<Movies> movies = new();
    //public ObservableCollection<Movies> Movies1 { get { return movies; } }
    public Account()
	{
        BindingContext = new MovieViewModel();
        InitializeComponent();

    }

    private void GotoHome(object sender, EventArgs e)
    {
        Navigation.PushAsync(new MainPage());
    }
    private void GotoSearch(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Search());
    }
    private void GotoAccount(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Account());
    }
}