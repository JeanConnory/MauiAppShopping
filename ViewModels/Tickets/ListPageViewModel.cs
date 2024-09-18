using AppShoppingCenter.Models;
using AppShoppingCenter.Storages;
using CommunityToolkit.Mvvm.ComponentModel;

namespace AppShoppingCenter.ViewModels.Tickets;

public partial class ListPageViewModel : ObservableObject
{
    [ObservableProperty]
    private List<Ticket> tickets;

    public ListPageViewModel()
    {
        var storage = App.Current.Handler.MauiContext.Services.GetService<TicketPreferenceStorage>();
        Tickets = storage.Load();
    }
}
