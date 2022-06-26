using System;

namespace Animals
{
    internal class Animal
    {
        public Animal(string name, int age, string gender)
        {
            Name = name;
            Age = age;
            Gender = gender;
        }

        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }

        public virtual string ProduceSound()
        {
            return null;
        }
        public override string ToString()
        {
            return $"{Name} {Age} {Gender}";
        }
    }
}
