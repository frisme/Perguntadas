namespace Perguntadas;

public class Questao
{

    public string Pergunta;
    public string Resposta1;
    public string Resposta2;
    public string Resposta3;
    public string Resposta4;
    public string Resposta5;

    public int RespostaCerta;
    public int NivelResposta;

    private Label LabelPergunta;

    private Button ButtonResposta01;
    private Button ButtonResposta02;
    private Button ButtonResposta03;
    private Button ButtonResposta04;
    private Button ButtonResposta05;

    public Questao()
    {
        
    }

    public Questao(Label labelpergunta, Button button1, Button button2, Button button3, Button button4, Button button5)
    {
        LabelPergunta = labelpergunta;
        ButtonResposta01 = button1;
        ButtonResposta02 = button2;
        ButtonResposta03 = button3;
        ButtonResposta04 = button4;
        ButtonResposta05 = button5;
    }

    public void ConfiguraEstruturaDesenho (Label labelpergunta, Button button1, Button button2, Button button3, Button button4, Button button5)
    {
        LabelPergunta = labelpergunta;
        ButtonResposta01 = button1;
        ButtonResposta02 = button2;
        ButtonResposta03 = button3;
        ButtonResposta04 = button4;
        ButtonResposta05 = button5;
    }

    public void Desenhar()
    {
        LabelPergunta.Text = Pergunta;
        ButtonResposta01.Text = Resposta1;
        ButtonResposta02.Text = Resposta2;
        ButtonResposta03.Text = Resposta3;
        ButtonResposta04.Text = Resposta4;
        ButtonResposta05.Text = Resposta5;
    }

    private Button QualButton(int r)
    {
        if(r == 1){
            return ButtonResposta01;
        }
        else if(r == 2){
            return ButtonResposta02;
        }
        else if (r == 3){
            return ButtonResposta03;
        }
        else if (r == 4){
            return ButtonResposta04;
        }
        else if (r == 5 ){
            return ButtonResposta05;
        }
        else{
            return null;
        }
    }

    public bool VerificaResposta(int rr)
    {
        if(RespostaCerta == rr)
        {
            var button = QualButton(rr);
            button.BackgroundColor = Colors.Green; //"#a1c9ae";
            return true;
        }
        else
        {
            var buttonCorreto = QualButton(RespostaCerta);
            var buttonIncorreto = QualButton(rr);
            buttonCorreto.BackgroundColor = Colors.Green; //"#a1c9ae";
            buttonIncorreto.BackgroundColor = Colors.Red; //#e88e8e;

            return false;
        }
    }
    
}