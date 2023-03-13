namespace CollectionOfPeople
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Wintellect.PowerCollections;

    public class PeopleCollection : IPeopleCollection
    {
        private Dictionary<string, Person> personsByEmail;

        public PeopleCollection()
        {
            this.personsByEmail = new Dictionary<string, Person>();
        }

        public int Count => this.personsByEmail.Count;

        public bool Add(string email, string name, int age, string town)
        {
            if (this.personsByEmail.ContainsKey(email))
            {
                return false;
            }

            var person = new Person(email, name, age, town);
            this.personsByEmail.Add(email, person);

            return true;
        }

        public bool Delete(string email)
        {
            return this.personsByEmail.Remove(email);
        }

        public Person Find(string email)
        {
            return this.personsByEmail.GetValueOrDefault(email);
        }

        public IEnumerable<Person> FindPeople(string emailDomain)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Person> FindPeople(string name, string town)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Person> FindPeople(int startAge, int endAge)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Person> FindPeople(int startAge, int endAge, string town)
        {
            throw new NotImplementedException();
        }
    }
}
