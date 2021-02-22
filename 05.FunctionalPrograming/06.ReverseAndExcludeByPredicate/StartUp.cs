using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.ReverseAndExcludeByPredicate
{
    class StartUp
    {
        static void Main()
        {

            List<int> numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToList();
            int divider =int.Parse(Console.ReadLine());
            numbers.Reverse();

            //Func<int, bool> predicate = x => x % divider != 0;   работи easyWay
            //numbers = numbers.Where(x =>predicate(x)).ToList();
            
            
            Predicate<int> predic = x => x % divider != 0;  // hardWay s method MyWhere
            numbers = MyWhere(numbers, predic);

            Action<List<int>> print = x => Console.WriteLine(string.Join(" ", numbers));
            
            print(numbers);
        }

        static List<int> MyWhere(List<int> numbers, Predicate<int> predicate)
        {
            List<int> filteredList = new List<int>();
            foreach (int currNum in numbers)
            {
                if (predicate(currNum))
                {
                    filteredList.Add(currNum);
                }
            }
            return filteredList;
        }
    }
}
