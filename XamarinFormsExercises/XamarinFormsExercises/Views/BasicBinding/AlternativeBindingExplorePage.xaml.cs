using Xamarin.Forms;

namespace XamarinFormsExercises.Views.BasicBinding
{
    public partial class AlternativeBindingExplorePage : ContentPage
    {
        public AlternativeBindingExplorePage()
        {
            InitializeComponent();
            label2.SetBinding(Label.RotationProperty, new Binding("Value", source: slider2));
        }
    }
}