using MauiTask4.Pages;

namespace MauiTask4
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            var navigationPage = new NavigationPage(new MainPage());
            navigationPage.BarBackgroundColor = Color.FromRgba("#181C3f");
            MainPage = navigationPage;
        }
    }
}