namespace MeuLivroDeReceitas.Exception.ExceptionsBase;

public class ErrosDeValidacaoException : MeuLivroDeReceitasException
{
    public List<String> MessagensDeErro { get; set; }

    public ErrosDeValidacaoException(List<string> messagensDeErro)
    {
        MessagensDeErro = messagensDeErro;
    }
}
