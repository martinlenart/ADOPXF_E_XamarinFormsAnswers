using Xamarin.Forms;
using XamarinFormsExercises.Models;

namespace XamarinFormsExercises.Views.UI
{
    public partial class SelectingValueExercisePage : ContentPage
    {
        public SelectingValueExercisePage()
        {
            InitializeComponent();
            picker.ItemsSource = Person.Factory.CreateRandom(10);
        }

        private void checkbox_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            var s = (CheckBox)sender;
            lblPropChanged.Text = $"CheckBox changed and is now {s.IsChecked}";
        }

        private void slider_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            var s = (Slider)sender;
            lblPropChanged.Text = $"Slider changed and is now {s.Value}";
        }
  

        private void stepper_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            var s = (Stepper) sender;
            lblPropChanged.Text = $"Stepper changed and is now {s.Value}";
        }

        private void switch_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            var s = (Switch)sender;
            lblPropChanged.IsVisible = s.IsToggled;
            bwPropChanged.IsVisible = s.IsToggled;
        }

        private void DatePicker_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            var s = (DatePicker)sender;
            lblPropChanged.Text = $"DatePicker changed and is now {s.Date}";
        }

        private void TimePicker_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            var s = (TimePicker)sender;
            lblPropChanged.Text = $"TimePicker changed and is now {s.Time}";
        }

        private void picker_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            var s = (Picker)sender;
            if (s.SelectedIndex == -1) return;

            lblPropChanged.Text = $"Picker changed and is now {s.SelectedItem}";
            bwPropChanged.Color = ((Person)s.ItemsSource[s.SelectedIndex]).FavoriteColor.Color;
        }
    }
}
