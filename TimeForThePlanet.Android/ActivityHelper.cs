using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TimeForThePlanet.Droid;
using Xamarin.Essentials;
using Xamarin.Forms;

[assembly: Xamarin.Forms.Dependency(typeof(ActivityHelper))]
namespace TimeForThePlanet.Droid
{
    class ActivityHelper : IActivityHelper
    {
        public void GoToGalaxy()
        {
            ((MainActivity)Platform.CurrentActivity).GoToGalaxy();
        }
    }
}