using AppShoppingCenter.Services;
using CommunityToolkit.Maui.Core.Platform;
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
        Shell.Current.GoToAsync("camera");
    }

    [RelayCommand]
    private async void CheckTicketNumber(Entry entryTicketNumber)
    {
        if (TicketNumber?.Length < 15)
            return;

        var service = App.Current.Handler.MauiContext.Services.GetService<TicketService>();
        var ticket = service.GetTicket(TicketNumber);

        if (ticket == null)
        {
            await App.Current.MainPage.DisplayAlert("Ticket não encontrado!", $"Não localizamos o ticket {TicketNumber}", "OK");
            return;
        }

        var param = new Dictionary<string, object>()
        {
            { "ticket", ticket }
        };

        await Shell.Current.GoToAsync("pay", param);
        await entryTicketNumber.HideKeyboardAsync(CancellationToken.None);
        TicketNumber = string.Empty;
    }


    [RelayCommand]
    private void List()
    {
        Shell.Current.GoToAsync("list");
    }
}
