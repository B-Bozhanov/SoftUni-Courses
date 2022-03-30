//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace _03._Heroes_of_Code_and_Logic_VII
//{
//    internal class HeroesInfo
//    {
//        public string Name { get; set; }
//        public int HitPoints { get; set; }
//        public int ManaPoints { get; set; }


//        public HeroesInfo(string name, int hp, int mp)
//        {
//            this.Name = name;
//            this.HitPoints = hp;
//            this.ManaPoints = mp;
//        }

//        public void CastSpell(int mpNeeded, string spellName)
//        {
//            if (this.ManaPoints >= mpNeeded)
//            {
//                this.ManaPoints -= mpNeeded;
//                Console.WriteLine($"{this.Name} has successfully cast {spellName} and now has {this.ManaPoints} MP!");
//            }
//            else
//            {
//                Console.WriteLine($"{this.ManaPoints} does not have enough MP to cast {spellName}!");
//            }
//        }
//        public bool TakeDamage(int damage, string attackerName)
//        {
//            this.HitPoints -= damage;

//            if (this.HitPoints > 0)
//            {
//                Console.WriteLine($"{this.Name} was hit for {damage} HP by {attackerName} and now has {this.HitPoints} HP left!");
//                return false;
//            }
//            Console.WriteLine($"{this.Name} has been killed by {attackerName}!");
//            return true;
//        }
//        public void Recharge(int amount)
//        {
//            this.ManaPoints += amount;

//            if (this.ManaPoints > 200)
//            {
//                this.ManaPoints = 200;
//                amount = 200 - this.ManaPoints;
//            }
//            Console.WriteLine($"{this.Name} recharged for {amount} MP!");
//        }
//        public void Heal(int amount)
//        {
//            this.HitPoints += amount;

//            if (this.HitPoints > 100)
//            {
//                this.HitPoints = 100;
//                amount = 100 - this.ManaPoints;
//            }
//            Console.WriteLine($"{this.Name} healed  for {amount} HP!");
//        }
//    }
//}
