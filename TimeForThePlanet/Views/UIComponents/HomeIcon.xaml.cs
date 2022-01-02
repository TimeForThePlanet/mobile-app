using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TimeForThePlanet.Views.Components
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomeIcon : Grid
    {
        public HomeIcon()
        {
            InitializeComponent();
        }

        public static readonly BindableProperty ImageSrcProperty =
            BindableProperty.Create(nameof(ImageSrc), typeof(string), typeof(HomeIcon));

        public static readonly BindableProperty TextProperty =
            BindableProperty.Create(nameof(Text), typeof(string), typeof(HomeIcon));

        public static readonly BindableProperty TappedCommandProperty =
            BindableProperty.Create(nameof(TappedCommand), typeof(ICommand), typeof(HomeIcon));

        public string ImageSrc
        {
            get => (string)GetValue(ImageSrcProperty);
            set => SetValue(ImageSrcProperty, value);
        }

        public string Text
        {
            get => (string)GetValue(TextProperty);
            set => SetValue(TextProperty, value);
        }

        public ICommand TappedCommand
        {
            get => (ICommand)GetValue(TappedCommandProperty);
            set => SetValue(TappedCommandProperty, value);
        }

    }
}