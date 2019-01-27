using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsLibrary.Arrays
{
    /// <summary>
    /// INCOMPLETE
    /// </summary>
    public class MoveZeros
    {
        /// <summary>
        /// Given an array nums, write a function to move all 0's to the end of it while maintaining the relative order of the non-zero elements.
        /// Example:
        ///     Input: [0,1,0,3,12]
        ///     Output: [1,3,12,0,0]
        /// </summary>
        /// <param name="nums"></param>
        public void MoveZeroes(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                {
                    for (int ind = i; ind <= nums.Length; ind++)
                    {   
                        if (ind + 1 > nums.Length - 1)
                            break;
 
                            nums[ind] = nums[ind + 1];

                    }

                    nums[nums.Length - 1] = 0;
                }
                if (nums[i] == 0)
                {
                    for (int ind = i; ind <= nums.Length; ind++)
                    {
                        if (ind + 1 > nums.Length - 1)
                            break;

                        nums[ind] = nums[ind + 1];

                    }

                    nums[nums.Length - 1] = 0;
                }

            }
        }
    }
}
