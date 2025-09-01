using MySql.Data.MySqlClient;
namespace CarRegistry.DAO;
internal class Query
{
    public static object ExecutarQuery(string query, Dictionary<string, object>? parameters = null, bool returnEscalar = false)
    {
        using (MySqlConnection conn = new MySqlConnection(Conexao.GetConexao()))
        {
            conn.Open();
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                // adiciona parametros dinâmicamente se existir
                if (parameters != null)
                {
                    foreach (var param in parameters)
                    {
                        cmd.Parameters.AddWithValue(param.Key, param.Value ?? DBNull.Value);
                    }
                }
                // decide o q retornar
                if (returnEscalar) // ExecuteScalar
                {
                    // retorna um valor único
                    return cmd.ExecuteScalar();
                } else if (query.TrimStart().StartsWith("SELECT", StringComparison.OrdinalIgnoreCase)) // ExecuteReader
                {
                    // retorna lista de dicionarios, cada linha é um dicionario com colunas
                    List<Dictionary<string, object>> results = new();
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var row = new Dictionary<string, object>();
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                row[reader.GetName(i)] = reader.GetValue(i);
                            }
                            results.Add(row);
                        }
                    }
                    return results;
                }
                else // ExecuteNonQuery
                {
                    // INSERT, UPDATE, DELETE -> retorna número de linhas afetadas
                    return cmd.ExecuteNonQuery(); 
                }
            }
        }
    }
}