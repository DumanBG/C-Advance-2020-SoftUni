using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.SongsQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arraySongs = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            Queue<string> songsQueue = new Queue<string>(arraySongs);

            string input = Console.ReadLine();
            while (songsQueue.Any())
            {


                if (input.Contains("Add"))
                {
                    var songToAdd = input.Split("Add ",StringSplitOptions.RemoveEmptyEntries); // сплит по " адд _ "

                    if (!songsQueue.Contains(songToAdd[0]))
                    {
                        songsQueue.Enqueue(songToAdd[0]);
                    }
                    else
                    {
                        Console.WriteLine($"{songToAdd[0]} is already contained!");
                    }

                }
                else if (input.Contains("Play"))    
                {
                    songsQueue.Dequeue();

                }
                else if (input.Contains("Show"))
                {

                    Console.WriteLine(String.Join(", ",songsQueue));
                }

                input = Console.ReadLine();

            }
           
            Console.WriteLine("No more songs!");


        }
    }
}
