using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFormsExercises.Views.NonTrivialBinding
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BindingExercise : ContentPage
    {
        public BindingExercise()
        {
            InitializeComponent();

            #region Step 3
            BindingContext = new BindingExerciseViewModel { SliderValue = 0.2F, StepperValue = 0.2F };
            #endregion
        }

        #region Step 2
        private void Button_Clicked(object sender, EventArgs e)
        {
            mySlider.Value = mySlider.Maximum / 2;
            myStepper.Value = myStepper.Maximum / 2;
        }
        #endregion

        #region Step 5
        private void Button_Clicked_1(object sender, EventArgs e)
        {
            ((BindingExerciseViewModel)BindingContext).SliderValue = 0.5F;
            ((BindingExerciseViewModel)BindingContext).StepperValue = 5;
        }
        #endregion

        private async void Button_Clicked_2(object sender, EventArgs e)
        {
            var item = BindingContext as BindingExerciseViewModel;
            await DisplayAlert("Instance Values", 
                $"SliderValue {item.SliderValue}\nStepperValue {item.StepperValue}", "OK");


        }
    }

    #region Step 3 and 4
    public class BindingExerciseViewModel: BaseViewModel //Inheritance step 4
    {
        #region Step 3 
        //public float SliderValue { get; set; }
        //public float StepperValue { get; set; }
        #endregion

        
        #region Step 4
        
        float _slidervalue;
        public float SliderValue
        {
            set => Set<float>(ref _slidervalue, value, "SliderValue");
            get => _slidervalue;
        }
        float _steppervalue;
        public float StepperValue
        {
            set => Set<float>(ref _steppervalue, value, "StepperValue");
            get => _steppervalue;
        }
        
        #endregion

        #region Step 6
        Command _SetMiddleCommand;
        public Command SetMiddleCommand => _SetMiddleCommand ?? (_SetMiddleCommand =
            new Command(() =>
            {
                SliderValue = 0.5F;
                StepperValue = 5;
            }));
        #endregion
    }


    #region Step 4
    /* Copy into  BindingExerciseViewModel and replace exisiting properties
        float _slidervalue;
        public float SliderValue
        {
            set => Set<float>(ref _slidervalue, value, "SliderValue");
            get => _slidervalue;
        }
        float _steppervalue;
        public float StepperValue
        {
            set => Set<float>(ref _steppervalue, value, "StepperValue");
            get => _steppervalue;
        }
    */
    #endregion

    public abstract class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void Set<T>(ref T field, T newValue, [CallerMemberName] string propertyName = null)
        {
            if (!EqualityComparer<T>.Default.Equals(field, newValue))
            {
                field = newValue;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
    #endregion

    #region Step 6
    /* Copy into  BindingExerciseViewModel and replace exisiting properties
    Command _SetMiddleCommand;
    public Command SetMiddleCommand => _SetMiddleCommand ?? (_SetMiddleCommand =
        new Command(() =>
        {
            SliderValue = 0.5F;
            StepperValue = 5;
        }));
    */
    #endregion
}