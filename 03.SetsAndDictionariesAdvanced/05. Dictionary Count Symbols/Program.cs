using System;
using System.Collections.Generic;

namespace _05._Dictionary_Count_Symbols
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            SortedDictionary<char, int> data = new SortedDictionary<char, int>();

            foreach (var item in input)
            {

                if(!data.ContainsKey(item))
                {
                    data.Add(item,0);
                }
                data[item]++;
            }

            foreach (var item in data)
            {
                Console.WriteLine($"{item.Key}: {item.Value} time/s");
            }
        }
    }
}
