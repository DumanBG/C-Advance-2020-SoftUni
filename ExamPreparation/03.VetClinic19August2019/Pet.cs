using System;
using System.Collections.Generic;
using System.Text;

namespace VetClinic
{
  public  class Pet
    {
        
        private  string name;
        private int age;
        private string owner;

        //ctor 
        public Pet(string name, int age, string owner)
        {
            this.Name = name;
            this.Age = age;
            this.Owner = owner;
                
        }



        //prop
        public string Name { get =>this.name; set => this.name = value; }
        public int Age { get => this.age; set => this.age = value; }
        public string Owner { get => this.owner; set => this.owner = value; }



        //metod ovveride
        public override string ToString()
        {
            return $"Name: {Name} Age: {Age} Owner: {Owner}";
        }
    }
}
