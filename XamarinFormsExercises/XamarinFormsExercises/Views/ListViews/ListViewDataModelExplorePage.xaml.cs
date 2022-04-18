using System;
using System.Collections.Generic;

using Xamarin.Forms;
using System.Threading.Tasks;

namespace XamarinFormsExercises.Views.ListViews
{
    public partial class ListViewDataModelExplorePage : ContentPage
    {
        public ListViewDataModelExplorePage()
        {
            InitializeComponent();
            List<ListItem> ListItems = new List<ListItem>
            {
                new ListItem {Title = "First", Description="1st item"},
                new ListItem {Title = "Second", Description="2nd item"},
                new ListItem {Title = "Third", Description="3rd item"}
            };
            DataModelList.ItemsSource = ListItems;
        }

        async void ListViewItemTapped (object sender, ItemTappedEventArgs e)
        {
            ListItem item = (ListItem)e.Item;
            await DisplayAlert("Tapped", item.Title + " was selected.", "OK");
            ((ListView)sender).SelectedItem = null;
        }

        public class ListItem
        {
            public string Title { get; set; }
            public string Description { get; set; }
        }
    }
}

