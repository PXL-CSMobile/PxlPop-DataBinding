using MauiIcons.Core;
using PxlPop.App.Pages;

namespace PxlPop.App
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();

            _ = new MauiIcon();
        }

        //private async void OnLineupClicked(object sender, EventArgs e)
        //{
        //    await Shell.Current.GoToAsync(nameof(LineupPage), true);
        //}

        //private async void OnInfoClicked(object sender, EventArgs e)
        //{
        //    await Shell.Current.GoToAsync(nameof(InfoPage), true);
        //}

        //private async void OnTicketsClicked(object sender, EventArgs e)
        //{
        //    await Shell.Current.GoToAsync(nameof(TicketPage), true);
        //}

        //private async void OnAccountClicked(object sender, EventArgs e)
        //{
        //    await Shell.Current.GoToAsync(nameof(AccountPage), true);
        //}

        //private async void OnFavouritesClicked(object sender, EventArgs e)
        //{
        //    await Shell.Current.GoToAsync(nameof(FavouritesPage), true);
        //}

        private async void OnPageLoaded(object sender, EventArgs e)
        {
            await Task.WhenAny(
                pxlLogo.FadeTo(1, 3000),
                pxlLogo.RotateTo(360, 3000));
        }
    }

}
