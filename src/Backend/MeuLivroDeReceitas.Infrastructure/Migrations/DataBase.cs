using Dapper;
using MySqlConnector;

namespace MeuLivroDeReceitas.Infrastructure.Migrations;

public static class DataBase
{
    public static void CriarDataBase(string conexaoBancoDeDados, string nomeDataBase)
    {
        using var minhaConexao = new MySqlConnection(conexaoBancoDeDados);

        var parametros = new DynamicParameters();
        parametros.Add("nome", nomeDataBase);

        var registros = minhaConexao.Query("SELECT * FROM INFORMATION_SCHEMA.SCHEMATA WHERE SCHEMA_NAME = @nome", parametros);

        if (!registros.Any())
        {
            minhaConexao.Execute($"CREATE DATABASE {nomeDataBase}");
        }
    }
}
