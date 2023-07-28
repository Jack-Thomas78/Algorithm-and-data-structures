using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week5TaskB
{
    class GraphNode<T> where T : IComparable
    {
        private T data;
        private LinkedList<T> adjList;

        public GraphNode(T id)
        {
            this.data = id;
            adjList = new LinkedList<T>();
        }

        public T Id
        {
            get { return data; }
            set { this.data = value; }
        }

        public LinkedList<T> AdjacentList
        {
            get { return adjList; }
            set { adjList = value; }
        }
        public LinkedList<T> Adjacency()
        {
            return adjList;
        }

        public void AddEdge(GraphNode<T> n)
        {
            adjList.AddLast(n.data);
        }
    }
}
