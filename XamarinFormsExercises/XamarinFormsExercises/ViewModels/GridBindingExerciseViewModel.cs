using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace XamarinFormsExercises.ViewModels
{
	public class GridBindingExerciseViewModel : BaseViewModelFinal
	{
		string _name;
		public string Name { get =>_name; set => Set<string>(ref _name, value, "Name"); } 

		string _email;
		public string Email { get =>_email; set => Set<string>(ref _email, value, "Email"); }

		ICommand _cityToggle;
		public ICommand CityToggle => _cityToggle;
        public GridBindingExerciseViewModel()
        {
			_name = "Ove";
			_email = "ove@glad.com";
			_cityToggle = new Command<string>(CityToggleCommand);
		}

		private void CityToggleCommand (string CommandParameters)
        {
			if (Name == "Georg")
			{
				Name = "Ove";
				Email = "ove@glad.com";
			}
			else
			{
				Name = "Georg";
				Email = "georg@nyfiken.com";
			}
		}
	}
}
