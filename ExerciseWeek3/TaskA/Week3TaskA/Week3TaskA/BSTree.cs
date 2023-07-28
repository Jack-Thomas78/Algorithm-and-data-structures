using System;
using System.Collections.Generic;
using System.Text;

namespace Week3TaskA
{
    class BSTree<T> : BTree<T> where T : IComparable
    {
        public BSTree()
        {
            root = null;
        }

        public void AddItem(T item)
        {
            addItem(item, ref root);
        }

        private void addItem(T item, ref Node<T> tree)
        {
            if (tree == null)
            {
                tree = new Node<T>(item);
            }
            else if (item.CompareTo(tree.Data) < 0)
            {
                addItem(item, ref tree.left);
            }
            else if (item.CompareTo(tree.Data) > 0)
            {
                addItem(item, ref tree.right);
            }
        }

        public int Height(Node<T> root)
        {
            if (root == null)
                return 0;
            else
                return 1 + Math.Max(Height(root.left), Height(root.right));
        }
        public int Height()
        {
            return Height(root);
        }

        public int Count(Node<T> root)
        {
            if (root == null)
            {
                return 0;
            }
            return 1 + Count(root.left) + Count(root.right);
        }

        public int Count()
        {
            return Count(root);
        }
        
    }
}
