using System.Diagnostics.CodeAnalysis;

namespace AppliancePointOfSale.Models;

public class Transaction
{
    public string ID { get; set; }
    public required List<LineItem> LineItems { get; set; }
    public required Customer Customer { get; set; }
    public decimal SubTotal { get => LineItems.Sum(x => x.TotalPrice); }
    public decimal Discount { get => Customer.IsSeniorOrPwd ? (SubTotal - AmountVAT) * 0.2m : 0; }
    public decimal AmountVAT { get => LineItems.Sum(x => (x.Price - x.Price / 1.12m) * x.Quantity); }
    public decimal AmountPaid { get; set; }
    public decimal Change { get => AmountPaid - Total < 0 ? 0 : AmountPaid - Total; }
    public decimal Total { get => SubTotal + (Customer.IsSeniorOrPwd ? -AmountVAT : 0) - Discount; }
    public string PaymentMode { get; set; }
    public string ReferenceNumber { get; set; }
    public string ReceiptImagePath { get; set; }
    public DateTime Date { get; set; }
    public string Status { get; set; }

    public Transaction()
    {
        ID = Guid.NewGuid().ToString();
        Date = DateTime.Now;
    }
}
