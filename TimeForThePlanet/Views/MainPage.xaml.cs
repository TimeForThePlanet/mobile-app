using System;
using Xamarin.Forms;

namespace TimeForThePlanet.Views
{
    public partial class MainPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_OnClicked(object sender, EventArgs e)
        {
            var page = new GalaxyOfAction();
            Application.Current.MainPage.Navigation.PushAsync(page);
        }
    }
}
