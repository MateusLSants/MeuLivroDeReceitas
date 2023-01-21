namespace MeuLivroDeReceitas.Comunicacao.Resposta;

public class RespostaErroJson
{
    public List<string> Messagens { get; set; }

    public RespostaErroJson(string mesagem)
    {
        Messagens = new List<string>
        {
            mesagem
        }; 
    }

    public RespostaErroJson(List<string> mesagens)
    {
        Messagens = mesagens;
    }
}
