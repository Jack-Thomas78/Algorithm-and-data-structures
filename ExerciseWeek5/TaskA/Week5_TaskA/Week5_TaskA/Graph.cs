using System;
using System.Collections.Generic;
using System.Text;

namespace Week5_TaskA
{
    class Graph<T> where T : IComparable
    {
        private LinkedList<GraphNode<T>> nodes;

        public Graph()
        {
            nodes = new LinkedList<GraphNode<T>>();
        }

        public void AddNode(T id)
        {
            nodes.AddLast(new GraphNode<T>(id));
        }

        public GraphNode<T> GetNodeById(T id)
        {
            foreach(GraphNode<T> n in nodes)
            {
                if(id.CompareTo(n.Id) == 0)
                {
                    return n;
                }

            }
            return null;
        }

        public void AddEdge(T from, T to)
        {
            GraphNode<T> x = GetNodeById(from);
            GraphNode<T> y = GetNodeById(to);

            if (x != null && y != null)
            {
                x.AddEdge(y);
            }
            else
            {
                Console.WriteLine("Nodes not present");
            }
        }

        public bool IsAdj(GraphNode<T> from, GraphNode<T> to)
        {
            if (nodes.Contains(from) == true && nodes.Contains(to) == true)
            {
                foreach (GraphNode<T> n in nodes)
                {
                    if (n.Id.CompareTo(from.Id) == 0)
                    {
                        if (from.GetAdjacent().Contains(to.Id))
                        {
                            return true;
                        }

                    }
                }
                return false;
            }
            else
            {
                return false;
            }
        }

        public int NodesCount()
        {
            return nodes.Count;
        }
    }

}