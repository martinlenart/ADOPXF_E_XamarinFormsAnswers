using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace XamarinFormsExercises.Models
{

    public class Person
    {
        public string Name { set; get; }
        public DateTime Birthday { set; get; }
        public SolidColor FavoriteColor { set; get; }
        public override string ToString() => $"Name: {Name}, Birthday: {Birthday.ToShortDateString()}, Favorite color: {FavoriteColor.Name}";

        public static class Factory
        {
            public static Person CreateRandom()
            {
                var _firstnames = "Abigail, Bob, Cathy, David, Eugenie, Freddie, Greta, Harold, Irene, Jonathan, Kathy".Split(',');
                var _colors = SolidColor.AllColors.ToList();

                var rnd = new Random();
                while (true)
                {
                    try
                    {
                        int _year = rnd.Next(1960, DateTime.Now.Year - 5);
                        int _month = rnd.Next(1, 13);
                        int _day = rnd.Next(1, 31);
                        var _birthday = new DateTime(_year, _month, _day);

                        var _name = _firstnames[rnd.Next(_firstnames.Length)];
                        var _color = _colors[rnd.Next(_colors.Count)];

                        return new Person { Name = _name, Birthday = _birthday, FavoriteColor = _color };
                    }
                    catch { }
                }
            }
            public static List<Person> CreateRandom(int NrOfItems)
            {
                var persons = new List<Person>();
                for (int i = 0; i < NrOfItems; i++)
                {
                    persons.Add(CreateRandom());
                }
                return persons;
            }
        }
    }
}
