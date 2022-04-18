using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XamarinFormsExercises.Views.Navigation
{
	public partial class CarouselNavigationExercise : CarouselPage
	{
		public CarouselNavigationExercise()
		{
			InitializeComponent ();
			this.Children.Add(new WebViewExercisePage("http://www.svd.se", "Svenska Dagbladet"));
			this.Children.Add(new WebViewExercisePage("http://www.dn.se", "Dagens Nyheter"));
			this.Children.Add(new WebViewExercisePage("http://www.cnn.com", "CNN"));
		}
	}
}

