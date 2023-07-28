using System;
using System.Collections.Generic;
using System.Text;

namespace Week3TaskA
{
    class Node<T> where T : IComparable
    {
        private T data;
        public Node<T> left, right;

        public Node(T item)
        {
            this.data = item;
            left = null;
            right = null;
        }

        public T Data
        {
            set { this.data = value; }
            get { return data; }
        }
    }
}
