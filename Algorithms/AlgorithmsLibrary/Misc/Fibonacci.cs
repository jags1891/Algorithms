using System;

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
                return memo[n-1];

            int result = 0;

            if (n == 1 || n == 2)
                result = 1;
            else
                result = FibDPUtil(n - 1, memo) + FibDPUtil(n - 2, memo);

            memo[n-1] = result;

            return result;

        }

        /// <summary>
        /// Find nth Fibonocci number bottom up approach o(n)
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int FibBottomUp(int n)
        {
            if (n == 0)
                throw new InvalidOperationException();

            if (n == 1 || n == 2)
                return 1;

            int[] bottomUp = new int[n];
            bottomUp[0] = 1;
            bottomUp[1] = 1;

            for(int i=2; i<n; i++)
            {
                bottomUp[i] = bottomUp[i - 1] + bottomUp[i - 2];
            }

            return bottomUp[n - 1];
        }
    }
}
