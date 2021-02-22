using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Lootbox22Feb2020
{
   public class StartUp
    {
      public  static void Main()
        {
            Queue<int> firstLootQueue = new Queue<int>(Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray());
            Stack<int> SecondLootStack = new Stack<int>(Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray());

            int finalLoot = 0;
            while(firstLootQueue.Count>0 && SecondLootStack.Count>0)
            {
                int currQueue = firstLootQueue.Peek();
                int currStack = SecondLootStack.Peek();

                int sum = currQueue + currStack;

                if(sum %2 == 0)
                {
                    firstLootQueue.Dequeue();
                    SecondLootStack.Pop();
                    finalLoot += sum;
                }
                else
                {
                    SecondLootStack.Pop();
                    firstLootQueue.Enqueue(currStack);
                }
            }
            if(firstLootQueue.Count >0)
            {
                Console.WriteLine("Second lootbox is empty");
            }
            else
            {
                Console.WriteLine("First lootbox is empty");
            }

            if(finalLoot >= 100)
            {
                Console.WriteLine($"Your loot was epic! Value: { finalLoot}");
            }
            else
            {
                Console.WriteLine($"Your loot was poor... Value: {finalLoot}");
            }

        }
    }
}
