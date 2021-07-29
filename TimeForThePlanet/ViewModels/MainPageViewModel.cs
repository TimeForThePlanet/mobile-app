using System.Windows.Input;
using Xamarin.Forms;

namespace TimeForThePlanet.ViewModels
{
    class MainPageViewModel
    {
        public ICommand GoToGalaxyOfActionCommand { get; }

        public MainPageViewModel()
        {
            GoToGalaxyOfActionCommand = new Command(GoToGalaxyOfAction);
        }

        public void GoToGalaxyOfAction()
        {
        }
    }
}
