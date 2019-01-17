﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsLibrary.DataStructures
{
    public class Graph<T>
    {
        public Graph() { }

        bool _isDirected;

        public Graph(IEnumerable<T> vertices, IEnumerable<Tuple<T, T>> edges, bool isDirectedGraph)
        {
            _isDirected = isDirectedGraph;

            foreach (var vertex in vertices)
                AddVertex(vertex);

            foreach (var edge in edges)
                AddEdge(edge);
        }

        public Dictionary<T, HashSet<T>> AdjacencyList { get; } = new Dictionary<T, HashSet<T>>();

        public void AddVertex(T vertex)
        {
            AdjacencyList[vertex] = new HashSet<T>();
        }

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
