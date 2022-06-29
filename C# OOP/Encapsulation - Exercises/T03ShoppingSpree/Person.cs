using System;
using System.Collections.Generic;
using System.Text;

namespace T03ShoppingSpree
{
    class Person
    {
        private string name;
        private decimal money;
        public Person(string name, decimal money)
        {
            Name = name;
            Money = money;
            this.Bag = new List<string>();
        }

        internal string Name
        {
            get => this.name;
            set
            {
                if (String.IsNullOrWhiteSpace(value) || String.IsNullOrEmpty(value))
                {
                    throw new Exception("Name cannot be empty");
                }

                this.name = value;
            }
        }
        internal decimal Money
        {
            get => this.money;
            set
            {
                if (value < 0)
                {
                    throw new Exception("Money cannot be negative");
                }
                this.money = value;
            }
        }
        internal string PersonInfo { get => GetPersonInfo(); }
        internal List<string> Bag { get; private set; }

       private string GetPersonInfo()
        {
            return $"{this.Name} - {string.Join(", ", Bag)}";
        }
    }
}
