using System;
using System.Collections.Generic;

namespace QueueHotPotatoCircle
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lucas Jacob Noah Logan Ethan             // 2
            string[] names = Console.ReadLine().Split();
            int patatoNumber = int.Parse(Console.ReadLine());

            Queue<string> queue = new Queue<string>(names);
            int counter = 0;
           
            
               while(queue.Count>1)
            {
                counter++;
                if(counter % patatoNumber !=0)
                {

                   queue.Enqueue(queue.Dequeue()); // вземаме първото вкарано дето и го слагаме като последно( махайки го от първо място)
                    
                }else
                {
                    Console.WriteLine($"Removed {queue.Dequeue()}"); // кратно на брояча и махамае първото дете
                }
            }
            Console.WriteLine($"Last is {queue.Dequeue()}"); // Последното останало дете е

        }
    }
}
