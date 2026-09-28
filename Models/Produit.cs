using static Interface.Controllers.HomeController;

public class Produit : IAffichable
{    
    public required string Nom { get; set; }
    public required decimal Prix { get; set; }

    public void Afficher()
    {
        Console.WriteLine($"Produit: {Nom}, Prix: {Prix}");
    }
}