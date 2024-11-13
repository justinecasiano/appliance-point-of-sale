using System.Diagnostics.CodeAnalysis;

namespace AppliancePointOfSale.Models;

public class Transaction
{
    public string ID { get; set; }
    public required List<LineItem> LineItems { get; set; }
    public required Customer Customer { get; set; }
    public decimal? Discount { get; set; }
    public decimal VAT = 0.12m;
    public decimal Total
    {
        get
        {
            var totalSum = LineItems.Sum(x => x.TotalPrice);
            totalSum = totalSum + (VAT * totalSum);
            return Discount.HasValue ? totalSum - (Discount.Value * totalSum) : totalSum;
        }
    }
    public decimal AmountPaid { get; set; }
    public decimal? Change { get; set; }
    public Image? receipt { get; set; }

    public Transaction()
    {
        ID = Guid.NewGuid().ToString();
    }
}
