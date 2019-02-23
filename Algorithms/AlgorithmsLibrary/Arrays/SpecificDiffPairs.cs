using System.Collections.Generic;

namespace AlgorithmsLibrary.Arrays
{
    /// <summary>
    /// SpecificDiffPairs
    /// </summary>
    public class SpecificDiffPairs
    {
        /// <summary>
        /// Given an array arr of distinct integers and a nonnegative integer k, 
        /// write a function findPairsWithGivenDifference that returns an array of all pairs [x,y] in arr, 
        /// such that x - y = k. If no such pairs exist, return an empty array.
        /// 
        /// Note: the order of the pairs in the output array should maintain the order of the y element in the original array.
        /// 
        /// Examples:
        ///     input:  arr = [0, -1, -2, 2, 1], k = 1
        ///     output: [[1, 0], [0, -1], [-1, -2], [2, 1]]
        ///     
        ///     input:  arr = [1, 7, 5, 3, 32, 17, 12], k = 17
        ///     output: []
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public int[,] FindPairsWithGivenDifference(int[] arr, int k)
        {
            List<int[]> result = new List<int[]>();
            HashSet<int> hashSet = new HashSet<int>();

            for (int i = 0; i < arr.Length; i++)
                hashSet.Add(arr[i]);

            // x-y=k => x=y+k
            for (int i = 0; i < arr.Length; i++)
                if (hashSet.Contains(arr[i] + k))
                    result.Add(new int[] { arr[i] + k, arr[i] });

            // not required if the return type is a list
            int[,] res = new int[result.Count, 2];

            for (int i = 0; i <= res.GetUpperBound(0); i++)
            {
                res[i, 0] = result[i][0];
                res[i, 1] = result[i][1];
            }

            return res;
        }
    }
}
