﻿namespace AppliancePointOfSale.Models;

public class Customer
{
    public string FullName { get; set; }
    public string Address { get; set; }
    public string ContactNumber { get; set; }
    public string Email { get; set; }
    public bool IsSeniorOrPwd { get; set; }
}
