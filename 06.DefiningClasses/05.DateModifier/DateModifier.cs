using System;
using System.Collections.Generic;
using System.Text;

namespace _05.DateModifier
{
   public static class DateModifier
    {
        public static int GetDiffBetweenDatesInDays(string firstDate, string secondDate)
        {
            DateTime dateOne = DateTime.Parse(firstDate);
            DateTime dateTwo = DateTime.Parse(secondDate);
            TimeSpan diff = dateOne - dateTwo;
            return diff.Days;
        }





    }
}
