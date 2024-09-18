using AppShoppingCenter.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace AppShoppingCenter.ViewModels.Tickets;

public partial class CameraPageViewModel : ObservableObject
{
    [RelayCommand]
    private void BarcodeDetected(string ticketNumber)
    {

        var service = App.Current.Handler.MauiContext.Services.GetService<TicketService>();
        var ticket = service.GetTicket(ticketNumber);

        if (ticket == null)
        {
            App.Current.MainPage.DisplayAlert("Ticket não encontrado!", $"Não localizamos o ticket {ticketNumber}", "OK");
            return;
        }

        var param = new Dictionary<string, object>()
        {
            { "ticket", ticket }
        };

        MainThread.BeginInvokeOnMainThread(async () =>
        {
            await Shell.Current.GoToAsync("../pay", param);
        });
    }
}
