using Android.App;
using Android.OS;
using Android.Views;
using Android.Webkit;
using AndroidX.WebKit;

namespace TimeForThePlanet.Droid
{
    [Activity(Label = "GalaxyOfActionActivity", MainLauncher = false)]
    public class GalaxyOfActionActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.galaxy_of_action_layout);

            Window.AddFlags(WindowManagerFlags.Fullscreen);

            var webView = FindViewById<WebView>(Resource.Id.webView);
            var settings = webView.Settings;

            settings.JavaScriptEnabled = true;
            settings.DomStorageEnabled = true;
            WebSettingsCompat.SetForceDark(settings, WebSettingsCompat.ForceDarkOn);
            WebSettingsCompat.SetForceDarkStrategy(settings, WebSettingsCompat.DarkStrategyWebThemeDarkeningOnly);

            webView.LoadUrl("https://time-planet.glideapp.io/");
        }
    }
}