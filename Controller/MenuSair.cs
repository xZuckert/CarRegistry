namespace CarRegistry.Controller;
internal class MenuSair : Menu
{
    public override void Executar()
    {
        Console.WriteLine("\nEncerrando programa...\n");
        Thread.Sleep(500);
        Console.WriteLine("Programa encerrado!\n");
    }
}