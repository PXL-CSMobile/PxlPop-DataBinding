
namespace PxlPop.App
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            this.UserAppTheme = AppTheme.Light;
            return base.CreateWindow(activationState);
        }
    }
}
