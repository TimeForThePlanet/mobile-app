using System;
using TimeForThePlanet.ViewModels;
using TimeForThePlanet.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TimeForThePlanet
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            
            MainPage = new NavigationPage(new MainPage
            {
                BindingContext = new MainPageViewModel()
            });
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
