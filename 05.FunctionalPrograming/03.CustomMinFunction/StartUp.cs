using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.CustomMinFunction
{
    class StartUp
    {
        static void Main()
        {
            //  int[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(x=> int.Parse(x)).ToArray(); // easy !!
            //Console.WriteLine(numbers.Min()); // easy 
            //Console.WriteLine(string.Join(" ",numbers));

            List<int> numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(CustomParsing).ToList();
            Func<List<int>, int> funcMinNum = numbers =>
             {
                 int minNum = int.MaxValue;
                 foreach (var item in numbers)
                 {
                     if (item < minNum)
                     {
                         minNum = item;
                     }
                 }
                 return minNum;
             };
            // FindCustumMin(numbers);

             Console.WriteLine(funcMinNum(numbers));
           
        }

        private static void FindCustumMin(List<int> numbers)
        {
         Console.WriteLine(numbers.Min());
        }

        private static int CustomParsing(string arg1)
        {

            return int.Parse(arg1);
        }
    }
}
