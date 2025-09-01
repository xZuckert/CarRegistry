namespace CarRegistry.DAO;
internal class Carro
{
    public static void RegistrarCarro(string placa, string modelo, int ano, string cor, string cpfDono)
    {
        string sql =
            "INSERT INTO Carro (Placa, Modelo, ano, Cor, CPF_dono) VALUES (@Placa, @Modelo, @ano, @Cor, @CPF_dono)";
        var parametros = new Dictionary<string, object>
        {
            { "@Placa", $"{placa}" },
            { "@Modelo", $"{modelo}" },
            { "@ano", ano},
            { "@Cor", $"{cor}" },
            { "@CPF_dono", $"{cpfDono}" }
        };
        int linhas = (int)Query.ExecutarQuery(sql, parametros);
        //Console.WriteLine($"Linhas inseridas: {linhas}");
    }
}