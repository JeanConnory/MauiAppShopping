using AppShoppingCenter.Models;
using AppShoppingCenter.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace AppShoppingCenter.ViewModels.Cinemas;

public partial class ListPageViewModel : ObservableObject
{
    [ObservableProperty]
    private List<Movie> movies;

    public ListPageViewModel()
    {
        var service = App.Current.Handler.MauiContext.Services.GetService<CinemaService>();
        movies = service.GetMovies();
    }

    [RelayCommand]
    private void OnTapMovieGoToDetailPage(Movie movie)
    {
        var param = new Dictionary<string, object>
        {
            { "movie", movie }
        };

        if (DeviceInfo.Idiom == DeviceIdiom.Phone)
        {
            Shell.Current.GoToAsync("detail", param);
        }
        else
        {
            Shell.Current.GoToAsync("detaildesktop", param);
        }
    }
}
