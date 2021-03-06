﻿
using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Gondor

{
    public class Program
    {
       public  static void Main(string[] args)
        {
            int numberOfWaves = int.Parse(Console.ReadLine());

            List<int> plates = Console.ReadLine().Split().Select(int.Parse).ToList();


            Stack<int> orcs = new Stack<int>();

            for (int i = 1; i <= numberOfWaves; i++)
            {
                if (plates.Count == 0)
                {
                    break;
                }
                int[] warrior = Console.ReadLine() .Split()  .Select(int.Parse).ToArray();

                if (i % 3 == 0)
                {
                    int addPlate = int.Parse(Console.ReadLine());
                    plates.Add(addPlate);
                }

                foreach (var war in warrior)
                {
                    orcs.Push(war);
                }
                while (plates.Count > 0 && orcs.Count > 0)// to do curr item
                {
                    int currOrc = orcs.Pop();
                    int currPlate = plates[0];

                    if (currPlate > currOrc)
                    {
                        currPlate -= currOrc;
                        plates[0] = currPlate;
                    }
                    else if (currPlate < currOrc)
                    {
                        currOrc -= currPlate;
                        orcs.Push(currOrc);
                        plates.RemoveAt(0);
                    }
                    else
                    {
                        plates.RemoveAt(0);
                    }
                }
            }
            if (plates.Count > 0)
            {
                Console.WriteLine("The people successfully repulsed the orc's attack.");

                Console.Write($"Plates left: { string.Join(", ", plates)}");

            }
            else
            {
                
                Console.WriteLine("The orcs successfully destroyed the Gondor's defense.");

                Console.Write($"Orcs left: {string.Join(", ", orcs)}");
            }
        }
    }
}