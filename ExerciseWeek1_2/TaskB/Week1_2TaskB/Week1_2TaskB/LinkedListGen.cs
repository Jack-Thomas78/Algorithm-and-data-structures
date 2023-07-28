using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1_2TaskB
{
    class LinkedListGen<T> where T : IComparable
    {
        private NodeGen<T> list;

        public LinkedListGen()
        {
            list = null;
        }

        public void Clear()
        {
            list = null;
        }

        public void AddItem(T item)
        {
            list = new NodeGen<T>(item, list);
        }

        public string DisplayItems()
        {
            NodeGen<T> n = list;
            string buffer = "";

            while (n != null)
            {
                buffer += n.Data.ToString();
                buffer += "\n";
                n = n.Next;
                
            }
            return buffer;
        }

        public void AppendItem(T item)
        {
            NodeGen<T> n = list;

            if(n == null)
            {
                list = new NodeGen<T>(item);
            }
            else
            {
                while(n.Next != null)
                {
                    n = n.Next;
                }
                n.Next = new NodeGen<T>(item);
            }
        }

        public void RemoveItem(T item)
        {
            NodeGen<T> n = list;
            LinkedListGen<T> newList = new LinkedListGen<T>();
            while (n != null)
            {
                if (item.CompareTo(n.Data) != 0)
                {
                    newList.AppendItem(n.Data);
                    n = n.Next;
                }
            }
            list = newList.list;
        }

        public void InsertInOrder(T item)
        {
            NodeGen<T> n = list;
            LinkedListGen<T> newlist = new LinkedListGen<T>();

            if(n == null)
            {
                AddItem(item);
            }
            else
            {
                while(n != null)
                {
                    if (item.CompareTo(n.Data) < 0)
                    {
                        newlist.AppendItem(n.Data);
                    }
                    else if(item.CompareTo(n.Data) > 0)
                    {
                        newlist.AppendItem(item);
                        newlist.AppendItem(n.Data);
                    }
                }
                n = n.Next;
            }
            list = newlist.list;
        }

        public void Sort()
        {
            NodeGen<T> n = list;
            LinkedListGen<T> newlist = new LinkedListGen<T>();

            while (n != null)
            {
                newlist.InsertInOrder(n.Data);
                n = n.Next;
            }
            list = newlist.list;
        }

        public int Count()
        {
            int count = 0;
            NodeGen<T> ncount = list;
            while (ncount != null)
            {
                ncount = ncount.Next;
                count++;
            }
            return count;
        }

        public bool IsPresentItem(T item)
        {
            NodeGen<T> n = list;
            while(n != null)
            {
                if(item.Equals(n.Data))
                {
                    return true;
                }
                n = n.Next;
            }
            return false;
        }
    }
}
