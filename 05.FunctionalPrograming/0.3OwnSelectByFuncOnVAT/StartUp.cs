using System;
using System.Linq;

namespace _04.OwnSelectByFuncOnVAT
{
    class StartUp
    {
        static void Main()
        {
            decimal[] numbers = Console.ReadLine().Split(", ")
                .Select(decimal.Parse)
              //  .Select(number => number + (number * 0.2m))Лесен вар
                .ToArray();
            numbers = Select(numbers, number =>number+number/5);  //  по 0.2
          

            foreach (var number in numbers)
            {
                Console.WriteLine($"{number:f2}");
            }
        }

        static decimal[] Select(decimal[] array, Func<decimal,
            decimal> transformer)
        {
            decimal[] newArray = new decimal[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                newArray[i] = transformer(array[i]);
            }

            return newArray;
        }
    }
}
