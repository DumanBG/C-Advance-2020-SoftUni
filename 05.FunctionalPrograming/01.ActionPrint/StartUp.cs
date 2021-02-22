using System;

namespace _01.ActionPrint
{
    class StartUp
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Action<string[]> print = input => Console.WriteLine(string.Join(Environment.NewLine,input));

            print(input);
        }
    }

}
