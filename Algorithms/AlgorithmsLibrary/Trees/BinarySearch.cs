namespace AlgorithmsLibrary.Trees
{
    /// <summary>
    /// Binary Search Algorithms
    /// </summary>
    public class BinarySearch
    {
        /// <summary>
        /// implementation of recursive Binary Search 
        /// Returns index of x if it is present in the array
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="leftInd"></param>
        /// <param name="rightInd"></param>
        /// <returns></returns>
        public int BinarySearchRecursive(int[] arr, int leftInd, int rightInd, int x)
        {
            if (arr == null || arr.Length < 1)
                return -1;
       
            if (rightInd >= leftInd)
            {
                int mid = leftInd + (rightInd - leftInd) / 2;

                if (arr[mid] == x)
                    return mid;

                if (arr[mid] < x)
                   return BinarySearchRecursive(arr, mid+1, rightInd, x);
                
                  return  BinarySearchRecursive(arr, leftInd, mid - 1, x);
            }

            return -1;
        }

        /// <summary>
        /// implementation of itirative Binary Search 
        /// Returns index of x if it is present in the array
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="x"></param>
        /// <returns></returns>
        public int BinarySearchItirative(int[] arr, int x)
        {
            int left = 0;
            int right = arr.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (arr[mid] == x)
                    return mid;
                if (arr[mid] < x)
                    left = mid + 1;
                else
                    right = mid - 1;

            }
            return -1;
        }
    }


}
