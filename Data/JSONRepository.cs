using AppliancePointOfSale.Models;
using System.CodeDom;
using System.Reflection;
using System.Text;
using System.Text.Json;

namespace AppliancePointOfSale.Data;

public class JSONRepository : IRepository
{
    private readonly string userJSONPath;
    private readonly string applianceJSONPath;
    private readonly string transactionJSONPath;
    private readonly List<User> users;
    private readonly List<Appliance> appliances;
    private readonly List<Transaction> transactions;

    public JSONRepository(string userJSONPath, string applianceJSONPath, string transactionJSONPath)
    {
        this.userJSONPath = userJSONPath;
        this.applianceJSONPath = applianceJSONPath;
        this.transactionJSONPath = transactionJSONPath;

        users = GetAllUsers().ToList();
        appliances = GetAllAppliance().ToList();
        transactions = GetAllTransactions().ToList();
    }

    private async Task<IEnumerable<T>> ReadJSON<T>()
    {
        String path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, GetPath(typeof(T)));
        await using FileStream fileStream = File.OpenRead(path);
        var data = await JsonSerializer.DeserializeAsync<IEnumerable<T>>(fileStream);
        return data!;
    }

    private async Task WriteJson<T>(List<T> data)
    {
        String path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, GetPath(typeof(T)));
        await using FileStream fileStream = File.Create(path);
        await JsonSerializer.SerializeAsync(fileStream, data);
    }

    private string GetPath<T>(T type) => type switch
    {
        User user => userJSONPath,
        Appliance appliance => applianceJSONPath,
        Transaction transaction => transactionJSONPath,
        _ => throw new Exception("Invalid type")
    };

    public async void AddAppliance(Appliance appliance)
    {
        appliances.Add(appliance);
        await WriteJson(appliances);
    }

    public async void AddTransaction(Transaction transaction)
    {
        transactions.Add(transaction);
        await WriteJson(transactions);
    }

    public async void AddUser(User user)
    {
        users.Add(user);
        await WriteJson(users);
    }

    public bool AuthenticateUser(string username, string password)
    {
        throw new NotImplementedException();
    }

    public void DeleteAppliance(string ID)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<User> GetAllUsers() => ReadJSON<User>().Result;

    public IEnumerable<Appliance> GetAllAppliance() => ReadJSON<Appliance>().Result;

    public IEnumerable<Transaction> GetAllTransactions() => ReadJSON<Transaction>().Result;

    public IEnumerable<Customer> GetAllCustomers() => transactions.Select(x => x.Customer).Distinct();

    public Appliance GetAppliance(string identifier)
    {
        throw new NotImplementedException();
    }

    public Customer GetCustomer(string FullName)
    {
        throw new NotImplementedException();
    }

    public Transaction GetTransaction(string ID)
    {
        throw new NotImplementedException();
    }

    public User GetUser(string username)
    {
        throw new NotImplementedException();
    }

    public void UpdateAppliance(Appliance appliance)
    {
        throw new NotImplementedException();
    }

    public void UpdateUser(User user)
    {
        throw new NotImplementedException();
    }
}
