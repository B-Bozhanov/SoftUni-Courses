namespace Problem03.Queue
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class Queue<T> : IAbstractQueue<T>
    {
        private Node<T> head;

        public int Count { get; private set; }

        public bool Contains(T item)
        {
            throw new NotImplementedException();
        }

        public T Dequeue()
        {
            throw new NotImplementedException();
        }

        public void Enqueue(T item)
        {
            if (this.head == null)
            {
                this.head = new Node<T>(item);

                return;
            }

            this.head.Next = new Node<T>(item);
        }

        public T Peek()
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
            => throw new NotImplementedException();
    }
}