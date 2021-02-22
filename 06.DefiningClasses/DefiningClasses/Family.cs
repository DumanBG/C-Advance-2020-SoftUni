using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefiningClasses
{
    public class Family
    {
        //fields
        private List<Person> peopleInFamily { get; set; }

        //constructor 
        public Family()
        {
            membersOfTheFamily = new List<Person>();
        }

        //properties
        public List<Person> membersOfTheFamily { get; set; }

        //methods
        public void AddMember(Person person)
        {
            membersOfTheFamily.Add(person);
        }
        public Person GetOldestMember()
        {
            return membersOfTheFamily.OrderByDescending(a => a.Age).FirstOrDefault();
        }
        public List<Person>   GetOlderThan30()
        {
            return membersOfTheFamily.Where(x => x.Age > 30).ToList();
        }        
    }
}