using Microsoft.Maui.Controls.Shapes;

namespace MovieMaui;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
        Title.Text = "Harry Potter and the Philosopher's Stone";
        Year.Text = "1997";
        Director.Text = "J.K. Rowling";

	}

	
    private void Liked(object sender, EventArgs e)
    {
        count++;
        Images.Source = "image1.jpeg";
        Title.Text = "Movie1";
        Year.Text = "year1";
        Director.Text = "director1";
   
    }
    private void Disliked(object sender, EventArgs e)
    {
        count++;
        Images.Source = "image2.jpeg";
        Title.Text = "Movie2";
        Year.Text = "year2";
        Director.Text = "director2";
     
    }
    private void GotoSearch(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Search());
    }
    private void GotoHome(object sender, EventArgs e)
    {
        Navigation.PushAsync(new MainPage());
    }
    private void GotoAccount(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Account());
    }
}

