using AppShoppingCenter.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace AppShoppingCenter.ViewModels.Tickets;

public partial class ScamPageViewModel : ObservableObject
{
    [ObservableProperty]
    private string ticketNumber;

    [RelayCommand]
    private void Scan()
    {
        Shell.Current.GoToAsync("pay");
    }

    [RelayCommand]
    private void CheckTicketNumber()
    {
        if (TicketNumber?.Length < 15)
            return;

        var service = App.Current.Handler.MauiContext.Services.GetService<TicketService>();
        var ticket = service.GetTicket(TicketNumber);

        if (ticket == null)
        {
            App.Current.MainPage.DisplayAlert("Ticket não encontrado!", $"Não localizamos o ticket {TicketNumber}", "OK");
            return;
        }

        var param = new Dictionary<string, object>()
        {
            { "ticket", ticket }
        };

        Shell.Current.GoToAsync("pay", param);
        TicketNumber = string.Empty;
    }


    [RelayCommand]
    private void List()
    {
        Shell.Current.GoToAsync("list");
    }
}
