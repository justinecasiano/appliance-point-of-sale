using AppliancePointOfSale.Models;

namespace AppliancePointOfSale.Data;

public interface IRepository
{
    List<Appliance> Appliances { get; set; }
    List<Transaction> Transactions { get; set; }
    IEnumerable<Appliance> GetAllAppliance();
    Appliance GetAppliance(String identifier);
    void UpdateAppliance(Appliance appliance);

    IEnumerable<Transaction> GetAllTransactions();
    Transaction GetTransaction(String ID);
    void AddTransaction(Transaction transaction);
}
