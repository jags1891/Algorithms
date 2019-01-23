using System;
using System.Collections.Generic;

namespace AlgorithmsLibrary.DataStructures
{
    /// <summary>
    /// Graph DS implementation with adjecency list.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Graph<T>
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        public Graph() { }

        bool _isDirected;

        /// <summary>
        /// Create a graph datastructure by passing list of vertices, edges and
        /// Specify if the graph is directed or undirected.
        /// </summary>
        /// <param name="vertices"></param>
        /// <param name="edges"></param>
        /// <param name="isDirectedGraph"></param>
        public Graph(IEnumerable<T> vertices, IEnumerable<Tuple<T, T>> edges, bool isDirectedGraph)
        {
            _isDirected = isDirectedGraph;

            foreach (var vertex in vertices)
                AddVertex(vertex);

            foreach (var edge in edges)
                AddEdge(edge);
        }

        /// <summary>
        /// Adjecency List : 
        /// Key= Node 
        /// Value = neighboring nodes of the Key
        /// </summary>
        public Dictionary<T, HashSet<T>> AdjacencyList { get; } = new Dictionary<T, HashSet<T>>();

        /// <summary>
        /// Add a new vertex
        /// </summary>
        /// <param name="vertex"></param>
        public void AddVertex(T vertex)
        {
            AdjacencyList[vertex] = new HashSet<T>();
        }

        /// <summary>
        /// Add an edge
        /// </summary>
        /// <param name="edge"></param>
        public void AddEdge(Tuple<T, T> edge)
        {
            if (AdjacencyList.ContainsKey(edge.Item1) && AdjacencyList.ContainsKey(edge.Item2))
            {
                AdjacencyList[edge.Item1].Add(edge.Item2);

                if(!_isDirected)
                    AdjacencyList[edge.Item2].Add(edge.Item1);
            }
        }
    }
}

