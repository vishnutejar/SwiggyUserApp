using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SwiggyUserApp.pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SplashPage : ContentPage
    {
        public SplashPage()
        {
            InitializeComponent();
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await splashscreen.ScaleTo(2, 300, easing: Easing.Linear);
            await splashscreen.ScaleTo(1, 300, easing: Easing.Linear);

            await Task.Delay(1200);
            await splashscreen.ScaleTo(1, 200, easing: Easing.BounceOut);

            App.Current.MainPage = new HomePage();

        }
    }
}