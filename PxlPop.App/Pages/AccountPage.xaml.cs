using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Core;
using System.Threading;

namespace PxlPop.App.Pages;

public partial class AccountPage : ContentPage
{
	public AccountPage()
	{
		InitializeComponent();
	}

	private void OnDarkModeToggled(object sender, ToggledEventArgs e)
	{
		if (e.Value)
		{
			Application.Current!.UserAppTheme = AppTheme.Dark;
		}
		else
		{
			Application.Current!.UserAppTheme = AppTheme.Light;
		}
	}

    private async void OnNotificationsToggled(object sender, ToggledEventArgs e)
    {
        string text = "Nieuwe instellingen werden toegepast";
        ToastDuration duration = ToastDuration.Short;
        double fontSize = 12;

        var toast = Toast.Make(text, duration, fontSize);

        await toast.Show();
    }

    private void OnPageAppearing(object sender, EventArgs e)
    {
		switch(Application.Current!.UserAppTheme)
		{
			case AppTheme.Dark:
                darkThemeSwitch.On = true; 
				break;
			default:
				darkThemeSwitch.On = false;
				break;
		}
    }
}