using System;
using System.Linq;

namespace _03.SelectAndCalcOnylUpperCaseWord
{
    class Program
    {
        static void Main(string[] args)
        {

            Func<string, bool> upperFilter = eachWord => Char.IsUpper(eachWord[0]); // отива в първи символ на всяка дума ако е Ъпър
            string text = Console.ReadLine();
            string[] words = text.Split(" ", StringSplitOptions.RemoveEmptyEntries);


            words = words.Where(upperFilter).ToArray();


            foreach (var item in words)
            {
                Console.WriteLine(item);
            }
        }
    }
}
