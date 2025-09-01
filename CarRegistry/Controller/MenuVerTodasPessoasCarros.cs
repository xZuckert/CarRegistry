using CarRegistry.DAO;
namespace CarRegistry.Controller;
internal class MenuVerTodasPessoasCarros : Menu
{
    public override void Executar()
    {
        base.Executar();
        ExibirMensagemTitulo("Ver todos os registros:");
        Pessoa.VerTodasPessoas();
        Thread.Sleep(500);
        Console.Write("\nPrecione qualquer botão para voltar ao menu");
        Console.ReadKey();
        Console.Clear();
    }
}