using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsLibrary.Bitwise
{
    /// <summary>
    /// We're given a large array of 4-byte integers. 
    /// We need to write a method to find out how many total bits are turned on (i.e. 1s are set) inside such an array. 
    /// [Such a digital sum of binary representation of a number, is also called its Hamming Weight].
    /// 
    /// e.g. 1. if input array has two numbers: 31 and 51, the answer is 9, 
    ///         because 31 has 5 bits turned on (out of 32) and 51 has 4. 
    ///      2. if the input is 2147483647 and 3, the answer is 31 + 2 = 33
    /// </summary>
    public class HammingWeight
    {
        /// <summary>
        /// Hamming weight method 1. 
        /// </summary>
        /// <param name="intArr"></param>
        /// <returns></returns>
        public int GetHammingWeight1(int[] intArr)
        {
            int count = 0;

            for(int i=0;i<intArr.Length; i++)
            {
                uint n = (uint)intArr[i];

                while (n>0)
                {
                    if((n & 1)==1)
                        count ++;

                    n >>= 1;
                }

            }

            return count;
        }

        /// <summary>
        /// Hamming weight method 2 by toggling (Brian Kernighan algorithm)
        /// n=(n & n-1) => n & n-1 always toggles right most set bit
        /// </summary>
        /// <param name="intArr"></param>
        /// <returns></returns>
        public int GetHammingWeight2(int[] intArr)
        {
            int count = 0;

            for (int i = 0; i < intArr.Length; i++)
            {
                uint n = (uint)intArr[i];

                while (n > 0)
                {
                    n = n & (n - 1);
                    count++;
                }

            }

            return count;
        }

        /// <summary>
        /// We preprocess set bits for 4 bits 
        /// [0]0000 -0  [4]0100 -1  [8] 1000 -1   [12]1100 -2
        /// [1]0001 -1  [5]0101 -2  [9] 1001 -2   [13]1101 -3
        /// [2]0010 -1  [6]0110 -2  [10]1010 -2   [14]1110 -3
        /// [3]0011 -2  [7]0111 -3  [11]1011 -3   [15]1111 -4
        /// 0x0f = 00001111
        /// </summary>
        /// <param name="intArr"></param>
        /// <returns></returns>
        public int GetHammingWeightbyPreprocessing(int[] intArr)
        {
            int[] table = { 0, 1, 1, 2, 1, 2, 2, 3, 1, 2, 2, 3, 2, 3, 3, 4 };

            int count = 0;

            for (int i = 0; i < intArr.Length; i++)
            {
                uint n = (uint)intArr[i];

                while (n > 0) {

                    count += table[n & 0x0f];
                    n >>= 4;

                }
            }
            return count;
        }
    }
}
