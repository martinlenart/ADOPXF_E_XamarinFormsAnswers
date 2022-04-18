using Xamarin.Forms;

namespace XamarinFormsExercises.Views.BasicBinding
{
    public partial class BasicBindingExplorePage : ContentPage
    {
        public BasicBindingExplorePage()
        {
            InitializeComponent();

            label2.BindingContext = slider2;
            label2.SetBinding(Label.RotationProperty, "Value");

        }
    }
}