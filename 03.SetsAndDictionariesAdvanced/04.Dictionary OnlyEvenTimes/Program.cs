using System;
using System.Collections.Generic;

namespace _04.Dictionary_OnlyEvenTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            Dictionary<int, int> numbers = new Dictionary<int, int>();

            for (int i = 0; i < number; i++)
            {
                int input = int.Parse(Console.ReadLine());

               if(!numbers.ContainsKey(input))
                {
                    numbers.Add(input, 0);
                }
                numbers[input]++;
            }

            foreach (var item in numbers)
            {
                if(item.Value %2 ==0)
                {
                    Console.WriteLine(item.Key);
                }
            }
        }
    }
}
