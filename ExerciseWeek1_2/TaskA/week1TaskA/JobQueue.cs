using System;
using System.Collections.Generic;
using System.Text;

namespace week1TaskA
{
    class JobQueue
    {
        private readonly int maxsize = 20;
        private int head = 0;
        private int tail = 0;
        private int numItems = 0;
        private Task[] store;


        public JobQueue()
        {
            store = new Task[maxsize];
        }


        public void Enqueue(Task task)
        {
            if (IsFull() == false)
            {
                store[tail] = task;
                numItems++;
                if (++tail == maxsize)
                {
                    tail = 0;
                }
            }
            else
            {
                return ;
            }

        }
        public Task Dequeue()
        {
            if (IsEmpty() == false)
            {
                Task firstitem = store[head];
                numItems--;
                if (++head == maxsize)
                {
                    head = 0;
                }
                return firstitem;
            }
            else
            {
                return null;
            }

        }

        public int Contents()
        {
            return numItems;
        }

        public Task Peek()
        {
            if (IsEmpty() == false)
            {
                Task firstItem;
                firstItem = store[head];
                return firstItem;
            }
            else
            {
                Task empty = new Task("Queue is empty");
                return empty;
            }
        }

        public bool IsFull()
        {
            return numItems == maxsize;
        }

        public bool IsEmpty()
        {
            return numItems == 0;
        }
    }
}
