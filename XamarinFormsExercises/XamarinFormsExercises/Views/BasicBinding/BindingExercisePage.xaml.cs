using Xamarin.Forms;

namespace XamarinFormsExercises.Views.BasicBinding
{
    public partial class BindingExercisePage : ContentPage
    {
        public BindingExercisePage()
        {
            InitializeComponent();

            label2.SetBinding(Label.RotationProperty, new Binding("Value", source: slider2a));
            label2.SetBinding(Label.ScaleProperty, new Binding("Value", source: slider2b));
            label2.SetBinding(Label.OpacityProperty, new Binding("Value", source: slider2c));
        }
    }
}