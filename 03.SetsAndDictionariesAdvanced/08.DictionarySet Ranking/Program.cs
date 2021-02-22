using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.DictionarySet_Ranking
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> contestData = new Dictionary<string, string>();
            SortedDictionary<string, Dictionary<string, int>> usersSubmissions = new SortedDictionary<string, Dictionary<string, int>>();
            
            string input = Console.ReadLine();

            while (input.ToLower() != "end of contests")
            {
                string[] token = input.Split(":");
                string courseName = token[0];
                string password = token[1];
                contestData.Add(courseName, password);

                input = Console.ReadLine();
            }

            string newInput = Console.ReadLine();

            while(newInput.ToLower() != "end of submissions")
            {
                string[] subToken = newInput.Split("=>", StringSplitOptions.RemoveEmptyEntries);
                string subCourse = subToken[0];
                string subPass = subToken[1];
                string subStudentName = subToken[2];
                int subPoints = int.Parse(subToken[3]);

                if(contestData.ContainsKey(subCourse) && contestData[subCourse] == subPass)
                {   
                    if(!usersSubmissions.ContainsKey(subStudentName))
                    {
                        usersSubmissions.Add(subStudentName, new Dictionary<string, int>());

                    }
                    if(!usersSubmissions[subStudentName].ContainsKey(subCourse))
                    {
                        usersSubmissions[subStudentName].Add(subCourse, subPoints);
                    }
                    if(usersSubmissions[subStudentName][subCourse] < subPoints)
                    {
                        usersSubmissions[subStudentName][subCourse] = subPoints;
                    }
                }
               


                newInput = Console.ReadLine();
            }
           KeyValuePair<string,Dictionary<string,int>> bestStudent= usersSubmissions.OrderByDescending(kvp => kvp.Value.Values.Sum()).First(); // вземане на студнет с най-много точки
            int totalPoints = bestStudent.Value.Values.Sum(); //вземане на тоталСум на .Value.Values
            Console.WriteLine($"Best candidate is {bestStudent.Key} with total {totalPoints} points.");
            Console.WriteLine("Ranking:");
            foreach (var user in usersSubmissions)
            {
                Console.WriteLine(user.Key);

                foreach (var itemContestData in user.Value.OrderByDescending(x => x.Value)) // sort by points in each course
                {

                    Console.WriteLine($"#  {itemContestData.Key} -> {itemContestData.Value}");
                }
            }
        }
    }
}
