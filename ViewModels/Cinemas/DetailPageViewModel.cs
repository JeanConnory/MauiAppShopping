using AppShoppingCenter.Models;
using CommunityToolkit.Maui.Views;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace AppShoppingCenter.ViewModels.Cinemas;

[QueryProperty(nameof(Movie),"movie")]
public partial class DetailPageViewModel : ObservableObject
{
    [ObservableProperty]
    private Movie movie;

    [RelayCommand]
    private void OnTapCloseGoToMoviesList(MediaElement player)
    {
        player.Stop();
        Shell.Current.GoToAsync("..");
    }
}
