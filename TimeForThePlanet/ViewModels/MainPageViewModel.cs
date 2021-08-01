using System.Windows.Input;
using TimeForThePlanet.Views;
using Xamarin.Forms;

namespace TimeForThePlanet.ViewModels
{
    class MainPageViewModel
    {
        public ICommand GoToGalaxyOfActionCommand { get; }
        public ICommand GoToBecomeActionnaryCommand { get; }

        public MainPageViewModel()
        {
            GoToGalaxyOfActionCommand = new Command(GoToGalaxyOfAction);
            GoToBecomeActionnaryCommand = new Command(GoToBecomeActionnary);
        }

        private void GoToGalaxyOfAction()
        {
            var page = new GalaxyOfAction();
            Application.Current.MainPage.Navigation.PushAsync(page);
        }

        private void GoToBecomeActionnary()
        {
            var page = new BecomeActionnaryPage();
            Application.Current.MainPage.Navigation.PushAsync(page);
        }
    }
}
