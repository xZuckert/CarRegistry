using CarRegistry.DAO;
namespace CarRegistry.Controller;
internal class MenuRegistrarPessoa : Menu
{
    public override void Executar()
    {
        base.Executar();
        Console.Clear();
        ExibirMensagemTitulo("Registro:");
        Console.WriteLine("Pessoa:\n");
        Console.Write("Nome: ");
        string nome = Console.ReadLine();
        Console.Write("\nCPF: ");
        string cpf = Console.ReadLine();
        Pessoa.RegistrarPessoa(nome, cpf);
        Console.WriteLine();
        Console.WriteLine("\nCarro:\n");
        Console.Write("Placa: ");
        string placa = Console.ReadLine();
        Console.Write("\nModelo: ");
        string modelo = Console.ReadLine();
        Console.Write("\nAno: ");
        string ano = Console.ReadLine();
        int anoInt = int.Parse(ano);
        Console.Write("\nCor: ");
        string cor = Console.ReadLine();
        Carro.RegistrarCarro(placa, modelo, anoInt, cor, cpf);
        Thread.Sleep(500);
        Console.Write("\nPrecione qualquer botão para voltar ao menu");
        Console.ReadKey();
        Console.Clear();
    }
}