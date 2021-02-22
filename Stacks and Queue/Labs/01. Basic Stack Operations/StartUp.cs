using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Basic_Stack_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            //5 2 13
            //1 13 45 32 4


            int[] data = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();
            int [] array = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();

            int large = data[0];
            int toPop = data[1];
            int xToSearch = data[2];

            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < large; i++)
            {
                stack.Push(array[i]);

            }
           
            
                for (int i = 0; i < toPop; i++)
                {
                    stack.Pop();
                }
            
            bool isThere = false;
            int theSmallestNumber = int.MaxValue;
            
            foreach (var item in stack)
            {
                if( item == xToSearch)
                {
                    isThere = true;

                    Console.WriteLine("true");
                    return;
                }
                if(item < theSmallestNumber)
                {
                    theSmallestNumber =item;
                }

            }
            if (stack.Count > 0)
            {
                Console.WriteLine(theSmallestNumber);
            }
            else
            {
                Console.WriteLine("0");
            }
            
            //Console.WriteLine(string.Join(" ",number));



        }
    }
}
