using Xamarin.Forms;
using XamarinFormsExercises.Models;

namespace XamarinFormsExercises.Views.UI
{
    public partial class SelectingValueExplorePage : ContentPage
    {
        public SelectingValueExplorePage()
        {
            InitializeComponent();
            picker.ItemsSource = Person.Factory.CreateRandom(10);
        }
        private void picker_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            var s = (Picker)sender;
            if (s.SelectedIndex == -1) return;

            Person person1 = (Person)s.SelectedItem;

            string personsAsString = s.Items[s.SelectedIndex];
            Person person2 = (Person)s.ItemsSource[s.SelectedIndex];
        }
    }
}
