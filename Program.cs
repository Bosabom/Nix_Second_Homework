using System;

namespace Nix_Second_Homework
{
    class Program
    {
       
        static void Main(string[] args)
        {
            DistanceBetweenCities dist = new DistanceBetweenCities();
            Console.WriteLine("List of cities:");
            foreach(var city in dist.cities)
            {
                Console.WriteLine(city.Name);
            }

            Console.WriteLine("Input first city:");
            string firstCity = Console.ReadLine();
            Console.WriteLine("Input second city:");
            string secondCity = Console.ReadLine();

            int distance_between_two_cities = dist.Calculate_Distance(firstCity, secondCity);
            Console.WriteLine($"Distance between {firstCity} and {secondCity} is {distance_between_two_cities} km");
        }
    }
}
