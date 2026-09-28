using static Interface.Controllers.HomeController;

public class Client : IAffichable
{
    public required string Nom { get; set; }
    public required string email { get; set; }

    public void Afficher()
    {
        Console.WriteLine($"{Nom} - {email}");
    }
}