using AppliancePointOfSale.Models;
using System.Text.Json;

namespace AppliancePointOfSale.Data;

public class JSONRepository : IRepository
{
    private readonly string applianceJSONPath;
    private readonly string transactionJSONPath;
    public List<Appliance> Appliances { get; set; }
    public List<Transaction> Transactions { get; set; }

    public JSONRepository(string applianceJSONPath, string transactionJSONPath)
    {
        this.applianceJSONPath = applianceJSONPath;
        this.transactionJSONPath = transactionJSONPath;

        try
        {
            Appliances = GetAllAppliance().ToList();
            Transactions = GetAllTransactions().ToList();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        if (Transactions == null) Transactions = new List<Transaction>();
    }

    private async Task<T>? ReadJSON<T>(string type)
    {
        await using var fileStream = File.OpenRead($"../../../{GetPath(type)}");
        return await JsonSerializer.DeserializeAsync<T>(fileStream);
    }

    private async Task WriteJson<T>(string type, T data)
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

    public IEnumerable<Appliance> GetAllAppliance() => ReadJSON<List<Appliance>>("appliance").Result;

    public Appliance GetAppliance(string id) =>
        Appliances.Find(appliance => appliance.ID == id);

    public async void UpdateAppliance(Appliance appliance)
    {
        Appliances.Find(appliances => appliances.ID == appliance.ID).Stocks = appliance.Stocks;
        await WriteJson("appliance", Appliances);
    }

    public IEnumerable<Transaction> GetAllTransactions() => ReadJSON<List<Transaction>>("transaction").Result;

    public Transaction GetTransaction(string id) =>
        Transactions.Find(transaction => transaction.ID == id);

    public async void AddTransaction(Transaction transaction)
    {
        Transactions.Add(transaction);
        await WriteJson("transaction", Transactions);
    }
}
