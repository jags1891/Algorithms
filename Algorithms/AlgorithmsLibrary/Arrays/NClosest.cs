using System;
using System.Collections.Generic;
using System.Linq;

namespace AlgorithmsLibrary.Arrays
{
    /// <summary>
    /// NClosest (Improve further) - check edge cases
    /// </summary>
    public class NClosest
    {
        /// <summary>
        /// FindNClosestRestaurants
        /// </summary>
        /// <param name="totalRestaurants"></param>
        /// <param name="allLocations"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public List<List<int>> FindNClosestRestaurants(int totalRestaurants, int[,] allLocations, int n)
        {
            Dictionary<double, List<int>> dic = new Dictionary<double, List<int>>();

            for (int i = 0; i <= allLocations.GetUpperBound(0); i++)
            {
                int x = allLocations[i, 0];
                int y = allLocations[i, 1];
                double dist = GetDistance(x, y);
                List<int> ls = new List<int>();
                ls.Add(x);
                ls.Add(y);
                dic.Add(dist, ls);
            }

            List<List<int>> Result = new List<List<int>>();

            for (int i = 0; i < n; i++)
            {
                double min = dic.Keys.Min();
                Result.Add(dic[min]);
                dic.Remove(min);
            }

            return Result;
        }

        private double GetDistance(int x, int y)
        {
            return Math.Sqrt((x * x) + (y * y));
        }
    }

}
