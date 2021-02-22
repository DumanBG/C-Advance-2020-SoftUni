using System;
using System.Collections.Generic;

namespace _03.Set_Periodic_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            SortedSet<string> chemicals = new SortedSet<string>();
            for (int i = 0; i < number; i++)
            {
                string[] inputData = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                foreach (var item in inputData)
                {

                    chemicals.Add(item);
                }
            }

            foreach (var chemical in chemicals)
            {
                Console.Write(chemical + " ");
            }
        }
    }
}
