namespace Perguntadas;

public partial class GamePage : ContentPage
{

    Gerenciador gerenciador;
    public GamePage()
    {
        InitializeComponent();

        gerenciador = new Gerenciador(labelPergunta, buttonResposta01, buttonResposta02, buttonResposta03, buttonResposta04, buttonResposta05);

        gerenciador = ProximaQuestao();
    }

    // Evento de clique das respostas
    private void OnRespostaClicked(object sender, EventArgs e)
    {
        gerenciador.VerificaCorreta(1);
        gerenciador.VerificaCorreta(2);
        gerenciador.VerificaCorreta(3);
        gerenciador.VerificaCorreta(4);
        gerenciador.VerificaCorreta(5);
    }
}