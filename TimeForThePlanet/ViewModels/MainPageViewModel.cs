﻿using System.Windows.Input;
using TimeForThePlanet.Views;
using Xamarin.Forms;

namespace TimeForThePlanet.ViewModels
{
    class MainPageViewModel
    {
        public ICommand GoToGalaxyOfActionCommand { get; }
        public ICommand GoToBecomeActionnaryCommand { get; }
        public ICommand GoToMaketimeGrowUpCommand { get; }

        public MainPageViewModel()
        {
            GoToGalaxyOfActionCommand = new Command(GoToGalaxyOfAction);
            GoToBecomeActionnaryCommand = new Command(GoToBecomeActionnary);
            GoToMaketimeGrowUpCommand = new Command(GoToMaketimeGrowUp);
        }

        private void GoToGalaxyOfAction()
        {
            var service = DependencyService.Get<IActivityHelper>();
            service.GoToGalaxy();
        }

        private void GoToBecomeActionnary()
        {
            var page = new BecomeActionnaryPage();
            Application.Current.MainPage.Navigation.PushAsync(page);
        }

        private void GoToMaketimeGrowUp()
        {
            var page = new MakeTimeGrowPage();
            Application.Current.MainPage.Navigation.PushAsync(page);
        }
    }
}
