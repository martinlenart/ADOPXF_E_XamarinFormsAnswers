using System;
using System.Collections.Generic;
using Xamarin.Forms;
using System.Threading.Tasks;

namespace XamarinFormsExercises.Views.ListViews
{
    public partial class ListViewButtonExplorePage : ContentPage
    {
        public ListViewButtonExplorePage()
        {
            InitializeComponent();

            List<ListItem> ListItems = new List<ListItem> {
                new ListItem {Title = "First", Description="1st item", Price="$100.00"},
                new ListItem {Title = "Second", Description="2nd item", Price="$200.00"},
                new ListItem {Title = "Third", Description="3rd item", Price="$300.00"}
            };
            ButtonList.ItemsSource = ListItems;
        }

        public async void BuyClicked(object sender, EventArgs e)
        {
            var b = (Button)sender;
            var item = (ListItem)b.CommandParameter;
            await DisplayAlert("Clicked", item.Title.ToString() + " button was clicked", "OK");
        }

        public class ListItem
        {
            public string Title { get; set; }
            public string Description { get; set; }
            public string Price { get; set; }
        }

        private async void ButtonList_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            ListItem item = (ListItem)e.Item;
            await DisplayAlert("Tapped", item.Title + " was selected.", "OK");
            ((ListView)sender).SelectedItem = null;
        }
    }
}

