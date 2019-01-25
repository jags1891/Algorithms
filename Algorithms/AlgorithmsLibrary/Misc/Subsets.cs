using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsLibrary.Misc
{
    public class Subsets
    {
        /// <summary>
        /// Return no. of subsets such that sum of all the numbers in each subset is equal to the total.
        /// Ex: arr= [2,4,6,10], total =16 => {2,4,10} , {6,10} => 2 subsets
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="total"></param>
        /// <returns></returns>
        public int CountSubsetsRecursive(int[] arr, int total)
        {
            return CountSubsetsRecursiveUtil(arr, total, arr.Length - 1);
        }

        private int CountSubsetsRecursiveUtil(int[] arr, int total, int index)
        {
            if (total == 0)
                return 1;
            else if (total < 0)
                return 0;
            else if (index < 0)
                return 0;
            else if(total<arr[index])
                return CountSubsetsRecursiveUtil(arr, total, index-1);

            return CountSubsetsRecursiveUtil(arr, total - arr[index], index - 1) + CountSubsetsRecursiveUtil(arr, total, index - 1);
        }

        /// <summary>
        /// Count subsets using memoization
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="total"></param>
        /// <returns></returns>
        public int CountSubsetsDP(int[] arr, int total)
        {
            Dictionary<string, int> memo = new Dictionary<string, int>();
            return CountSubsetsDPUtil(arr, total, arr.Length - 1, memo);
        }

        private int CountSubsetsDPUtil(int[] arr, int total, int index, Dictionary<string, int> memo)
        {
            string key = Convert.ToString(total) +":"+ Convert.ToString(index);

            if (memo.ContainsKey(key))
                return memo[key];
            else if (total == 0)
                return 1;
            else if (index < 0 || total <0)
                return 0;

            int result = 0;

            if (total < arr[index])
                result = CountSubsetsDPUtil(arr, total, index - 1, memo);
            else
                result = CountSubsetsDPUtil(arr, total - arr[index], index-1, memo)+ CountSubsetsDPUtil(arr, total, index - 1, memo);

            memo[key] = result;

            return result;
        }


     }
}
