
namespace AppliancePointOfSale.Models;

public class LineItem
{
    public required string ID { get; set; }
    public required string Name { get; set; }
    public required decimal Price { get; set; }
    public required int Quantity { get; set; }
    public required int AvailableStocks { get; set; }
    public string? Size { get; set; }
    public string? Color { get; set; }
    public decimal TotalPrice { get => Price * Quantity; }

    public static explicit operator LineItem(Control v)
    {
        throw new NotImplementedException();
    }
}
