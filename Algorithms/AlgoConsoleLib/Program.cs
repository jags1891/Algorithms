﻿using System;
using System.Collections.Generic;
using AlgorithmsLibrary.Strings;
using AlgorithmsLibrary.Graphs;
using AlgorithmsLibrary.Arrays;
using AlgorithmsLibrary.Sorting;
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

            Misc misc = new Misc();

            int[] arr1 = { 5, 6, 1, 2, 3, 4 };
            int n1 = arr1.Length;
            Console.WriteLine("The minimum element is " +
                               misc.FindMinInSortedRotated(arr1, 0, n1 - 1));

            int[] arr2 = { 1, 2, 3, 4 };
            int n2 = arr2.Length;
            Console.WriteLine("The minimum element is " +
                               misc.FindMinInSortedRotated(arr2, 0, n2 - 1));

            int[] arr3 = { 1 };
            int n3 = arr3.Length;
            Console.WriteLine("The minimum element is " +
                               misc.FindMinInSortedRotated(arr3, 0, n3 - 1));

            int[] arr4 = { 1, 2 };
            int n4 = arr4.Length;
            Console.WriteLine("The minimum element is " +
                               misc.FindMinInSortedRotated(arr4, 0, n4 - 1));

            int[] arr5 = { 2, 1 };
            int n5 = arr5.Length;
            Console.WriteLine("The minimum element is " +
                               misc.FindMinInSortedRotated(arr5, 0, n5 - 1));

            int[] arr6 = { 5, 6, 7, 1, 2, 3, 4 };
            int n6 = arr6.Length;
            Console.WriteLine("The minimum element is " +
                               misc.FindMinInSortedRotated(arr6, 0, n1 - 1));

            int[] arr7 = { 1, 2, 3, 4, 5, 6, 7 };
            int n7 = arr7.Length;
            Console.WriteLine("The minimum element is " +
                               misc.FindMinInSortedRotated(arr7, 0, n7 - 1));

            int[] arr8 = { 2, 3, 4, 5, 6, 7, 8, 1 };
            int n8 = arr8.Length;
            Console.WriteLine("The minimum element is " +
                               misc.FindMinInSortedRotated(arr8, 0, n8 - 1));

            int[] arr9 = { 3, 4, 5, 1, 2 };
            int n9 = arr9.Length;
            Console.WriteLine("The minimum element is " +
                               misc.FindMinInSortedRotated(arr9, 0, n9 - 1));

            int[] arr = { 64, 34, 25, 12, 22, 11, 90 };
            BubbleSort bSort = new BubbleSort();
            bSort.Sort(arr);
            Console.Write("arr = { 64, 34, 25, 12, 22, 11, 90 } => Sorted array = ");
            printArray(arr);

            int[] arr_1 = { 64, 34, 25, 12, 22, 11, 90 };
            SelectionSort sSort = new SelectionSort();
            sSort.Sort(arr_1);
            Console.Write("arr_1 = { 64, 34, 25, 12, 22, 11, 90 } => Sorted array = ");
            printArray(arr_1);


        }


        public static void printArray(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; ++i)
                Console.Write(arr[i] + " ");
            Console.WriteLine();
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
