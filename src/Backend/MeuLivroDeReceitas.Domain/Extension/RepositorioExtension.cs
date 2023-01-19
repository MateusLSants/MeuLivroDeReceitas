using Microsoft.Extensions.Configuration;

namespace MeuLivroDeReceitas.Domain.Extension;

public static class RepositorioExtension
{
    public static string GetConexao(this IConfiguration configurationManager)
    {
        var conexao = configurationManager.GetConnectionString("Conexao");

        return conexao;
    }

    public static string GetNomeDataBase(this IConfiguration configurationManager)
    {
        var nomeDataBase = configurationManager.GetConnectionString("NomeDataBase");

        return nomeDataBase;
    }

    public static string GetConexaoCompleta(this IConfiguration configurationManger)
    {
        var nomeDataBase = configurationManger.GetNomeDataBase();
        var conexao = configurationManger.GetConexao();

        return $"{conexao}Database={nomeDataBase}";
    }
}
