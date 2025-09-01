namespace CarRegistry.Controller;
internal class Menu
{
    public static void Logo()
    {

        Console.WriteLine(@"
███████████████████████████████████▀█████████████████████████████
█─▄▄▄─██▀▄─██▄─▄▄▀█▄─▄▄▀█▄─▄▄─█─▄▄▄▄█▄─▄█─▄▄▄▄█─▄─▄─█▄─▄▄▀█▄─█─▄█
█─███▀██─▀─███─▄─▄██─▄─▄██─▄█▀█─██▄─██─██▄▄▄▄─███─████─▄─▄██▄─▄██
▀▄▄▄▄▄▀▄▄▀▄▄▀▄▄▀▄▄▀▄▄▀▄▄▀▄▄▄▄▄▀▄▄▄▄▄▀▄▄▄▀▄▄▄▄▄▀▀▄▄▄▀▀▄▄▀▄▄▀▀▄▄▄▀▀
");
    }
    public static void ExibirTitulo(string titulo)
    {
        int quantLetras = titulo.Length;
        string asteriscos = string.Empty.PadLeft(quantLetras, '*');
        Console.WriteLine(asteriscos);
        Console.WriteLine(titulo);
        Console.WriteLine(asteriscos + "\n");
    }
    public static void ExibirLogo()
    {
        Logo();
        Thread.Sleep(200);
        ExibirTitulo("Boas Vindas ao CarRegistry");
        Thread.Sleep(200);
    }
    public static void ExibirMensagemTitulo(string msg)
    {
        Logo();
        Thread.Sleep(200);
        ExibirTitulo(msg);
        Thread.Sleep(200);
    }
    public virtual void Executar()
    {
        Console.Clear();
    }
}