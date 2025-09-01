using CarRegistry.DAO;
namespace CarRegistry.Controller;
internal class MenuVerTotalCarros : Menu
{
    public override void Executar()
    {
        base.Executar();
        ExibirMensagemTitulo("Ver total de carros:");
        string sql = "SELECT COUNT(*) FROM Carro";
        int total = Convert.ToInt32(Query.ExecutarQuery(sql, returnEscalar: true));
        Console.WriteLine($"Total de Carros: {total}");
        Thread.Sleep(500);
        Console.Write("\nPrecione qualquer botão para voltar ao menu");
        Console.ReadKey();
        Console.Clear();
    }
}