using MauiIcons.Core;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace PxlPop.App.Pages;

public partial class TicketPage : ContentPage, INotifyPropertyChanged
{
    private int _staDayTickets;
    private int _vipDayTickets;
    private int _staCombiTickets;
    private int _vipCombiTickets;
    private int _numberOfDays;

    public TicketPage()
	{
		InitializeComponent();

        _ = new MauiIcon(); // Bugfix for MauiIcon

        IncreaseStaDayTicketCommand = new Command(() => StaDayTickets++);
        DecreaseStaDayTicketCommand = new Command(() => StaDayTickets--);
        IncreaseVipDayTicketCommand = new Command(() => VipDayTickets++);
        DecreaseVipDayTicketCommand = new Command(() => VipDayTickets--);
        IncreaseStaCombiTicketCommand = new Command(() => StaCombiTickets++);
        DecreaseStaCombiTicketCommand = new Command(() => StaCombiTickets--);
        IncreaseVipCombiTicketCommand = new Command(() => VipCombiTickets++);
        DecreaseVipCombiTicketCommand = new Command(() => VipCombiTickets--);

        this.BindingContext = this;
    }

    public int StaDayTickets { get => _staDayTickets; set => SetProperty(ref _staDayTickets, value, "TotalAmount"); }
    public int VipDayTickets { get => _vipDayTickets; set => SetProperty(ref _vipDayTickets, value, "TotalAmount"); }
    public int StaCombiTickets { get => _staCombiTickets; set => SetProperty(ref _staCombiTickets, value, "TotalAmount"); }
    public int VipCombiTickets { get => _vipCombiTickets; set => SetProperty(ref _vipCombiTickets, value, "TotalAmount"); }
    public int NumberOfDays { get => _numberOfDays; set => SetProperty(ref _numberOfDays, value, "TotalAmount"); }

    public int TotalAmount
    {
        get
        {
            return
                StaDayTickets * 60
                + VipDayTickets * 130
                + StaCombiTickets * NumberOfDays * 50
                + VipCombiTickets * NumberOfDays * 110;
        }
    }

    private bool SetProperty<T>(ref T storage, T value, string alsoChangePropertyName = null, [CallerMemberName] string propertyName = null)
    {
        if (Object.Equals(storage, value))
            return false;

        storage = value;
        OnPropertyChanged(propertyName);

        if (!string.IsNullOrEmpty(alsoChangePropertyName))
            OnPropertyChanged(alsoChangePropertyName);

        return true;
    }

    public ICommand IncreaseStaDayTicketCommand { get; private set; }
    public ICommand DecreaseStaDayTicketCommand { get; private set; }
    public ICommand IncreaseVipDayTicketCommand { get; private set; }
    public ICommand DecreaseVipDayTicketCommand { get; private set; }
    public ICommand IncreaseStaCombiTicketCommand { get; private set; }
    public ICommand DecreaseStaCombiTicketCommand { get; private set; }
    public ICommand IncreaseVipCombiTicketCommand { get; private set; }
    public ICommand DecreaseVipCombiTicketCommand { get; private set; }


    private async void OnOrderClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(OrderPage));
    }
}