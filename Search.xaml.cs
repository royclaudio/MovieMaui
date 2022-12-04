namespace MovieMaui;

public partial class Search : ContentPage
{
	public Search()
	{
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