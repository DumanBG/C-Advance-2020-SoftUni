using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Same_Values_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {

            double[] inputData = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
            Dictionary<double, int> numbers = new Dictionary<double, int>();

            for (int i = 0; i < inputData.Length; i++)
            {
                if(!numbers.ContainsKey(inputData[i]))
                    
            {
                    numbers.Add(inputData[i], 0);
            }

                numbers[inputData[i]]++;

            }

            foreach (var item in numbers)
            {
                Console.WriteLine($"{item.Key} - {item.Value} times");
            }

        }
    }
}
