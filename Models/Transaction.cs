using System.Diagnostics.CodeAnalysis;

namespace AppliancePointOfSale.Models;

public class Transaction
{
    public string ID { get; set; }
    public required List<LineItem> LineItems { get; set; }
    public required Customer Customer { get; set; }
    public decimal SubTotal { get => LineItems.Sum(x => x.TotalPrice); }
    public decimal Discount { get => Customer.IsSeniorOrPwd ? (SubTotal * 0.2m) : 0; }
    public decimal AmountVAT { get => LineItems.Sum(x => (x.Price - x.Price / 1.12m) * x.Quantity); }
    public decimal AmountPaid { get; set; }
    public decimal Change { get => Math.Abs(AmountPaid - Total); }
    public decimal Total { get => SubTotal - Discount; }
    public string PaymentMode { get; set; }
    public string? ReferenceNumber;
    public Image? Receipt { get; set; }
    public string Status { get; set; }

    public Transaction()
    {
        ID = Guid.NewGuid().ToString();
    }
}
