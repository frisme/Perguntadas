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
	private async Task<bool> Douglas()
    {
      await DisplayAlert( "Atenção", "O jogo vai começar, cuidado com seu saldo bancário.", "OK");
            return false;
	}

}