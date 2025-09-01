using CarRegistry.DAO;
namespace CarRegistry.Controller;
internal class MenuVerPessoaCarro : Menu
{
    public override void Executar()
    {
        base.Executar();
        ExibirMensagemTitulo("Ver pessoa:");
        Console.Write("CPF: ");
        string cpf = Console.ReadLine();
        Console.WriteLine();
        Pessoa.VerPessoa(cpf);
        Thread.Sleep(500);
        Console.Write("\nPrecione qualquer botão para voltar ao menu");
        Console.ReadKey();
        Console.Clear();
    }
}