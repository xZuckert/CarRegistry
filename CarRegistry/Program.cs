using CarRegistry.Controller;
using CarRegistry.DAO;

Conexao.EstabelecerConexao();
Dictionary<int, Menu> opcoes = new();
opcoes.Add(1, new MenuRegistrarPessoa());
opcoes.Add(2, new MenuVerPessoaCarro());
opcoes.Add(3, new MenuVerTodasPessoasCarros());
opcoes.Add(4, new MenuVerTotalPessoas());
opcoes.Add(5, new MenuVerTotalCarros());
opcoes.Add(0, new MenuSair());
void ExibirOpcoesMenu()
{
    Menu.ExibirLogo();
    Console.WriteLine("Escolha uma opção:");
    Console.WriteLine("1 - Registrar Pessoa e Carro");
    Console.WriteLine("2 - Ver Pessoa e Carro por CPF");
    Console.WriteLine("3 - Ver Todas as Pessoas e seus Carros");
    Console.WriteLine("4 - Ver Total de Pessoas");
    Console.WriteLine("5 - Ver Total de Carros");
    Console.WriteLine("0 - Sair");
    Console.Write("\nOpção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaInt = int.Parse(opcaoEscolhida);
    Thread.Sleep(200);
    if (opcoes.ContainsKey(opcaoEscolhidaInt))
    {
        Menu menuASerExibido = opcoes[opcaoEscolhidaInt];
        menuASerExibido.Executar();
        if (opcaoEscolhidaInt > 0) ExibirOpcoesMenu();
    }
    else
    {
        Console.WriteLine("Opção Inválida");
    }
}
ExibirOpcoesMenu();