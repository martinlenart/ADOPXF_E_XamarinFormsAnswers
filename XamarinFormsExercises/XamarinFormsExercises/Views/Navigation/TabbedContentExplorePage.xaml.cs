using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFormsExercises.Views.Navigation
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TabbedContentExplorePage : TabbedPage
     {
        public TabbedContentExplorePage()
        {
            InitializeComponent();
            this.ItemsSource = new myTabB[] {
                new myTabB ("First", 1),
                new myTabB ("Second", 2),
                new myTabB ("Third", 3),
                new myTabB ("Fourth", 4),
                new myTabB ("Fifth", 5),
                new myTabB ("Sixth", 6)
            };
            CurrentPageChanged += CurrentPageHasChanged;
        }
        private void CurrentPageHasChanged(object sender, EventArgs e) => Title = CurrentPage.Title;
        protected override void OnAppearing()
        {
            base.OnAppearing();
            Title = CurrentPage.Title;
        }
    }

    class myTabB
    {
        public myTabB(string name, int number)
        {
            this.Name = name;
            this.Number = number;
        }
        public string Name { private set; get; }
        public int Number { private set; get; }
    }

}