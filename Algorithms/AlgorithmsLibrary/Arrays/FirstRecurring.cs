using System.Collections.Generic;

namespace AlgorithmsLibrary.Arrays
{
    /// <summary>
    /// 
    /// </summary>
    public class FirstRecurring
    {
        /// <summary>
        /// Given an array = [2,5,1,2,3,5,1,2,4]:
        /// It should return 2
        /// Given an array = [2,1,1,2,3,5,1,2,4]:, It should return 1
        /// Given an array = [2,3,4,5]: return null
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="input"></param>
        /// <returns></returns>
        public T GetFirstRecurringElement<T>(T[] input)
        {
            if (input == null || input.Length == 0)
                return default(T);
            else if (input.Length <= 2)
                return input[0];

            HashSet<T> map = new HashSet<T>();
            for(int i=0; i < input.Length; i++)
            {
                if (map.Contains(input[i]))
                    return input[i];

                map.Add(input[i]);
            }

            return default(T);

        }
    }
}
