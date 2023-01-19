namespace MeuLivroDeReceitas.Domain.Entidades;

public class Usuario : EntidadeBase
{
    public String Nome { get; set; }
    public String Email { get; set; }
    public String Senha { get; set; }
    public String Telefone { get; set; }
}
