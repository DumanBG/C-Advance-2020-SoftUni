using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03.Heroes
{
   public class HeroRepository
    {

        List<Hero> heroData;



        public HeroRepository()
        {
            heroData = new List<Hero>();
        }

        public int Count { get => heroData.Count; }










        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            foreach (var item in heroData)
            {
                result.AppendLine($"{item}");

            }
            return result.ToString();

        }



        public void Add(Hero hero)
        {
            heroData.Add(hero);
        }
        public void Remove(string name)
        {
            Hero heroToRemove = heroData.FirstOrDefault(x => x.Name == name);
           if(heroToRemove != null)
            {
                heroData.Remove(heroToRemove);
            }

        }

        public Hero GetHeroWithHighestStrength()
        {
            Hero topStrHero = heroData.OrderByDescending(x => x.Item.Strength).FirstOrDefault();



            return topStrHero;
        }
        public Hero GetHeroWithHighestAbility()
        {
            Hero topAbilityHero = heroData.OrderByDescending(x => x.Item.Ability).FirstOrDefault();



            return topAbilityHero;
        }

        public Hero GetHeroWithHighestIntelligence()
        {
            Hero topIntHero = heroData.OrderByDescending(x => x.Item.Intelligence).FirstOrDefault();



            return topIntHero;
        }


    }
}
