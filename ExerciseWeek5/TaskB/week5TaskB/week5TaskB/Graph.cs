using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week5TaskB
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

        public void RemoveNode(T id)
        {
            GraphNode<T> n = GetNodeById(id);
            
            foreach(GraphNode<T> node in nodes)
            {
                if(node.Adjacency().Contains(n.Id) == true)
                {
                    node.Adjacency().Remove(n.Id);
                }
            }
            n.AdjacentList = null;
            nodes.Remove(n);
        }
        public GraphNode<T> GetNodeById(T id)
        {
            foreach (GraphNode<T> n in nodes)
            {
                if (id.CompareTo(n.Id) == 0)
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
        }
        public bool IsAdj(GraphNode<T> from, GraphNode<T> to)
        {
            foreach (GraphNode<T> n in nodes)
            {
                if (n.Id.CompareTo(from.Id) == 0)
                {
                    if (from.Adjacency().Contains(to.Id))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public int NodeCount()
        {
            return nodes.Count;
        }
        public bool ContainsNode(GraphNode<T> node)
        {
            foreach (GraphNode<T> n in nodes)
            {
                if (n.Id.CompareTo(node.Id) == 0)
                {
                    return true;
                }
            }
            return false;
        }
        public void BreadthFirstTraverse(T startID, ref List<T> visited)
        {
           
            Queue<T> toVisit = new Queue<T>();
            GraphNode<T> current = new GraphNode<T>(startID);

            toVisit.Enqueue(startID);

            while (toVisit.Count != 0)
            {
                current.Id = toVisit.Peek(); 
                visited.Add(toVisit.Dequeue());
                foreach (T node in GetNodeById(current.Id).Adjacency())
                {
                    if (toVisit.Contains(node) == false)
                    {
                        if (visited.Contains(node) == false)
                        {
                            toVisit.Enqueue(node);
                            
                        }
                    }
                }
                
            }
        }
    }    
}
