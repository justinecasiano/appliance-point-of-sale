using AppliancePointOfSale.Models;
using System.CodeDom;
using System.Reflection;
using System.Text;
using System.Text.Json;

namespace AppliancePointOfSale.Data;

public class JSONRepository : IRepository
{
    private readonly string applianceJSONPath;
    private readonly string transactionJSONPath;
    private readonly List<Appliance>? appliances;
    private readonly List<Transaction>? transactions;

    public JSONRepository(string applianceJSONPath, string transactionJSONPath)
    {
        this.applianceJSONPath = applianceJSONPath;
        this.transactionJSONPath = transactionJSONPath;

        try
        {
            appliances = GetAllAppliance().ToList();
            transactions = GetAllTransactions().ToList();
        } catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }

    private async Task<IEnumerable<T>>? ReadJSON<T>(string type)
    {
        await using FileStream fileStream = File.OpenRead($"../../../{GetPath(type)}");
        return await JsonSerializer.DeserializeAsync<IEnumerable<T>>(fileStream);
    }

    private async Task WriteJson<T>(string type, List<T> data)
    {
        await using FileStream fileStream = File.Create($"../../../{GetPath(type)}");
        await JsonSerializer.SerializeAsync(fileStream, data);
    }

    private string GetPath(string type) => type switch
    {
        "appliance" => applianceJSONPath,
        "transaction" => transactionJSONPath,
        _ => throw new Exception("Invalid type")
    };

    public IEnumerable<Appliance> GetAllAppliance() => ReadJSON<Appliance>("appliance").Result;

    public Appliance GetAppliance(string identifier)
    {
        throw new NotImplementedException();
    }

    public async void AddAppliance(Appliance appliance)
    {
        appliances.Add(appliance);
        await WriteJson("appliance", appliances);
    }
    public void UpdateAppliance(Appliance appliance)
    {
        throw new NotImplementedException();
    }

    public void RemoveAppliance(string ID)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Customer> GetAllCustomers() => transactions.Select(x => x.Customer).Distinct();

    public Customer GetCustomer(string FullName)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Transaction> GetAllTransactions() => ReadJSON<Transaction>("transaction").Result;

    public Transaction GetTransaction(string ID)
    {
        throw new NotImplementedException();
    }

    public async void AddTransaction(Transaction transaction)
    {
        transactions.Add(transaction);
        await WriteJson("transaction", transactions);
    }
}
