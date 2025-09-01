using MySql.Data.MySqlClient;
using DotNetEnv;
namespace CarRegistry.DAO;

internal class Conexao
{
    public static string GetConexao()
    {
        Env.Load();
        string server = Environment.GetEnvironmentVariable("DB_SERVER");
        string database = Environment.GetEnvironmentVariable("DB_NAME");
        string user = Environment.GetEnvironmentVariable("DB_USER");
        string password = Environment.GetEnvironmentVariable("DB_PASSWORD");
        return $"Server={server};Database={database};Uid={user};Password={password}";
    }
    public static void EstabelecerConexao()
    {
        // conecta ao BD com a string de conexão
        using (MySqlConnection conexao = new MySqlConnection(GetConexao()))
        {
            try
            {
                conexao.Open();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }
}