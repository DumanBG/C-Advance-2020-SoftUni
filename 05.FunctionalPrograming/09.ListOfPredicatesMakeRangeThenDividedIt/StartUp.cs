using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.ListOfPredicatesMakeRangeThenDividedIt
{
    class StartUp
    {
        static void Main()
        {
            int endRange = int.Parse(Console.ReadLine());
            List<int> dividers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToList();
            Func<int, int, bool> predicate = (num, d) => num % d == 0;
            // List<int> firstList = new List<int>();
            // firstList = Enumerable.Range(1, endRange).ToList(); //..Създаване на числа в range  от старт до енд

            for (int i = 1; i <= endRange; i++)
            {

                if (dividers.All(d => predicate(i, d)))
                {

                    Console.Write(i + " ");
                }
            }
        }
    }
}
 /// work but use to much memory

//            // Console.WriteLine(firstList.All(x => x <= 10));

//            List<int> dividedNumbers = new List<int>();
//            foreach (var num in firstList)
//            {
//                // Дали curr num  се дели на всяко число от листа с dividers
//              //  if (dividers.All(d => num % d == 0))   work !!
//              if(dividers.All(d=>predicate(num,d)))
//                {

//                    dividedNumbers.Add(num);
//                }

//            }
//            Console.WriteLine(string.Join(" ", dividedNumbers));
//        }
//    }
//}
