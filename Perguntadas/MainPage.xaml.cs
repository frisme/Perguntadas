namespace Perguntadas;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}
	public void Douglas()
	{
		Navigation.PushAsync(new GamePage());
	}
}
