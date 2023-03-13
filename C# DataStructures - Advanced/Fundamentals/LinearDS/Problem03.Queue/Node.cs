namespace Problem03.Queue
{
    public class Node<T>
    {
        public Node(T element)
        {
            this.Head = element;
        }


        public T Head { get; set; }
        public Node<T> Next { get; set; }
    }
}