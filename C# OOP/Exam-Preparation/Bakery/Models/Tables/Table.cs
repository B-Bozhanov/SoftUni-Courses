namespace Bakery.Models.Tables
{
    using System;
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;

    using Bakery.Models.BakedFoods.Contracts;
    using Bakery.Models.Drinks.Contracts;
    using Bakery.Models.Tables.Contracts;

    public abstract class Table : ITable
    {
        private readonly List<IBakedFood> foodOrders;
        private readonly List<IDrink> drinkOrders;
        private int capacity;
        private int numberOfPeople;


        private Table()
        {
            this.foodOrders = new List<IBakedFood>();
            this.drinkOrders = new List<IDrink>(); 
            this.IsReserved = false;
        }
        public Table(int tableNumber, int capacity, decimal pricePerPerson)
            : this()
        {
            this.TableNumber = tableNumber;
            this.Capacity = capacity;
            this.PricePerPerson = pricePerPerson;
        }

        public int TableNumber { get; private set; } // !!!!

        public decimal PricePerPerson { get; private set; } // !!!

        public bool IsReserved { get; private set; } //  !!

        public decimal Price { get; private set; } //  !!!

        public int Capacity
        {
            get => this.capacity;
            private set
            {
                if (value < 0)  
                {
                    throw new ArgumentException("Capacity has to be greater than 0");
                }
                this.capacity = value;
            }
        }

        public int NumberOfPeople
        {
            get => this.numberOfPeople;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Cannot place zero or less people!");
                }
                this.numberOfPeople = value;
            }
        }  // If number of peoples is more than capaccity?




        public void Clear()
        {
            this.foodOrders.Clear();
            this.drinkOrders.Clear();
            this.numberOfPeople = 0;
            this.IsReserved = false;
        }

        public decimal GetBill()
        {
            var totalFoodPrice = this.foodOrders.Sum(x => x.Price);
            var totalDrinksPrice = this.drinkOrders.Sum(x => x.Price);
            return totalFoodPrice + totalDrinksPrice + 
                this.numberOfPeople * this.PricePerPerson;
        }

        public string GetFreeTableInfo()
        {
            var tableInfo = new StringBuilder();

            tableInfo.AppendLine($"Table: {this.TableNumber}");
            tableInfo.AppendLine($"Type: {GetType().Name}");
            tableInfo.AppendLine($"Capacity: {this.Capacity}");
            tableInfo.AppendLine($"Price per Person: {this.PricePerPerson}");
            return tableInfo.ToString().Trim();
        }

        public void OrderDrink(IDrink drink)
        {
            this.drinkOrders.Add(drink);
        }

        public void OrderFood(IBakedFood food)
        {
            this.foodOrders.Add(food);
        }

        public void Reserve(int numberOfPeople)
        {
            this.IsReserved = true;
            this.NumberOfPeople = numberOfPeople;
        }
    }
}
