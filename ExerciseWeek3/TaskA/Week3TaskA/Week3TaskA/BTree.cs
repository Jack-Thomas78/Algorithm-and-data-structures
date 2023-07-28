using System;
using System.Collections.Generic;
using System.Text;

namespace Week3TaskA
{
    class BTree<T> where T : IComparable
    {
        protected Node<T> root;

        public BTree()
        {
            root = null;
        }
    }
}
