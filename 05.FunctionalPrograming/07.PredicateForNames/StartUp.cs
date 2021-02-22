using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.PredicateForNames
{
    class StartUp
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());

            List<string> text = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();

            Predicate<string> predicate = x => x.Length <= num;


            text = text.Where(x => predicate(x)).ToList();

            Console.WriteLine(string.Join(Environment.NewLine,text));

        }
    }
}
