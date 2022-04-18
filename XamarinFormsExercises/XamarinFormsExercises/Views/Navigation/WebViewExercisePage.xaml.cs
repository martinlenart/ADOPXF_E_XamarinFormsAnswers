using System.Web;
using Xamarin.Forms;

namespace XamarinFormsExercises.Views.Navigation
{
    public partial class WebViewExercisePage : ContentPage
    {
        string myTitle;
        public WebViewExercisePage()
        {
            InitializeComponent();
         }
        public WebViewExercisePage(string Url, string Title)
        {
            InitializeComponent();
            BindingContext = new UrlWebViewSource
            {
                Url = HttpUtility.UrlDecode(Url)
            };
            myTitle = $"Viewing {Title}";
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            ((Page)this.Parent).Title = myTitle;
        }
    }
}
