using System;
using System.Collections.Generic;

using Xamarin.Forms;
using XamarinFormsExercises.ViewModels;

namespace XamarinFormsExercises.Views.NonTrivialBinding
{
	public partial class GridBindingExercise : ContentPage
	{
		private GridBindingExerciseViewModel viewModel => BindingContext as GridBindingExerciseViewModel;
		public GridBindingExercise()
		{
			InitializeComponent();
			BindingContext = new GridBindingExerciseViewModel();
		}
	}
}

