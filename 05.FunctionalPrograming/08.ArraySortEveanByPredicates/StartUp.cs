using System;
using System.Collections;
using System.Linq;

namespace _08.ArraySortEveanByPredicates
{
    class StartUp
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).OrderBy(x => x).ToArray();
            // сортиране на array първо по четни, после по нечетни във възходящ ред
            Array.Sort(numbers, (a, b) =>
            {
                // a odd  and b -evan
                if (a % 2 != 0 && b % 2 == 0)
                {
                    return 1;
                }
                // a -evan and b - odd
                else if (a % 2 == 0 && b % 2 != 0)
                {
                    return -1;
                }
                else
                {  //   И двете ODD или и двете Evan
                    int temp = a.CompareTo(b);
                    return temp;
                }
            });
            Console.WriteLine(string.Join(" ", numbers));

        }
    }
}
