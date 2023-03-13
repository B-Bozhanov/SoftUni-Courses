namespace _01.Microsystem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Microsystems : IMicrosystem
    {
        private Dictionary<Brand, Dictionary<int, Computer>> store;

        public Microsystems()
        {
            this.store = new Dictionary<Brand, Dictionary<int, Computer>>();
        }


        public void CreateComputer(Computer computer)
        {
            if (!this.store.ContainsKey(computer.Brand))
            {
                this.store.Add(computer.Brand, new Dictionary<int, Computer>());
            }
            if (!this.store[computer.Brand].ContainsKey(computer.Number))
            {
                this.store[computer.Brand][computer.Number] = computer;

                return;
            }

            throw new ArgumentException("Computer is already added !");
        }

        public bool Contains(int number)
        {
            try
            {
                this.GetComputer(number);

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public int Count()
        {
            int count = 0;

            foreach (var brand in this.store)
            {
                count += brand.Value.Count;
            }

            return count;
        }

        public Computer GetComputer(int number)
        {
            foreach (var brand in this.store)
            {
                if (brand.Value.ContainsKey(number))
                {
                    return brand.Value[number];
                }
            }

            throw new ArgumentException("Computer does not exist !");
        }

        public void Remove(int number)
        {
            try
            {
                var comp = this.GetComputer(number);

                this.store[comp.Brand].Remove(number);
            }
            catch (Exception)
            {

                throw new ArgumentException("Computer does not exist !");
            }
        }

        public void RemoveWithBrand(Brand brand)
        {
            if (!this.store.ContainsKey(brand))
            {
                throw new ArgumentException("The brand does not exist !");
            }

            this.store.Remove(brand);
        }

        public void UpgradeRam(int ram, int number)
        {
            try
            {
                var comp = this.GetComputer(number);

                if (ram > comp.RAM)
                {
                    comp.RAM = ram;
                }
            }
            catch (Exception)
            {

                throw new ArgumentException("Computer does not exist !");
            }
        }

        public IEnumerable<Computer> GetAllFromBrand(Brand brand)
        {
            var list = new List<Computer>();

            if (!this.store.Any())
            {
                throw new ArgumentException();
            }
            if (!this.store.ContainsKey(brand))
            {
                return list;
            }


            foreach (var comp in this.store[brand].Values.OrderByDescending(c => c.Price))
            {
                list.Add(comp);
            }

            return list;
        }

        public IEnumerable<Computer> GetAllWithScreenSize(double screenSize)
        {
            if (!this.store.Any())
            {
                throw new ArgumentException();
            }

            var list = new List<Computer>();

            foreach (var brand in this.store)
            {
                foreach (var computer in brand.Value.Values)
                {
                    if (computer.ScreenSize.Equals(screenSize))
                    {
                        list.Add(computer);
                    }
                }
            }

            return list.OrderByDescending(c => c.Number);
        }

        public IEnumerable<Computer> GetAllWithColor(string color)
        {
            var list = new List<Computer>();

            foreach (var brand in this.store)
            {
                foreach (var comp in brand.Value.Values)
                {
                    if (comp.Color.Equals(color))
                    {
                        list.Add(comp);
                    }
                }
            }

            return list.OrderByDescending(c => c.Price);
        }

        public IEnumerable<Computer> GetInRangePrice(double minPrice, double maxPrice)
        {
            var list = new List<Computer>();

            foreach (var brand in this.store)
            {
                foreach (var comp in brand.Value.Values)
                {
                    if (comp.Price >= minPrice && comp.Price <= maxPrice)
                    {
                        list.Add(comp);
                    }
                }
            }

            return list.OrderByDescending(c => c.Price);
        }
    }
}
