using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Scheduling25October2020
{
   public class StartUp
    {
        public static void Main()
        {

            Stack<int> task =new Stack<int>(Console.ReadLine().Split(",", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray());
            Queue<int> thread =new Queue<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray());
            int killerTask = int.Parse(Console.ReadLine());

            int lastThread = -1;
            while(true)
            {
                int currTask = task.Peek();
                int currTread = thread.Peek();
                if(currTask == killerTask)
                {
                    lastThread = currTread;



                    break;
                }else if( currTask <= currTread)
                {
                    task.Pop();
                    thread.Dequeue();
                        
                }else
                {

                    thread.Dequeue();
                }

            }
            Console.WriteLine($"Thread with value {lastThread} killed task {killerTask}");

            Console.WriteLine(string.Join(" ", thread));
        }
    }
}
