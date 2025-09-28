using Microsoft.Maui.Controls;

namespace TCC_PAM
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage())
            {
                BarBackgroundColor = Colors.White,
                BarTextColor = Colors.Black
            };
        }
    }
}
