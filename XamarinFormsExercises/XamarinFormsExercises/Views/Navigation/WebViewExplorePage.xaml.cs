using System.Web;
using Xamarin.Forms;

namespace XamarinFormsExercises.Views.Navigation
{
    public partial class WebViewExplorePage : ContentPage
    {
        public WebViewExplorePage()
        {
            InitializeComponent();
         }
        public WebViewExplorePage(string Url)
        {
            InitializeComponent();
            myWebView.Source = new UrlWebViewSource
            {
                Url = HttpUtility.UrlDecode(Url)
            };
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
        }
    }
}
