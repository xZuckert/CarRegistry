using CarRegistry.DAO;
namespace CarRegistry.Controller;
internal class MenuVerTotalPessoas : Menu
{
    public override void Executar()
    {
        base.Executar();
        ExibirMensagemTitulo("Ver total de pessoas:");
        string sql = "SELECT COUNT(*) FROM Pessoa";
        int total = Convert.ToInt32(Query.ExecutarQuery(sql, returnEscalar: true));
        Console.WriteLine($"Total de Pessoas: {total}");
        Thread.Sleep(500);
        Console.Write("\nPrecione qualquer botão para voltar ao menu");
        Console.ReadKey();
        Console.Clear();
    }
}