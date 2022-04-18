using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using Xamarin.Forms;

using XamarinFormsExercises.Models;

namespace XamarinFormsExercises.Views.ListViews
{
    public partial class ListViewDataModelExercisePage : ContentPage
    {
        public ListViewDataModelExercisePage()
        {
            InitializeComponent();
            DataModelList.ItemsSource = CityPopulation.List;
        }

        async void ListViewItemTapped (object sender, ItemTappedEventArgs e)
        {
            CityPopulation item = (CityPopulation)e.Item;
            await DisplayAlert("Tapped", item.ToString(), "OK");
            ((ListView)sender).SelectedItem = null;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ListViewImageExercisePage());
        }
        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}

