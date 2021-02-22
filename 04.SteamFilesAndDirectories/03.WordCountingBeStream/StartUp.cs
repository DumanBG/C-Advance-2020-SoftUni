using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _03.WordCountingBeStream
{
    class StartUp
    {
        static void Main()
        {
            string[] words = File.ReadAllLines("words.txt"); // директно ги вкарва в array[] ot File.ReadAllLines("words.txt")
                                                             // Console.WriteLine(string.Join(" ",words)); quick is fault
            string actualResultPath = Path.Combine("..","..","..","actualResult.txt");
          Dictionary <string, int> wordsCount = new Dictionary<string, int>();
            bool actualResultCompareByReal = true;

            foreach (var word in words)
            {
                wordsCount.Add(word.ToLower(), 0);
            }

            string textDefoult = File.ReadAllText("text.txt");
            //  Console.WriteLine(text);
            //-I was quick to judge him, but it wasn't his fault.
            //- Is this some kind of joke?!Is it ?         / if TO DO   wasnt't    '   -??
            // -Quick, hide here. It is safer.

            string[] textWords = textDefoult.Split(new string[] { "-", " ", ",", ".", "!", "?", Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string word in textWords)
            {
                if(wordsCount.ContainsKey(word.ToLower()))
                {
                    wordsCount[word.ToLower()]++;
                }
            }

            Dictionary<string, int> sortedWordsByCount = wordsCount.OrderByDescending(kvp => kvp.Value).ToDictionary(kvp => kvp.Key,kvp =>kvp.Value);

            List<string> outputLines = sortedWordsByCount.Select(kvp => $"{kvp.Key} - {kvp.Value}").ToList();  // направо превръщаме Dictionary-to  в List<string>


            File.WriteAllLines(actualResultPath, outputLines);

            string[] expectedResult = File.ReadAllLines("expectedResult.txt");

            for (int i = 0; i < expectedResult.Length; i++)
            {
                if(expectedResult[i] !=outputLines[i])
                {
                    actualResultCompareByReal = false;
                    i = expectedResult.Length;
                }
            
            }
            if(actualResultCompareByReal)
            {
                Console.WriteLine("ActualResult and ExpectedResult are equal!");  
            }    else
                Console.WriteLine("ActualResult and ExpectedResult are not equal!");


        }
    }
}
