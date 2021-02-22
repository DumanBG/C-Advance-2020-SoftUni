using System;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main(string[] args)
        {

            int num = int.Parse(Console.ReadLine());

            Family family = new Family();
           
            for (int i = 0; i < num; i++)
            {
                string[] dataInput = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string currName = dataInput[0];
                int currAge = int.Parse(dataInput[1]);
                Person currPerson = new Person(currName, currAge);

                family.AddMember(currPerson);

            }

            Person olderMember = family.GetOldestMember();
            var olders = family.GetOlderThan30().ToList().OrderBy(x=>x.Name);

            if (olders.Count() > 0)
            {
                foreach (var item in olders)
                {
                    Console.WriteLine($"{item.Name} - {item.Age}");
                }
            }
         //   Console.WriteLine($"{olderMember.Name} {olderMember.Age}");





        }
    }
}
