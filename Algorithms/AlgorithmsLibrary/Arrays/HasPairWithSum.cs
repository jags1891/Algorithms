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
    public class HasPairWithSum
    {
        /// <summary>
        /// Given an array A[] and a number x, check for pair in A[] with sum as x
        /// </summary>
        /// <param name="array"></param>
        /// <param name="sum"></param>
        /// <returns></returns>
        public bool isPairWithSumExists(int[] array, int sum)
        {
            HashSet<int> map = new HashSet<int>();

            for(int i=0; i<array.Length; i++)
            {
                if (map.Contains(array[i]))
                    return true;

                map.Add(sum- array[i]);
            }

            return false;
        }
    }
}
