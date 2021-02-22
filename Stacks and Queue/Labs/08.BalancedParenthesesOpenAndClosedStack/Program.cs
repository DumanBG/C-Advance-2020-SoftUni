using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.BalancedParenthesesOpenAndClosedStack
{
    class Program
    {
        static void Main(string[] args)
        {
            //   {[()]}  {[()]}
            string input = Console.ReadLine();

            Stack<char> openParentes = new Stack<char>();

            bool isBalanced = true;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(' || input[i] == '[' || input[i] == '{')
                {
                    openParentes.Push(input[i]);


                }
                else if (input[i] == ')' || input[i] == ']' || input[i] == '}')
                {
                    if (!openParentes.Any())
                    {
                        isBalanced = false;
                        break;
                    }

                    char currentPop = openParentes.Pop();

                    bool iSRoundBalanced = currentPop == '(' && input[i] == ')';
                    bool iSCurlybalanced = currentPop == '{' && input[i] == '}';
                    bool isSquareBalanced = currentPop == '[' && input[i] == ']';

                    if (iSRoundBalanced == false && iSCurlybalanced == false && isSquareBalanced == false)
                    {
                        isBalanced = false;
                        break;
                    }
                }
            }
                if (isBalanced == true)

                {

                    Console.WriteLine("YES");
                }

                else
                {
                    Console.WriteLine("NO");

                }


            }
        }
    }
