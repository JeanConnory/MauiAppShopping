using AppShoppingCenter.Models;
using CommunityToolkit.Mvvm.ComponentModel;

namespace AppShoppingCenter.ViewModels.Stores;

[QueryProperty(nameof(Establishment), "establishment")]
public partial class DetailPageViewModel : ObservableObject
{
    [ObservableProperty]
    private Establishment establishment;
}
