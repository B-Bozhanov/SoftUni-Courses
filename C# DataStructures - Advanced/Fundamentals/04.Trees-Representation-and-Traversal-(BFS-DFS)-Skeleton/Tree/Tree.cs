namespace Tree
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http.Headers;

    public class Tree<T> : IAbstractTree<T>
    {
        private Tree<T> root;
        private Tree<T> parent;
        private List<Tree<T>> children;
        private T value;

        public Tree(T value)
        {
            this.value = value;
            this.children = new List<Tree<T>>();
        }

        public Tree(T value, params Tree<T>[] children)
            : this(value)
        {
            foreach (var child in children)
            {
                child.parent = this;
                this.children.Add(child);
            }
        }

        public void AddChild(T parentKey, Tree<T> child)
        {
            var tempChild = this;

            var tempParent = this.Search(tempChild, parentKey);

            if (tempParent == null)
            {
                throw new ArgumentNullException();
            }

            child.parent = tempParent;
            tempParent.children.Add(child);
        }

        private Tree<T> Search(Tree<T> tempChild, T nodeKey)
        {
            if (tempChild.value.Equals(nodeKey))
            {
                return tempChild;
            }

            var queue = new Queue<Tree<T>>();
            queue.Enqueue(tempChild);

            while (queue.Count != 0)
            {
                var temp = queue.Dequeue();

                foreach (var child  in temp.children)
                {
                    if (child.value.Equals(nodeKey))
                    {
                        return child;
                    }

                    queue.Enqueue(child);
                }
            }

            return null;
        }

        public IEnumerable<T> OrderBfs()
        {
            var list = new List<T>();
            var queue = new Queue<Tree<T>>();
            var child = this;

            queue.Enqueue(child);

            while (queue.Count != 0)
            {
                var tempChild = queue.Dequeue();
                list.Add(tempChild.value);

                foreach (var ch in tempChild.children)
                {
                    queue.Enqueue(ch);
                }
            }

            return list;
        }

        public IEnumerable<T> OrderDfs()
        {
            var list = new List<T>();
            list = this.OrderDfs(this, list);

            return list;
        }

        private List<T> OrderDfs(Tree<T> tree, List<T> list)
        {
            if (tree.children.Count == 0)
            {
                list.Add(tree.value);
                return list;
            }

            foreach (var child in tree.children)
            {
                this.OrderDfs(child, list);
            }

            list.Add(tree.value);
            return list;
        }

        public void RemoveNode(T nodeKey)
        {
            var node = this.Search(this, nodeKey);

            if (node == null)
            {
                throw new ArgumentNullException();
            }
            if (node.value.Equals(this.value))
            {
                throw new ArgumentException();
            }

            node.parent.children.Remove(node);
        }

        public void Swap(T firstKey, T secondKey)
        {
            Tree<T> temp;
            var firstNode = this.Search(this, firstKey);
            var secondNode = this.Search(this, secondKey);

            if (firstNode == null || secondNode == null)
            {
                throw new ArgumentNullException();
            }
            if (firstNode.value.Equals(this.value) || secondNode.value.Equals(this.value))
            {
                throw new ArgumentException();
            }

            temp = firstNode;

            int firstIndex = firstNode.parent.children.IndexOf(firstNode);
            int secondIndex = secondNode.parent.children.IndexOf(secondNode);

            firstNode.parent.children[firstIndex] = secondNode;
            secondNode.parent.children[secondIndex] = temp;
        }
    }
}
