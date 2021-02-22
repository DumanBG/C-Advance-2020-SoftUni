using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Cooking16December2020
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Queue<int> liquid = new Queue<int>(Console.ReadLine().Split(" ").Select(int.Parse).ToArray());
            Stack<int> ingredient = new Stack<int>(Console.ReadLine().Split(" ").Select(int.Parse).ToArray());
            // bread 25   cake 50  Pastry 75  Fruit Pie 10
            int bread = 0;
            int cake = 0;
            int pastry = 0;
            int fruitPie = 0;
            int increase = 0;

            while (liquid.Count > 0 && ingredient.Count > 0)
            {

                int currLiq = liquid.Peek();
                int currIngred = ingredient.Peek() + increase;
                int sum = currLiq + currIngred;

                if (sum == 25 || sum == 50 || sum == 75 || sum == 100)
                {

                    if (sum == 25)
                    {
                        bread++;
                    }
                    else if (sum == 50)
                    {
                        cake++;
                    }
                    else if (sum == 75)
                    {
                        pastry++;
                    }
                    else if (sum == 100)
                    {
                        fruitPie++;
                    }
                    liquid.Dequeue();
                    ingredient.Pop();
                    increase = 0;
                }
                else  // не сме успели махаме liquid i  увеличаваме ingredient +3
                {
                    liquid.Dequeue();
                    int lastIngrediet = ingredient.Pop() + 3;
                    ingredient.Push(lastIngrediet);

                }
                //if (bread >= 1 && cake >= 1 && pastry >= 1 && fruitPie >= 1)
                //{

                //    break;
                //}
            }

            if (bread >= 1 && cake >= 1 && pastry >= 1 && fruitPie >= 1)
            {
                Console.WriteLine("Wohoo! You succeeded in cooking all the food!");
            }
            else
            {
                Console.WriteLine("Ugh, what a pity! You didn't have enough materials to cook everything.");
            }
           

            if(liquid.Count == 0)
            {
                Console.WriteLine("Liquids left: none");
            }
            else
            {
                Console.WriteLine($"Liquids left: {string.Join(", ",liquid)}");
            }
            if(ingredient.Count == 0)
            {
                Console.WriteLine("Ingredients left: none");
            }
            else
            {
                Console.WriteLine($"Ingredients left: {string.Join(", ", ingredient)}");
            }

            Console.WriteLine($"Bread: {bread}");
            Console.WriteLine($"Cake: {cake}");
            Console.WriteLine($"Fruit Pie: {fruitPie}");
            Console.WriteLine($"Pastry: {pastry}");
        }
    }

}