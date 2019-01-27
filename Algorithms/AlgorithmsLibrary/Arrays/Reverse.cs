using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsLibrary.Arrays
{
    /// <summary>
    /// Reverse
    /// </summary>
    public class Reverse
    {
        /// <summary>
        /// The input string is given as an array of characters char[]
        /// Do not allocate extra space for another array, 
        /// you must do this by modifying the input array in-place with O(1) extra memory.
        /// </summary>
        /// <param name="s"></param>
        public void ReverseCharArray(char[] s)
        {
            if (s == null || s.Length < 2)
                return;

            int last = s.Length - 1;

            for (int i = 0; i < s.Length / 2; i++)
            {
                char c = s[i];
                s[i] = s[last - i];
                s[last - i] = c;
            }
        }
    }
}
