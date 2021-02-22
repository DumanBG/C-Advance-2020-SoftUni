using System;
using System.Linq;

namespace _12.TriFunction
{
    class StartUp
    {
        public static void Main()
        {
            //          800                                      //Petromir
            //          Qvor Qnaki Petromir Sadam

            int n = int.Parse(Console.ReadLine());
            string[] names = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            Func<string, int, bool> isLonger = (str, num) => str.ToCharArray().Select(c => (int)c).Sum() >= num;  // вземане на сума от чарове на стринг

            Func<string[], int, Func<string, int, bool>, string> findBiggestName = (arr, num, func) => arr.FirstOrDefault(s => func(s, num));

            string result = findBiggestName(names, n, isLonger);
            Console.WriteLine(result);
        }
    }
}