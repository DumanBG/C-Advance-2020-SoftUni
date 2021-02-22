using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._FindEvensOrOdds
{
    class StartUp
    {
        static void Main()
        {
            List<int> ranges = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToList();

            string command = Console.ReadLine();
            int start = ranges[0];
            int end = ranges[1];


            Predicate<int> predicate = n => true;
            Func<int, int, List<int>> generateRangeOfNumbs = (s, e) =>
            {

                List<int> nums = new List<int>();

                for (int i = s; i <= e; i++)
                {
                    nums.Add(i);
                }

                return nums;

            };
           List<int> numbersFastWay = Enumerable.Range(start, end).ToList();   //Кратък и бърз !!!
            List<int> numbers = generateRangeOfNumbs(start, end);

            // Console.WriteLine(string.Join(" ", numbers));
            if (command.ToLower() == "even")
            {
                predicate = n => n % 2 == 0;

            }else if(command.ToLower()== "odd")
            {
                predicate = n => n % 2 != 0;

               
            }
            else
            {
                Console.WriteLine("Incorect command! Need even or odd!");
            }

            numbers = MyWhere(predicate, numbers);
            Console.WriteLine(string.Join(" ", numbers));
        }
        private static List<int> MyWhere(Predicate<int> predicate, List<int> nums)
        {
            List<int> filteredList = new List<int>();
            foreach (int currNum in nums)
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
