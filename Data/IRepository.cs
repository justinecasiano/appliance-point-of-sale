using AppliancePointOfSale.Models;

namespace AppliancePointOfSale.Data;

public interface IRepository
{
    List<Appliance> Appliances { get; set; }
    List<Transaction> Transactions { get; set; }

    event EventHandler OnUpdateApplianceEvent;
    event EventHandler OnAddTransactionEvent;

    Appliance GetAppliance(string id);
    Task<IEnumerable<Appliance>> GetAllAppliance();
    void UpdateAppliance(Appliance appliance);
    Transaction GetTransaction(string id);
    Task<IEnumerable<Transaction>> GetAllTransactions();
    void AddTransaction(Transaction transaction);
}
