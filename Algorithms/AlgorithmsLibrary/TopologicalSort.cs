using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlgorithmsLibrary.DataStructures;

namespace AlgorithmsLibrary
{
    public class TopologicalSort<T>
    {
        /// <summary>
        /// Topological Sort - Does not check if the graph has cycle. Assumes that the graph is acyclic.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="graph"></param>
        /// <returns></returns>
        public IEnumerable<T> TopSort<T>(Graph<T> graph)
        {
            var sortedList = new List<T> { };
            var stack = new Stack<T>();
            var visited = new HashSet<T>();

            foreach (var vertex in graph.AdjacencyList.Keys)
            {
                if (visited.Contains(vertex))
                    continue;

                TopSortUtil(vertex, ref stack, ref visited, graph);
            }

            while (stack.Count > 0)
                sortedList.Add(stack.Pop());

            return sortedList;
        }

        /// <summary>
        /// Util Method
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="vertex"></param>
        /// <param name="stack"></param>
        /// <param name="visited"></param>
        /// <param name="graph"></param>
        private void TopSortUtil<T>(T vertex, ref Stack<T> stack, ref HashSet<T> visited, Graph<T> graph)
        {
            visited.Add(vertex);

            foreach (var neighbor in graph.AdjacencyList[vertex])
            {
                if (visited.Contains(neighbor))
                    continue;

                TopSortUtil(neighbor, ref stack, ref visited, graph);
            }

            stack.Push(vertex);
        }
    }
}
