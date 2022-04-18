using Xamarin.Forms;

namespace XamarinFormsExercises.Views.BasicBinding
{
    public partial class BindingContextExercisePage : ContentPage
    {
        public BindingContextExercisePage()
        {
            InitializeComponent();
            BindingContext = slider;
        }
    }
}