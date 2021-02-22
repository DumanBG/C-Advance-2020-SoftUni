using System;
using System.Collections.Generic;
using System.Linq;

namespace _11.KeyRevolverQueueAndStacksExam
{
    class Program
    {
        static void Main(string[] args)
        {

            //  50 цена патрон
            //  2    пълнител
            //  11 10 5 11 10 20 куршуми
            //  15 13 16 ключалки
            //  1500  инт награда

            int priceOfOneBullet = int.Parse(Console.ReadLine());
            int sizeOfGunBarrel = int.Parse(Console.ReadLine());
            int[] bulletsArr = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[] locksArr = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int intelligence = int.Parse(Console.ReadLine());

            Stack<int> bullets = new Stack<int>(bulletsArr);
            Queue<int> locks = new Queue<int>(locksArr);
            int totalBullets = bullets.Count();

            int currentBarrel = sizeOfGunBarrel;
            while (bullets.Count > 0 && locks.Count > 0)
            {

                currentBarrel--;

                int currBullet = bullets.Pop();
                int currLock = locks.Peek();

                if (currBullet <= currLock)
                {

                    Console.WriteLine("Bang!");
                    locks.Dequeue();
                }
                else
                {
                    Console.WriteLine("Ping!");
                }
                if (currentBarrel == 0 && bullets.Count > 0)
                {
                    Console.WriteLine("Reloading!");
                    currentBarrel = sizeOfGunBarrel;
                }

            }

            if (locks.Count == 0)
            {
                int moneyLearn = intelligence - (totalBullets - bullets.Count) * priceOfOneBullet;
                Console.WriteLine($"{bullets.Count} bullets left. Earned ${moneyLearn}");


            }
            else


                Console.WriteLine($"Couldn't get through. Locks left: {locks.Count}");
        }
    }
}

