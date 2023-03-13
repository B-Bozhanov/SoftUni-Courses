namespace Problem01.List
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class List<T> : IAbstractList<T> where T : IComparable<T>
     {
        private const int DefaultCapacity = 10;
        private const int Barrier = 3;

        private T[] items;

        public List()
        {
            this.items = new T[DefaultCapacity];
        }
        public List(int capacity)
        {
            this.items = new T[capacity];
        }



        public T this[int index]
        {
            get
            {
                this.IndexValidator(index);
                return this.items[index];
            }
            set
            {
                this.IndexValidator(index);
                this.items[index] = value;
            }
        }

        public int Count { get; private set; } = 0;



        public void Add(T element)
        {
            this.MultiplicateArray(this.items.Length, this.Count);
            items[this.Count] = element;
            this.Count++;
        }

        public bool Contains(T element)
        {
            for (int i = 0; i < this.Count; i++)
            {
                if (AreEquual(element, this.items[i]))
                {
                    return true;
                }
            }

            return false;
        }

        public void Insert(int index, T element)
        {
            this.IndexValidator(index);
            this.MultiplicateArray(this.items.Length, this.Count);

            for (int i = this.Count; i > index; i--)
            {
                this.items[i] = this.items[i - 1];
            }
            this.items[index] = element;
            this.Count++;
        }

        public int IndexOf(T element)
        {
            for (int i = 0; i < this.Count; i++)
            {
                if (AreEquual(element, this.items[i]))
                {
                    return i;
                }
            }

            return -1;
        }

        public bool Remove(T element)
        {
            var index = this.IndexOf(element);

            if (index == -1)
            {
                return false;
            }

            for (int i = index; i < this.Count; i++)
            {
                this.items[i] = this.items[i + 1];
            }

            this.Count--;
            return true;
        }

        public void RemoveAt(int index)
        {
            this.IndexValidator(index);

            for (int i = index; i < this.Count; i++)
            {
                this.items[i] = this.items[i + 1];
            }

            this.Count--;
        }

        public ICollection<T> SortIncrease()
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < this.Count; i++)
            {
                yield return this.items[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        // Helper Methods

        private void IndexValidator(int index)
        {
            if (index < 0 || index >= this.Count)
            {
                throw new IndexOutOfRangeException("Invalid index!");
            }
        }

        private void MultiplicateArray(int length, int count)
        {
            var result = length - count;

            if ((result == Barrier))
            {
                var newArray = new T[this.items.Length * 2];

                for (int i = 0; i < this.items.Length; i++)
                {
                    newArray[i] = this.items[i];
                }
                this.items = newArray;
            }
        }

        private bool AreEquual(T element1, T element2)
        {
            return element1.CompareTo(element2) == 0;
        }
    }
}