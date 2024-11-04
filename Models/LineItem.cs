namespace AppliancePointOfSale.Models;

public class LineItem
{
    public required string ID { get; set; }
    public required string Name { get; set; }
    public required decimal Price { get; set; }
    public string? Size { get; set; }
    public string? Color { get; set; }
    public decimal? Discount { get; set; }
    public required int Quantity { get; set; }
    public decimal TotalPrice
    {
        get
        {
            decimal total = Price * Quantity;
            return Discount.HasValue ? total - (Discount.Value * total) : total;
        }
    }
}
