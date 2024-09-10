using AppShoppingCenter.Models;
using AppShoppingCenter.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace AppShoppingCenter.ViewModels.Stores;

public partial class ListPageViewModel : ObservableObject
{
    [ObservableProperty]
    private string textSearch;

    private List<Establishment> establishmentFull;

    [ObservableProperty]
    private List<Establishment> establishmentFiltered;

    public ListPageViewModel()
    {
        var service = App.Current.Handler.MauiContext.Services.GetService<StoreService>();
        establishmentFull = service.GetStores();
        establishmentFiltered = establishmentFull.ToList();
    }

    [RelayCommand]
    private void OnTextSearchChangedFilterList()
    {
        EstablishmentFiltered = establishmentFull
            .Where(a => a.Name.ToLower().Contains(TextSearch.ToLower()))
            .ToList();
    }

    [RelayCommand]
    private async void OnTapEstablishmentGoToDetailPage(Establishment establishment)
    {
        var navigationParameter = new Dictionary<string, object>()
        {
            { "establishment", establishment }
        };
        await Shell.Current.GoToAsync("detail", navigationParameter);
    }
}
