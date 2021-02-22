using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.AppliedArithmeticsByFunc
{
    class StartUp
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToList();
            string input = Console.ReadLine();

            Func<int, int> arithmeticFunc = num => num;
            Action<List<int>> print = nums => Console.WriteLine(string.Join(" ", nums));

            while (input.ToLower() != "end")
            {
                switch (input.ToLower())
                {
                    case "add":
                        arithmeticFunc = num => num + 1;
                        //  numbers = numbers.Select(n => arithmeticFunc(n)).ToList(); // LongWay work!
                        //numbers = numbers.Select(arithmeticFunc).ToList();
                        numbers = ArithmeticOnEachNumber(arithmeticFunc, numbers);
                        break;

                    case "multiply":
                        arithmeticFunc = num => num * 2;
                        numbers = ArithmeticOnEachNumber(arithmeticFunc, numbers);
                        break;

                    case "subtract":
                        arithmeticFunc = num => num - 1;
                        numbers = ArithmeticOnEachNumber(arithmeticFunc, numbers);
                        break;

                    case "print":

                        print(numbers);
                        break;
                }
                input = Console.ReadLine();
            }
        }



        private static List<int> ArithmeticOnEachNumber(Func<int, int> func, List<int> nums)
        {

            return nums = nums.Select(n => func(n)).ToList();
        }
    }
}
