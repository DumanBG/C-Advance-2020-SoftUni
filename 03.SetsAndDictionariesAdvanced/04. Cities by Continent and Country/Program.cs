using System;
using System.Collections.Generic;

namespace _04._Cities_by_Continent_and_Country
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, List<string>>> continents = new Dictionary<string, Dictionary<string, List<string>>>();

            for (int i = 0; i < number; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string continent = input[0];
                string country = input[1];
                string city = input[2];

                if (!continents.ContainsKey(continent))
                {
                    continents.Add(continent, new Dictionary<string, List<string>>());
                }
                if (!continents[continent].ContainsKey(country))
                {
                    continents[continent].Add(country, new List<string>());
                }
                Dictionary<string, List<string>> focus = continents[continent];

                continents[continent][country].Add(city);

            }
            foreach (var continent in continents)
            {
                Console.WriteLine($"{continent.Key}:");

                foreach (var country in continent.Value)
                {
                    Console.Write($"  {country.Key} -> ");

                    
                    for (int i = 0; i < country.Value.Count; i++)
                    {
                        if (i == 0)
                        {
                            Console.Write(country.Value[i]);
                        }
                        else
                        {
                            Console.Write($", {country.Value[i]}");
                        }
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}

