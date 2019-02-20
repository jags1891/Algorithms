namespace AlgorithmsLibrary.Arrays
{
    /// <summary>
    /// 
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
            int nonZeroInd = 0;

            for (int i = 0; i < nums.Length; i++)
                if (nums[i] != 0)
                    nums[nonZeroInd++] = nums[i];

            for(int i=nonZeroInd; i<nums.Length;i++)
                nums[nonZeroInd++] = 0;
        }
    }
}
