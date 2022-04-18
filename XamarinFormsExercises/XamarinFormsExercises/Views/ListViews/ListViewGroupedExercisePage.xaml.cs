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
    public partial class ListViewGroupedExercisePage : ContentPage
    {
        public ListViewGroupedExercisePage()
        {
            InitializeComponent();

            IEnumerable<City> items = City.List;
            var groupedList = items.OrderBy(c => c.Continent).ThenBy(c => c.Population).GroupBy(c => c.Continent);

            CustomGroupedList.ItemsSource = groupedList;
 
            //NavigationPage.SetTitleIconImageSource(this, "first.png"); //iOS and Android
            //NavigationPage.SetHasNavigationBar(this, false); // iOS and Android
            //NavigationPage.SetHasBackButton(this, false); // On all platforms
        }

        private async void ListViewItemTapped(object sender, ItemTappedEventArgs e)
        {
            City item = (City)e.Item;
            await DisplayAlert("Item Tapped", item.Name, "OK");
            ((ListView)sender).SelectedItem = null;
        }

        private async void MoreButton_Clicked(object sender, EventArgs e)
        {
            var b = (Button)sender;
            var item = (City)b.CommandParameter;
            await DisplayAlert("Button Clicked", $"{item.Name} in {item.Continent} has a population of {item.Population}.", "OK");
        }
        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            await Navigation.PopToRootAsync();
        }
    }
}