namespace AlgorithmsLibrary.Misc
{
    /// <summary>
    /// ReverseInt
    /// </summary>
    public class ReverseInt
    {
        /// <summary>
        /// Assume we are dealing with an environment which could only store integers within the 32-bit signed integer range: [−231,  231 − 1]. 
        /// For the purpose of this problem, assume that your function returns 0 when the reversed integer overflow
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public int ReverseNum(int num)
        {
            try
            {
                int reverse = 0;
                checked
                {
                    while (num != 0)
                    {
                        reverse = reverse * 10;
                        reverse = reverse + num % 10;
                        num /= 10;
                    }
                }

                return reverse;
            }
            catch
            {
                return 0;
            }
        }
    }
}
