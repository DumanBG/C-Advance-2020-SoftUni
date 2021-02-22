using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Sets_of_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] rows = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            HashSet<int> setN = new HashSet<int>();
            HashSet<int> setM = new HashSet<int>();
            HashSet<int> ultimateSet = new HashSet<int>();
          

            int n = rows[0];
            int m = rows[1];

            for (int i = 0; i < n; i++)
            {
                int currentN = int.Parse(Console.ReadLine());

               setN.Add(currentN);
               
            }
            for (int i = 0; i < m; i++)
            {
                int currentM = int.Parse(Console.ReadLine());

                setM.Add(currentM);
            }

            foreach (var number in setN)
            {
                if (setM.Contains(number))
                {
                    ultimateSet.Add(number);
                }
            }
            foreach (var number in setM)
            {
                if(setN.Contains(number))
                {
                    ultimateSet.Add(number);
                }
            }
            foreach (var item in ultimateSet)
            {
                Console.Write(item + " ");
            }
            
        }
    }
}
