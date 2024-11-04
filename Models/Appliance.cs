namespace AppliancePointOfSale.Models;

public class Appliance
{
    public required string ID { get; set; }
    public required string Name { get; set; }
    public required decimal Price { get; set; }
    public required int Stocks { get; set; }
    public bool InStock { get => Stocks > 0; }
    public required string Category { get; set; }
    public List<string>? Sizes { get; set; }
    public List<string>? Colors { get; set; }
    public Image thumbnail { get; set; }
}