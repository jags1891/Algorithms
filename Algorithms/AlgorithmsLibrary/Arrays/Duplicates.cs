using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsLibrary.Arrays
{
    /// <summary>
    /// 
    /// </summary>
    public class Duplicates
    {
        /// <summary>
        /// Given an array of integers, find if the array contains any duplicate
        /// Your function should return true if any value appears at least twice in the array, 
        /// and it should return false if every element is distinct.
        /// Example 1:
        ///     Input: [1,2,3,1]
        ///     Output: true
        /// Example 2:
        ///     Input: [1,2,3,4]
        ///     Output: false
        /// Example 3:
        ///     Input: [1,1,1,3,3,4,3,2,4,2]
        ///     Output: true
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public bool ContainsDuplicate(int[] nums)
        {
            if (nums == null || nums.Length < 1)
                return false;

            HashSet<int> Hset = new HashSet<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (Hset.Contains(nums[i]))
                    return true;
                Hset.Add(nums[i]);
            }

            return false;
        }
    }
}
