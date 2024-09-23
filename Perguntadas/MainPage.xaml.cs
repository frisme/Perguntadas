namespace Perguntadas;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}
	public void Douglas(object sender, EventArgs e)
	{
		Navigation.PushAsync(new GamePage());
	}
}
