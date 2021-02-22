using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace _01.FileOperationsOddLines
{
    class StartUp
    {
        static void Main()
        {
            //string filePath = "../../../text.txt";    /1vi var
            // string filePath = Path.Combine("..", "..", "..", "text.txt");  2-ri var.

            string pattern = @"[-,.!?]";
            int counter = 0;
            using (StreamReader reader = new StreamReader("text.txt"))
            {
                using (StreamWriter write = new StreamWriter("output.txt"))
                {
                    string line = reader.ReadLine();

                    while (line != null)
                    {

                        if (counter++ % 2 == 0)
                        {
                            string replacedLine = Regex.Replace(line, pattern, "@");

                            string[] words = replacedLine.Split(" ");

                            write.WriteLine(string.Join(" ", words.Reverse()));
                            Console.WriteLine(string.Join(" ", words.Reverse()));
                        }




                        line = reader.ReadLine();
                    }

                };

            }
        }
    }
}
