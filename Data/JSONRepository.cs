using AppliancePointOfSale.Models;
using System.Text.Json;

namespace AppliancePointOfSale.Data;

public class JSONRepository : IRepository
{
    public List<Appliance> Appliances { get; set; }
    public List<Transaction> Transactions { get; set; }

    private readonly string applianceJSONPath;
    private readonly string transactionJSONPath;

    public event EventHandler OnUpdateApplianceEvent;
    public event EventHandler OnAddTransactionEvent;

    public JSONRepository(string applianceJSONPath, string transactionJSONPath)
    {
        this.applianceJSONPath = applianceJSONPath;
        this.transactionJSONPath = transactionJSONPath;
        Appliances = GetAllAppliance().Result.ToList();
        Transactions = GetAllTransactions().Result.ToList();
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
        await fileStream.FlushAsync();
    }

    private string GetPath(string type) => type switch
    {
        "appliance" => applianceJSONPath,
        "transaction" => transactionJSONPath,
        _ => throw new Exception("Invalid type")
    };

    public async Task<IEnumerable<Appliance>> GetAllAppliance() => await ReadJSON<List<Appliance>>("appliance");

    public Appliance GetAppliance(string id) =>
        Appliances.Find(appliance => appliance.ID == id);

    public async void UpdateAppliance(Appliance appliance)
    {
        var match = Appliances.Find(x => x.ID == appliance.ID);
        match.Stocks = appliance.Stocks;
        await WriteJson("appliance", Appliances);
        Appliances = (await GetAllAppliance()).ToList();
        OnUpdateApplianceEvent.Invoke(this, EventArgs.Empty);
    }

    public async Task<IEnumerable<Transaction>> GetAllTransactions() => await ReadJSON<List<Transaction>>("transaction");

    public Transaction GetTransaction(string id) =>
        Transactions.Find(transaction => transaction.ID == id);

    public async void AddTransaction(Transaction transaction)
    {
        Transactions.Add(transaction);
        await WriteJson("transaction", Transactions);
        Transactions = (await GetAllTransactions()).ToList();
        OnAddTransactionEvent.Invoke(this, EventArgs.Empty);
    }
}
