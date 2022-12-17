using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MeasureDuringDevelopment
{
    internal static class PeopleManager
    {
        public static void AddPeople(ICollection<Person> peopleList)
        {
            for (var i = 0; i < 1000; i++)
            {
                peopleList.Add(new Person
                {
                    Age = new Random().Next(1, 90)
                });
            }
        }

        public static void MeasureAges(ICollection<Person> peopleList)
        {
            var babies = peopleList.Where(x => x.Age < 2).Sum(x => x.Age);
            var kids = peopleList.Where(x => x.Age > 2 && x.Age < 16).Sum(x => x.Age);
            var adults = peopleList.Where(x => x.Age > 16 && x.Age < 60).Sum(x => x.Age);
            var olds = peopleList.Where(x => x.Age > 60).Sum(x => x.Age);

            Console.WriteLine($"Babies {babies}");
            Console.WriteLine($"Kids {kids}");
            Console.WriteLine($"Adults {adults}");
            Console.WriteLine($"Olds {olds}");
        }
    }
}
