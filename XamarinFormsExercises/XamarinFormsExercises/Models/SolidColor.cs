using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace XamarinFormsExercises.Models
{
   public struct SolidColor
    {
        public string Name { get; set; }
        public Color Color { get; set; }
        public static IEnumerable<SolidColor> AllColors
        {
            get
            {
                //Use reflection and Linq to extend Color and get all solid colors.
                return typeof(Color).GetFields().Select(fi => new SolidColor { Name = fi.Name, Color = (Color)fi.GetValue(null) });
            }
        }
    }
}
