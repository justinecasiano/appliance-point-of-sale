﻿using AppliancePointOfSale.Models;

namespace AppliancePointOfSale.Data;

public interface IRepository
{
    IEnumerable<Appliance> GetAllAppliance();
    Appliance GetAppliance(String identifier);
    void AddAppliance(Appliance appliance);
    void UpdateAppliance(Appliance appliance);
    void DeleteAppliance(String ID);

    IEnumerable<User> GetAllUsers();
    User GetUser(String username);
    void AddUser(User user);
    void UpdateUser(User user);
    bool AuthenticateUser(String username, String password);

    IEnumerable<Customer> GetAllCustomers();
    Customer GetCustomer(String FullName);

    IEnumerable<Transaction> GetAllTransactions();
    Transaction GetTransaction(String ID);
    void AddTransaction(Transaction transaction);
}