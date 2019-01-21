using System;
using System.Collections.Generic;
using AlgorithmsLibrary.DataStructures;

namespace AlgorithmsLibrary.Graphs
{
    public class GraphSearch
    {
        /// <summary>
        /// Simple DFS
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="graph"></param>
        /// <param name="start"></param>
        /// <returns></returns>
        public HashSet<T> DFS<T>(Graph<T> graph, T start)
        {
            var visited = new HashSet<T>();

            if (!graph.AdjacencyList.ContainsKey(start))
                return visited;

            var stack = new Stack<T>();
            stack.Push(start);

            while (stack.Count > 0)
            {
                var vertex = stack.Pop();

                if (visited.Contains(vertex))
                    continue;

                visited.Add(vertex);

                foreach (var neighbor in graph.AdjacencyList[vertex])
                    if (!visited.Contains(neighbor))
                        stack.Push(neighbor);
            }

            return visited;
        }

        /// <summary>
        /// BFS - preVisit allows us to trace the path as HashSet doesnt gaurentee the order.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="graph"></param>
        /// <param name="start"></param>
        /// <param name="preVisit"></param>
        /// <returns></returns>
        public HashSet<T> BFS<T>(Graph<T> graph, T start, ref Dictionary<T,T> previous, Action<T> preVisit = null)
        {
            var visited = new HashSet<T>();

            if (!graph.AdjacencyList.ContainsKey(start))
                return visited;

            var queue = new Queue<T>();
            queue.Enqueue(start);

            while (queue.Count > 0)
            {
                var vertex = queue.Dequeue();

                if (visited.Contains(vertex))
                    continue;

                // To Trace path
                if (preVisit != null)
                    preVisit(vertex);


                visited.Add(vertex);


                foreach (var neighbor in graph.AdjacencyList[vertex])
                {
                    if (!visited.Contains(neighbor))
                        queue.Enqueue(neighbor);
                        
                    if(!previous.ContainsKey(neighbor))
                        previous[neighbor] = vertex;

                }
                    
            }

            return visited;
        }

        /// <summary>
        /// Compute the shortest path from above BFS
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="previousList"></param>
        /// <param name="Start"></param>
        /// <param name="End"></param>
        /// <returns></returns>
        public IEnumerable<T> ShortestPathFromPrev<T>(Dictionary<T, T> previousList,T Start, T End)
        {
            var path = new List<T> { };

            if (previousList == null)
                return path;

            var current = End;

            while (!current.Equals(Start))
            {
                path.Add(current);
                current = previousList[current];
            }

            path.Add(Start);
            path.Reverse();

            return path;
        }
    }
}
