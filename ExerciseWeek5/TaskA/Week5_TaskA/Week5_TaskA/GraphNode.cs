using System;
using System.Collections.Generic;
using System.Text;

namespace Week5_TaskA
{
    class GraphNode<T>
    {
        private T id;
        private LinkedList<T> adjacentList;

        public GraphNode(T id)
        {
            this.id = id;
            adjacentList = new LinkedList<T>();
        }

        public T Id
        {
            set { this.id = value; }
            get { return id; }
        }

        public void AddEdge(GraphNode<T> n)
        {
            adjacentList.AddLast(n.id);
        }

        public LinkedList<T> GetAdjacent()
        {
            return adjacentList;
        }
    }
}