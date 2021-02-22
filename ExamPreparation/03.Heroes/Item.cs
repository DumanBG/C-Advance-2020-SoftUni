using System;
using System.Collections.Generic;
using System.Text;

namespace _03.Heroes
{
    public class Item
    {

        public Item(int strength, int ability, int intelligence)
        {
            this.Strength = strength;
            this.Ability = ability;
            this.Intelligence = intelligence;

        }


        public int Strength { get; set; }
        public int Ability { get; set; }
        public int Intelligence { get; set; }




        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine("Item:");
            result.AppendLine($"Strength: {Strength}");
            result.AppendLine($"Ability: {Ability}");
            result.AppendLine($"Intelligence: {Intelligence}");
            return result.ToString();
        }
    }
}
