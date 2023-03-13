namespace _01.Two_Three
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Xml.Linq;

    public class TwoThreeTree<T> where T : IComparable<T>
    {
        private TreeNode<T> root;


        public void Insert(T element)
        {
            this.root = Insert(this.root, element);
        }

        public bool Delete(T element)
        {
            var searchedElement = this.Search(element);


            if (searchedElement == null)
            {
                throw new InvalidOperationException("Element do not exist!");
            }

            return this.Delete(this.root, element);
        }

        private bool Delete(TreeNode<T> node, T element)
        {
            if (node.IsLeaf())
            {
                if (node.IsThreeNode())
                {
                    if (AreEquals(node.RightKey, element))
                    {
                        node.RightKey = default;
                    }
                    else
                    {
                        node.LeftKey = node.RightKey;
                        node.RightKey = default;
                    }

                    return true;
                }

                node.LeftKey = default;
                return true;
            }

            if (node.IsThreeNode())
            {
                if (AreEquals(node.RightKey, element))
                {
                    var bigestElement = this.SearchMax(node.MiddleChild);
                    if (bigestElement.IsThreeNode())
                    {
                        element = bigestElement.RightKey;
                    }
                    else
                    {
                        element = bigestElement.LeftKey;
                    }
                    node.RightKey = element;

                    this.Delete(node.MiddleChild, element);
                    node = this.SplitNodes(node, node.LeftChild);

                    return true;
                }
                else if (AreEquals(node.LeftKey, element))
                {
                    var bigestElement = this.SearchMax(node.LeftChild);
                    if (bigestElement.IsThreeNode())
                    {
                        element = bigestElement.RightKey;
                    }
                    else
                    {
                        element = bigestElement.LeftKey;
                    }
                    node.LeftKey = element;

                    this.Delete(node.LeftChild, element);
                    node = this.SplitNodes(node, node.MiddleChild);

                    return true;
                }
            }

            if (IsLesser(element, node.LeftKey))
            {
                this.Delete(node.LeftChild, element);

                node = this.SplitNodes(node, node.MiddleChild);

                return true;
            }
            else if (node.IsTwoNode() || IsLesser(element, node.RightKey))
            {
                this.Delete(node.MiddleChild, element);

                node = this.SplitNodes(node, node.LeftChild);


                return true;
            }
            else
            {
                this.Delete(node.RightChild, element);


                node = this.SplitNodes(node, node.MiddleChild);


                return true;
            }
        }

        private TreeNode<T> SplitNodes(TreeNode<T> current, TreeNode<T> node)
        {
            if (current.IsTwoNode())
            {
                if (node.IsThreeNode())
                {

                }
                else
                {
                    if (IsLesser(node.LeftKey, current.LeftKey))
                    {
                        current.RightKey = current.LeftKey;
                        current.LeftKey = node.LeftKey;
                        current.LeftChild = node.LeftChild;
                        current.MiddleChild = node.MiddleChild;

                        return current;
                    }
                }
            }
            else if (current.IsThreeNode())
            {

            }

            return null;
        }

        public TreeNode<T> Search(T element)
        {
            return this.Search(this.root, element);
        }

        public TreeNode<T> SearchMin()
        {
            return this.SearchMin(this.root);
        }

        private TreeNode<T> SearchMin(TreeNode<T> node)
        {
            if (node.LeftChild == null)
            {
                return node;
            }

            return this.SearchMin(node.LeftChild);
        }

        public TreeNode<T> SearchMax()
        {
            return this.SearchMax(this.root);
        }

        private TreeNode<T> SearchMax(TreeNode<T> node)
        {
            if (node.MiddleChild == null)
            {
                return node;
            }

            if (node.RightChild != null)
            {
                return this.SearchMax(node.RightChild);
            }
            else
            {
                return this.SearchMax(node.MiddleChild);
            }
        }

        public IEnumerable<T> PostOrder()
        {
            var list = new List<T>();
            Action<T> action = new Action<T>(list.Add);

            this.PostOrder(this.root, action);

            return list;
        }

        private TreeNode<T> Insert(TreeNode<T> node, T element)
        {
            if (node == null)
            {
                return new TreeNode<T>(element);
            }
            if (node.IsLeaf())
            {
                return this.MergeNodes(node, new TreeNode<T>(element));
            }

            if (IsLesser(element, node.LeftKey))
            {
                var newNode = this.Insert(node.LeftChild, element);

                return newNode == node.LeftChild ? node : this.MergeNodes(node, newNode);
            }
            else if (node.IsTwoNode() || IsLesser(element, node.RightKey))
            {
                var newNode = this.Insert(node.MiddleChild, element);

                if (newNode == node.MiddleChild)
                {
                    return node;
                }
                return this.MergeNodes(node, newNode);
            }
            else
            {
                var newNode = this.Insert(node.RightChild, element);

                return node.RightChild == newNode ? node : this.MergeNodes(node, newNode);
            }
        }

        private TreeNode<T> MergeNodes(TreeNode<T> current, TreeNode<T> node)
        {
            if (current.IsTwoNode())
            {
                if (IsLesser(node.LeftKey, current.LeftKey))
                {
                    current.RightKey = current.LeftKey;
                    current.LeftKey = node.LeftKey;
                    current.LeftChild = node.LeftChild;
                    current.RightChild = current.MiddleChild;
                    current.MiddleChild = node.MiddleChild;
                }
                else
                {
                    current.RightKey = node.LeftKey;
                    current.MiddleChild = node.LeftChild;
                    current.RightChild = node.MiddleChild;
                }

                return current;
            }
            else if (current.IsThreeNode())
            {
                if (IsLesser(node.LeftKey, current.LeftKey))
                {
                    var newNode = new TreeNode<T>(current.LeftKey);
                    newNode.LeftChild = node;
                    newNode.MiddleChild = current;
                    current.LeftKey = current.RightKey;
                    current.LeftChild = current.MiddleChild;
                    current.MiddleChild = current.RightChild;
                    current.RightChild = null;
                    current.RightKey = default;

                    return newNode;
                }
                else if (IsLesser(current.RightKey, node.LeftKey))
                {
                    var newNode = new TreeNode<T>(current.RightKey);
                    newNode.LeftChild = current;
                    newNode.MiddleChild = node;
                    current.RightChild = null;
                    current.RightKey = default;

                    return newNode;
                }
                else
                {
                    var newNode = new TreeNode<T>(node.LeftKey)
                    {
                        LeftChild = new TreeNode<T>(current.LeftKey),
                        MiddleChild = new TreeNode<T>(current.RightKey)
                    };
                    newNode.LeftChild.LeftChild = current.LeftChild;
                    newNode.LeftChild.MiddleChild = node.LeftChild;
                    newNode.MiddleChild.LeftChild = node.MiddleChild;
                    newNode.MiddleChild.MiddleChild = current.RightChild;

                    return newNode;
                }
            }

            return null;
        }

        private void PostOrder(TreeNode<T> node, Action<T> action)
        {
            if (node == null)
            {
                return;
            }

            this.PostOrder(node.LeftChild, action);
            this.PostOrder(node.MiddleChild, action);
            this.PostOrder(node.RightChild, action);

            action.Invoke(node.LeftKey);

            if (node.RightKey != null)
            {
                action.Invoke(node.RightKey);
            }

        }

        private TreeNode<T> Search(TreeNode<T> node, T element)
        {
            if (node == null)
            {
                return null;
            }
            if (AreEquals(element, node.LeftKey))
            {
                return node;
            }
            if (AreEquals(element, node.RightKey))
            {
                return node;
            }

            if (IsLesser(element, node.LeftKey))
            {
                return this.Search(node.LeftChild, element);
            }
            else if (node.IsTwoNode() || IsLesser(element, node.RightKey))
            {
                return this.Search(node.MiddleChild, element);
            }
            else
            {
                return this.Search(node.RightChild, element);
            }
        }

        private bool IsLesser(T element, T key)
        {
            return element.CompareTo(key) < 0;
        }

        private bool AreEquals(T element, T key)
        {
            return element.CompareTo(key) == 0;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            RecursivePrint(this.root, sb);
            return sb.ToString();
        }

        private void RecursivePrint(TreeNode<T> node, StringBuilder sb)
        {
            if (node == null)
            {
                return;
            }

            if (node.LeftKey != null)
            {
                sb.Append(node.LeftKey).Append(" ");
            }

            if (node.RightKey != null)
            {
                sb.Append(node.RightKey).Append(Environment.NewLine);
            }
            else
            {
                sb.Append(Environment.NewLine);
            }

            if (node.IsTwoNode())
            {
                RecursivePrint(node.LeftChild, sb);
                RecursivePrint(node.MiddleChild, sb);
            }
            else if (node.IsThreeNode())
            {
                RecursivePrint(node.LeftChild, sb);
                RecursivePrint(node.MiddleChild, sb);
                RecursivePrint(node.RightChild, sb);
            }
        }
    }
}
