using System;

namespace _02.KnightsOfHonor
{
    class StartUp
    {
        static void Main()
        {

            Func<string, string> func = name => $"Sir {name}";
            string[] names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(func(names[i]));
            }

        }
    }
}
