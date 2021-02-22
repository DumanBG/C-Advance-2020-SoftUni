using System;

namespace _05.DateModifier
{
    public class StartUp
    {
        public static void Main()
        {
            //1992 05 31          8783
            //2016 06 17

            string firstD = Console.ReadLine();
            string secondD = Console.ReadLine();
           int days = DateModifier.GetDiffBetweenDatesInDays(firstD,secondD);

            Console.WriteLine(Math.Abs(days));



        }
    }
}
