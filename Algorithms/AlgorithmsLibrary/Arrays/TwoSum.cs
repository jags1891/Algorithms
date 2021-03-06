﻿using System.Collections.Generic;

namespace AlgorithmsLibrary.Arrays
{
    /// <summary>
    /// 
    /// </summary>
    public class TwoSum
    {
        /// <summary>
        /// Given an array of integers, return indices of the two numbers such that they add up to a specific target.
        /// You may assume that each input would have exactly one solution, and you may not use the same element twice.
        /// Example:
        ///     Given nums = [2, 7, 11, 15], target = 9,
        ///     Because nums[0] + nums[1] = 2 + 7 = 9, eturn [0, 1].
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public int[] GetTwoSum(int[] nums, int target)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();
            int[] res = new int[2];
            int temp = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                temp = target - nums[i];

                if (dic.ContainsKey(temp))
                {
                    res[0] = dic[temp];
                    res[1] = i;
                    return res;
                }

                if (!dic.ContainsKey(nums[i]))
                    dic.Add(nums[i], i);
            }

            return res;
        }
    }
}
