using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Average_Student_Grades
{
    class Program
    {
        static void Main(string[] args)
        {

            int number = int.Parse(Console.ReadLine());
            
            Dictionary<string, List<decimal>> studentsGrades = new Dictionary<string, List<decimal>>();

            for (int i = 0; i < number; i++)
            {
                string[] inputData = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string name = inputData[0];
                decimal grade = decimal.Parse(inputData[1]);
               
                if (!studentsGrades.ContainsKey(name))
                {
                    studentsGrades.Add(name,new List<decimal>());
                }
                studentsGrades[name].Add(grade);

            }

            foreach (var student in studentsGrades)
            {
                Console.Write($"{student.Key} -> ");
                foreach (var grade in  student.Value)
                {
                    Console.Write($"{grade :f2} ");
                }
                Console.Write($"(avg: {student.Value.Average():f2})");
                Console.WriteLine();
            }

        }
    }
}
