using AppliancePointOfSale.Models;

namespace AppliancePointOfSale.Views;

public interface ILoginView : INotifier
{
    string Username { get; set; }
    string Password { get; set; }
    string Email { get; set; }
    bool IsSuccessful { get; set; }

    event EventHandler LoginEvent;
    event EventHandler ForgotPasswordEvent;
    event EventHandler ChangePasswordEvent;
}
