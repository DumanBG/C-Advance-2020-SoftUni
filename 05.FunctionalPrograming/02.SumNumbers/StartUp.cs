using System;
using System.Linq;

namespace _02.CountAndSumByOwnFunc
{
    class StartUp
    {
        static void Main()
        {
            PrintSumAndCount(
              arr=>  int.Parse(arr),  //  = само int.Parse
                arrr => arrr.Length,  // countGetter
                array =>  // sumGetter може и директно   array => array.Sum
                {
                    int sum = 0;
                    foreach (var item in array)
                    {
                        sum += item;
                    }

                    return sum;
                });
        }

        static void PrintSumAndCount(Func<string, int> parser, // parser Взема string и го парсва къхм int може и само int.parse
            Func<int[], int> countGetter, //counter
            Func<int[], int> sumGetter)
        {
            int[] array =
                Console.ReadLine()
                .Split(", ",StringSplitOptions.RemoveEmptyEntries)
                .Select(parser)
                .ToArray();

            Console.WriteLine(countGetter(array));
            Console.WriteLine(sumGetter(array));
        }
    }
}