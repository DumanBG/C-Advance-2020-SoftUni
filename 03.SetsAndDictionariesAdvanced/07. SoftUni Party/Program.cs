using System;
using System.Collections.Generic;

namespace _07._SoftUni_Party
{
    class Program
    {
        static void Main(string[] args)
        {

            HashSet<string> vipReservation = new HashSet<string>();
            HashSet<string> regularReservation = new HashSet<string>();

            string input = Console.ReadLine();

            while (input.ToLower() != "party")
            {
                char firstChar = input[0];

                if (char.IsDigit(firstChar))
                {
                    vipReservation.Add(input);
                }
                else
                {
                    regularReservation.Add(input);
                }
                input = Console.ReadLine();
            }

            string leavers = Console.ReadLine();

            while (leavers.ToLower() != "end")
            {
                char firstChar = leavers[0];
                if (char.IsDigit(firstChar))
                {
                    vipReservation.Remove(leavers);
                }
                else
                {
                    regularReservation.Remove(leavers);
                }


                leavers = Console.ReadLine();
            }

            int totalSumOfGuest = vipReservation.Count + regularReservation.Count;
            Console.WriteLine(totalSumOfGuest);

            foreach (var vip in vipReservation)
            {
                Console.WriteLine(vip);

            }
            foreach (var regular in regularReservation)
            {
                Console.WriteLine(regular);
            }
        }

    }
}
