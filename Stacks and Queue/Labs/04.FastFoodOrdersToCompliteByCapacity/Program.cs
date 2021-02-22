using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.FastFoodOrdersToCompliteByCapacity
{
    class Program
    {
        static void Main(string[] args)
            //348
            //20 54 30 16 7 9

           
        {
            int foodQuantity = int.Parse(Console.ReadLine());
            int[] foodOrders = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();

            Queue<int> orders = new Queue<int>(foodOrders);
            Console.WriteLine(orders.Max());

            while(orders.Any())
            {
                int currentOrder = orders.Peek();
              
                if(foodQuantity >=currentOrder)
                {
                    foodQuantity -= orders.Dequeue();
                }
                else
                {
                    break;
                }


            }
            if (orders.Any())
            {
                Console.Write("Orders left:");
                while(orders.Any())
                {
                    Console.Write($" {orders.Dequeue()}");
                }
            }
            else
            {
                Console.WriteLine("Orders complete");
            }


        }
    }
}
