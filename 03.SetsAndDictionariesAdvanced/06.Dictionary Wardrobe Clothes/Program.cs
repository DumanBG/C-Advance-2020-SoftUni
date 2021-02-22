using System;
using System.Collections.Generic;

namespace _06.Dictionary_Wardrobe_Clothes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, int>> wardrope = new Dictionary<string, Dictionary<string, int>>();
            string[] delimeters = { " -> ", "," };
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(delimeters, StringSplitOptions.RemoveEmptyEntries);
                string color = input[0];
               
                if(!wardrope.ContainsKey(color))
                {
                    wardrope.Add(color, new Dictionary<string, int>());
                }
                for (int j = 1; j < input.Length; j++)
                {
                    if(!wardrope[color].ContainsKey(input[j]))
                    {
                        wardrope[color].Add(input[j], 0);

                    }
                    wardrope[color][input[j]]++;
                }


            }
            string[] clothWeNeed = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string neededColor = clothWeNeed[0];
            string neededCloth = clothWeNeed[1];


            foreach (var item in wardrope)
            {
                Console.WriteLine($"{item.Key} clothes:");
                foreach (var cloth in item.Value)
                {
                    Console.Write($"* {cloth.Key} - {cloth.Value}");

                    if (item.Key == neededColor &&cloth.Key == neededCloth)
                    {
                        Console.Write(" (found!)");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
