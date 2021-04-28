using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nix_Second_Homework
{
    struct City
    {
        public string Name;
        public int Distance_From_Capital;
    }
    class DistanceBetweenCities
    {
       internal List<City> cities;
        public DistanceBetweenCities()
        {
            cities = new List<City>();
            cities.Add(new City { Name="Kyiv",Distance_From_Capital=0 });
            cities.Add(new City { Name = "Borispol", Distance_From_Capital = 38 });
            cities.Add(new City { Name = "Piryatin", Distance_From_Capital = 165 });
            cities.Add(new City { Name = "Lubny", Distance_From_Capital = 212 });
            cities.Add(new City { Name = "Horol", Distance_From_Capital = 253 });
            cities.Add(new City { Name = "Reshetilovka", Distance_From_Capital = 326 });
            cities.Add(new City { Name = "Poltava", Distance_From_Capital = 365 });
            cities.Add(new City { Name = "Chutovo", Distance_From_Capital = 417 });
            cities.Add(new City { Name = "Valki", Distance_From_Capital = 455 });
            cities.Add(new City { Name = "Lubotin", Distance_From_Capital = 492 });
            cities.Add(new City { Name = "Pisochyn", Distance_From_Capital = 507 });
            cities.Add(new City { Name = "Kharkov", Distance_From_Capital = 518 });
        }

        static void Swap<T>(ref T obj1, ref T obj2)
        {
            var temp = obj1;
            obj1 = obj2;
            obj2 = temp;
        }

        internal int Calculate_Distance(string cityFrom, string cityTo)
        {
            int result = 0;
            var from = cities.Select(t => t.Name).ToList().IndexOf(cityFrom);  //n
            var to = cities.Select(t => t.Name).ToList().IndexOf(cityTo);      //n
            if(from > to)
            {
                Swap(ref from, ref to); 
            }
            //расстояние между 1 и 2 городом(вычитаются расстояния от столицы)
            result = cities[to].Distance_From_Capital - cities[from].Distance_From_Capital;

            return result;
        }
    }
}
