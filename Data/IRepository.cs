using AppliancePointOfSale.Models;

namespace AppliancePointOfSale.Data;

public interface IRepository
{
    IEnumerable<Appliance> GetAllAppliance();
    Appliance GetAppliance(String identifier);
    void AddAppliance(Appliance appliance);
    void UpdateAppliance(Appliance appliance);
    void RemoveAppliance(String ID);

    IEnumerable<Customer> GetAllCustomers();
    Customer GetCustomer(String FullName);

    IEnumerable<Transaction> GetAllTransactions();
    Transaction GetTransaction(String ID);
    void AddTransaction(Transaction transaction);
}
