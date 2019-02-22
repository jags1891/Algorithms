using System.Collections.Generic;
using System.Linq;

namespace AlgorithmsLibrary.Arrays
{
    /// <summary>
    /// Leet Code
    /// </summary>
    public class SingleNumber
    {
        /// <summary>
        /// Given a non-empty array of integers, every element appears twice except for one. Find that single one
        /// 
        /// Example 1:
        ///     Input: [2,2,1]
        ///     Output: 1
        ///     
        /// Example 2:
        ///     Input: [4,1,2,1,2]
        ///     Output: 4
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int SingleNumberUsingHashMap(int[] nums)
        {
            HashSet<int> list = new HashSet<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (list.Contains(nums[i]))
                    list.Remove(nums[i]);
                else
                    list.Add(nums[i]);
            }

            return list.First();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int SingleNumberUsingBitManipulation(int[] nums)
        {
            int returnVal = 0;
            foreach (int i in nums)
                returnVal ^= i;

            return returnVal;
        }
    }
}
