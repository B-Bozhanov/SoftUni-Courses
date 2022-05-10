using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefiningClasses
{
    public class Family
    {
        private List<Person> familyList;

        public Family()
        {
                this.familyList = new List<Person>();
        }

        public void AddMember(string name , int age)
        {
            var person = new Person(name, age);
            familyList.Add(person);
        } 
        public Person GetOldestMember()
        {
            var oldestYears = familyList.Max(x => x.Age);
            var OldestPerson = familyList.FirstOrDefault(x => x.Age == oldestYears);
            return OldestPerson;
        }
    }
}
