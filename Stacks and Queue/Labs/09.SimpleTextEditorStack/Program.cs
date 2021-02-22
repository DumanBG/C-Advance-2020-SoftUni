using System;
using System.Collections.Generic;

namespace _09.SimpleTextEditorStack
{
    class Program
    {
        static void Main(string[] args)
        {
            string startString = string.Empty;

            int commandsCount = int.Parse(Console.ReadLine());
            Stack<string> text = new Stack<string>();
            text.Push(startString);

            for (int i = 0; i < commandsCount; i++)
            {
                    string currText = text.Peek();
                string[] tokens = Console.ReadLine().Split();

                string command = tokens[0];

                if(command == "1")
                {
                    text.Push(currText + tokens[1]);
                }else if(command =="2")
                {
                    text.Push(currText.Substring(0, currText.Length  - (int.Parse(tokens[1]))));
                }else if(command =="3")
                {

                    Console.WriteLine(currText[int.Parse(tokens[1])-1]);
                }else if(command == "4")
                {
                    text.Pop();

                }


            }

        }
    }
}
