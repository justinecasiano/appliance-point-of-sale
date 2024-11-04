namespace AppliancePointOfSale.Views;

public interface IRegisterView : INotifier
{
    string Username { get; set; }
    string Password { get; set; }
    string Email { get; set; }
    string FullName { get; set; }
    bool IsSuccessful { get; set; }

    event EventHandler RegisterEvent;
}
