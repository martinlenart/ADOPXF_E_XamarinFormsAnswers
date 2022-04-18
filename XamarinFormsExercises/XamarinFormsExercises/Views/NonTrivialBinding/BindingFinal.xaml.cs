using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinFormsExercises.ViewModels;

namespace XamarinFormsExercises.Views.NonTrivialBinding
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BindingFinal : ContentPage
    {
        public BindingFinal()
        {
            InitializeComponent();
            BindingContext = new BindingFinalViewModel { SliderValue = 0.2F, StepperValue = 0.2F };
        }
    }
}