using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using XamarinFormsExercises.Models;

namespace XamarinFormsExercises.Views.ListViews
{
    public partial class ListViewGroupedExplorePage : ContentPage
    {
        public ListViewGroupedExplorePage()
        {
            InitializeComponent();

            var items = Models.Rectangle.List;
            var groupeditems = items.OrderByDescending(r => r.Area).GroupBy(r => r.Color, r => r);

            groupedList.ItemsSource = groupeditems;
        }

        private async void ListViewItemTapped(object sender, ItemTappedEventArgs e)
        {
            var item = e.Item as Models.Rectangle;
            if (item != null) await DisplayAlert("Item tapped", $"Rectangle selected: {item}", "OK");

            ((ListView)sender).SelectedItem = null;
        }
    }
}