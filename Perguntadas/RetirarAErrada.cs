using Perguntadas;

public class RetirarAErradas : IAjuda
{
    public override void RealizaAjuda(Questao questao)
    {
        switch(questao.RespostaCerta)
        {
            case 1:
                buttonResposta02.IsVisible = false;
                buttonResposta03.IsVisible = false;
                buttonResposta04.IsVisible = false;

                break;

            case 2:  
                buttonResposta01.IsVisible = false;
                buttonResposta03.IsVisible = false;
                buttonResposta05.IsVisible = false;

                break;

            case 3:
                buttonResposta01.IsVisible = false;
                buttonResposta02.IsVisible = false;
                buttonResposta03.IsVisible = false;

                break;

            case 4:
                buttonResposta03.IsVisible = false;
                buttonResposta04.IsVisible = false;
                buttonResposta05.IsVisible = false;

                break;

            case 5:
                buttonResposta02.IsVisible = false;
                buttonResposta03.IsVisible = false;
                buttonResposta05.IsVisible = false;

                break;
        }
    }
}