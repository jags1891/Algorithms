using System;

namespace AlgorithmsLibrary.Misc
{
    /// <summary>
    /// Fib series : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233...
    /// </summary>
    public class Fibonacci
    {
        /// <summary>
        /// find nth fibonacci number recursively
        /// O(2^n)
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int FibRecursive(int n)
        {
            if (n <2)
                return n;

            return FibRecursive(n - 1) + FibRecursive(n - 2);
        }

        /// <summary>
        /// Find nth fibonacci number using memoization o(n)
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int FibDP(int n)
        {
            int[] memo = new int[n+1];
            memo[0] = 0;
            memo[1] = 1;
            return (FibDPUtil(n, memo));
        }

        private int FibDPUtil(int n, int[] memo)
        {
            if (memo[n] != 0)
                return memo[n];

            int result = 0;

            if (n < 2)
                return n;
            else
                result = FibDPUtil(n - 1, memo) + FibDPUtil(n - 2, memo);

            memo[n] = result;

            return result;
        }

        /// <summary>
        /// Find nth Fibonocci number bottom up approach o(n)
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int FibBottomUp(int n)
        {
            if (n < 2)
                return n;

            int[] bottomUp = new int[n+1];
            bottomUp[0] = 0;
            bottomUp[1] = 1;

            for(int i=2; i<n; i++)
            {
                bottomUp[i] = bottomUp[i - 1] + bottomUp[i - 2];
            }

            return bottomUp[n - 1];
        }
    }
}
