namespace CarRegistry.DAO;
internal class Pessoa
{
    public static void RegistrarPessoa(string nome, string cpf)
    {
        string sql = "INSERT INTO Pessoa (Nome, CPF) VALUES (@Nome, @CPF)";
        var parametros = new Dictionary<string, object>
        {
            { "@Nome", $"{nome}" },
            { "@CPF", $"{cpf}" }

        };
        int linhas = (int)Query.ExecutarQuery(sql, parametros);
        //Console.WriteLine($"Linhas inseridas: {linhas}");
    }
    public static void VerPessoa(string cpf)
    {
        string sql = "select p.Nome, p.CPF, c.Placa, c.Modelo, c.ano, c.Cor from Pessoa p JOIN Carro c on p.CPF = c.CPF_dono and p.CPF = @cpf;";
        var parametros = new Dictionary<string, object>
        {
            { "@cpf", $"{cpf}" }
        };
        var resultados = (List<Dictionary<string, object>>)Query.ExecutarQuery(sql, parametros);
        foreach (var row in resultados)
        {
            Console.WriteLine($"Nome: {row["Nome"]}\nCPF: {row["CPF"]}\n\nCarro:\n\n" +
                              $"Placa: {row["Placa"]}\nModelo: {row["Modelo"]}\nAno: {row["ano"]}\nCor: {row["Cor"]}");
        }
    }
    public static void VerTodasPessoas()
    {
        string sql = "select p.Nome, p.CPF, c.Placa, c.Modelo, c.ano, c.Cor from Pessoa p JOIN Carro c on p.CPF = c.CPF_dono;";
        var parametros = new Dictionary<string, object>{};
        var resultados = (List<Dictionary<string, object>>)Query.ExecutarQuery(sql, parametros);
        foreach (var row in resultados)
        {
            Console.WriteLine($"=================================");
            Console.WriteLine($"\nPessoa:\n\nNome: {row["Nome"]}\nCPF: {row["CPF"]}\n\nCarro:\n\nPlaca: {row["Placa"]}\nModelo: {row["Modelo"]}\nAno: {row["ano"]}\nCor: {row["Cor"]}\n");
            Thread.Sleep(100);
        }
        Console.WriteLine($"=================================");
    }
}