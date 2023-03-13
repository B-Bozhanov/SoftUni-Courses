namespace _01.DogVet
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Wintellect.PowerCollections;
    using System.Xml.Linq;

    public class DogVet : IDogVet
    {
        private readonly Dictionary<string, Owner> vet;
        private readonly Dictionary<Breed, Dictionary<string, Dog>> dogsByBreed;
        private readonly Dictionary<string, Dog> dogsById;
        private readonly OrderedDictionary<int, Dictionary<string, Dog>> dogsByAge;

        public DogVet()
        {
            this.vet = new Dictionary<string, Owner>();
            this.dogsByBreed = new Dictionary<Breed, Dictionary<string, Dog>>();
            this.dogsByAge = new OrderedDictionary<int, Dictionary<string, Dog>>();
            this.dogsById = new Dictionary<string, Dog>();
        }

        public int Size { get => this.dogsById.Count; }

        public void AddDog(Dog dog, Owner owner)
        {
            if (this.dogsById.ContainsKey(dog.Id))
            {
                throw new ArgumentException();
            }

            if (!this.vet.ContainsKey(owner.Id))
            {
                this.vet.Add(owner.Id, owner);
            }

            if (!this.dogsByBreed.ContainsKey(dog.Breed))
            {
                this.dogsByBreed.Add(dog.Breed, new Dictionary<string, Dog>());
            }
            if (!this.dogsByAge.ContainsKey(dog.Age))
            {
                this.dogsByAge.Add(dog.Age, new Dictionary<string, Dog>());
            }

            dog.Owner = owner;

            this.vet[owner.Id].Add(dog);
            this.dogsById.Add(dog.Id, dog);
            this.dogsByBreed[dog.Breed].Add(dog.Id, dog);
            this.dogsByAge[dog.Age].Add(dog.Id, dog);
        }

        public bool Contains(Dog dog)
        {
            return this.dogsById.ContainsKey(dog.Id);
        }

        public Dog GetDog(string name, string ownerId)
        {
            if (!this.vet.ContainsKey(ownerId) || !this.vet[ownerId].Dogs.ContainsKey(name))
            {
                throw new ArgumentException();
            }

            return this.vet[ownerId].Dogs[name];
        }

        public Dog RemoveDog(string name, string ownerId)
        {
            if (!this.vet.ContainsKey(ownerId) || !this.vet[ownerId].Dogs.ContainsKey(name))
            {
                throw new ArgumentException();
            }

            var dog = this.vet[ownerId].Dogs[name];
            this.vet[ownerId].Dogs.Remove(name);
            this.dogsById.Remove(dog.Id);
            this.dogsByBreed[dog.Breed].Remove(dog.Id);
            this.dogsByAge[dog.Age].Remove(dog.Id);

            return dog;
        }

        public IEnumerable<Dog> GetDogsByOwner(string ownerId)
        {
            if (!this.vet.ContainsKey(ownerId))
            {
                throw new ArgumentException();
            }

            return this.vet[ownerId].Dogs.Values;
        }

        public IEnumerable<Dog> GetDogsByBreed(Breed breed)
        {
            if (!this.dogsByBreed.ContainsKey(breed))
            {
                throw new ArgumentException();
            }

            return this.dogsByBreed[breed].Values;
        }

        public void Vaccinate(string name, string ownerId)
        {
            if (!this.vet.ContainsKey(ownerId) || !this.vet[ownerId].Dogs.ContainsKey(name))
            {
                throw new ArgumentException();
            }

            var dog = this.vet[ownerId].Dogs[name];
            this.vet[ownerId].Dogs[name].Vaccines++; 
        }

        public void Rename(string oldName, string newName, string ownerId)
        {
            if (!this.vet.ContainsKey(ownerId)) 
            {
                throw new ArgumentException();
            }

            this.vet[ownerId].RenameDog(oldName, newName);
        }

        public IEnumerable<Dog> GetAllDogsByAge(int age)
        {
            if (!this.dogsByAge.ContainsKey(age))
            {
                throw new ArgumentException();
            }

            return this.dogsByAge[age].Values;
        }

        public IEnumerable<Dog> GetDogsInAgeRange(int lo, int hi)
        {
            return this.dogsByAge
                .Range(lo, true, hi, true)
                .SelectMany(x => x.Value)
                .Select(x => x.Value);
        }

        public IEnumerable<Dog> GetAllOrderedByAgeThenByNameThenByOwnerNameAscending()
        {
            var list = new List<Dog>();

            list = this.dogsById.Values
                .OrderBy(d => d.Age)
                .ThenBy(d => d.Name)
                .ThenBy(d => d.Owner.Name)
                .ToList();

            return list;
        }
    }
}