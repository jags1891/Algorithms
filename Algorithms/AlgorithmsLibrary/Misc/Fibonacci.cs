using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsLibrary.Misc
{
    /// <summary>
    /// 
    /// </summary>
    public class Fibonacci
    {
        /// <summary>
        /// find nth fibonacci number recursively
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int FibRecursive(int n)
        {
            if (n == 1 || n == 2)
                return 1;

            return FibRecursive(n - 1) + FibRecursive(n - 2);

        }

        /// <summary>
        /// Find nth fibonacci number using memoization
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int FibDP(int n)
        {
            if(n==0)
                throw new InvalidOperationException();

            int[] memo = new int[n];
            return (FibDPUtil(n, memo));
        }

        private int FibDPUtil(int n, int[] memo)
        {
            if (memo[n-1] != 0)
                return memo[n];

            int result = 0;

            if (n == 1 || n == 2)
                result = 1;
            else
                result = FibDPUtil(n - 1, memo) + FibDPUtil(n - 2, memo);

            memo[n-1] = result;

            return result;

        }
    }
}
