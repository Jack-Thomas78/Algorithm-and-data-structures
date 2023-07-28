using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1_2TaskB
{
    class NodeGen<T> where T : IComparable
    {
        private T data;
        private NodeGen<T> next;

        public NodeGen(T item)
        {
            this.data = item;
            this.next = null;
        }

        public NodeGen(T item, NodeGen<T> list)
        {
            this.data = item;
            this.next = list;
        }

        public T Data
        {
            get { return data;}
            set { this.data = value; }
        }

        public NodeGen<T> Next
        {
            get { return next; }
            set { this.next = value; }
        }
    }
}
