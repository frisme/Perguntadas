namespace Perguntadas;

public partial class GamePage : ContentPage
{
    Gerenciador gerenciador;
	public GamePage()
    {
        InitializeComponent();

        gerenciador = new Gerenciador(labelPergunta, buttonResposta01, buttonResposta02, buttonResposta03, buttonResposta04, buttonResposta05);
        gerenciador.ProximaQuestao();
    }

    void OnRespostaClicked01(object sender, EventArgs args){
        gerenciador.VerificaCorreta(1);
    }

    void OnRespostaClicked02(object sender, EventArgs args){
        gerenciador.VerificaCorreta(2);
    }
    
    void OnRespostaClicked03(object sender, EventArgs args){
        gerenciador.VerificaCorreta(3);
    }
    
    void OnRespostaClicked04(object sender, EventArgs args){
        gerenciador.VerificaCorreta(4);
    }
    
    void OnRespostaClicked05(object sender, EventArgs e){
        gerenciador.VerificaCorreta(5);
    }

    public void Julim(object sender, EventArgs e)
	{
		Navigation.PushAsync(new MainPage());
	}
}