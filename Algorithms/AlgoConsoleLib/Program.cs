using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlgorithmsLibrary;
using AlgorithmsLibrary.Strings;
using AlgorithmsLibrary.Graphs;
using AlgorithmsLibrary.DataStructures;

namespace AlgoConsoleLib
{
    class Program
    {
        static int[] vertices = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        static Tuple<int, int>[]  edges = new[]{Tuple.Create(1,2), Tuple.Create(1,3),
                Tuple.Create(2,4), Tuple.Create(3,5), Tuple.Create(3,6),
                Tuple.Create(4,7), Tuple.Create(5,7), Tuple.Create(5,8),
                Tuple.Create(5,6), Tuple.Create(8,9), Tuple.Create(9,10)};

        static Graph<int> unDirectedgraph = new Graph<int>(vertices, edges, false);

        static GraphSearch search = new GraphSearch();
        static Anagram anagram = new Anagram();



        static void Main(string[] args)
        {
            var path = new List<int>();
            var Prev = new Dictionary<int, int>();

            Console.WriteLine(string.Join(", ", search.DFS(unDirectedgraph, 1)));
            Console.WriteLine(string.Join(", ", search.BFS(unDirectedgraph, 1, ref Prev, v => path.Add(v))));
            Console.WriteLine("Trace Path...");
            Console.WriteLine(string.Join(", ", path));
            foreach (var vertex in vertices)
                Console.WriteLine("shortest path to {0,2}: {1}", vertex, string.Join(", ", search.ShortestPathFromPrev(Prev,1,vertex)));
            Console.WriteLine("Topological Sort....");
            Console.WriteLine(string.Join(", ", TopSort()));
            Console.WriteLine("Is 'create' anagram of 'eaterc'? : " + anagram.isAnagram("create","eaterc"));

            void checkPalindrome(string str){
                Palindrome p = new Palindrome();
                Console.WriteLine("Is this word a palindrome? " + str);
                Console.WriteLine(p.isPalidrome(str, false));
            };

            checkPalindrome("hello");
            checkPalindrome("motor");
            checkPalindrome("rotor");


        }

     

    public static IEnumerable<int> TopSort()
        {
            int[] vertices = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };

            Tuple<int, int>[] edges = new[]{Tuple.Create(1,3), Tuple.Create(1,2),
                Tuple.Create(3,4), Tuple.Create(5,6), Tuple.Create(6,3),
                Tuple.Create(3,8),Tuple.Create(8,11)};

            Graph<int> Directedgraph = new Graph<int>(vertices, edges, true);

            TopologicalSort<int> topological = new TopologicalSort<int>();

            return topological.TopSort(Directedgraph);

        }
    }

   
}
