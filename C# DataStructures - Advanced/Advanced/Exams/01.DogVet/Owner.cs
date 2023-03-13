using System;
using System.Collections.Generic;

namespace _01.DogVet
{
    public class Owner
    {
        public Owner(string id, string name)
        {
            this.Id = id;
            this.Name = name;
            this.Dogs = new Dictionary<string, Dog>();
        }

        public Dictionary<string, Dog> Dogs { get; set; }

        public string Id { get; set; }

        public string Name { get; set; }

        public void Add(Dog dog)
        {
            if (this.Dogs.ContainsKey(dog.Name))
            {
                throw new ArgumentException();
            }

            this.Dogs.Add(dog.Name, dog);
        }

        public void RenameDog(string oldName, string newName)
        {
            if (!this.Dogs.ContainsKey(oldName))
            {
                throw new ArgumentException();
            }


            var dog = this.Dogs[oldName];
            this.Dogs.Remove(oldName);
            dog.Name = newName;
            this.Dogs.Add(newName, dog);
        }
    }
}