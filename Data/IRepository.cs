using AppliancePointOfSale.Models;

namespace AppliancePointOfSale.Data;

public interface IRepository
{
    List<Appliance> Appliances { get; set; }
    List<Transaction> Transactions { get; set; }
    Appliance GetAppliance(string id);
    IEnumerable<Appliance> GetAllAppliance();
    void UpdateAppliance(Appliance appliance);
    Transaction GetTransaction(string id);
    IEnumerable<Transaction> GetAllTransactions();
    void AddTransaction(Transaction transaction);
}
