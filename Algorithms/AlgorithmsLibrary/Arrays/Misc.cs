namespace AlgorithmsLibrary.Arrays
{
    public class Misc
    {
        /// <summary>
        ///  We're given an array with sorted numbers. 
        ///  The array has been rotated an unknown number of times. 
        ///  We need to figure out the minimum number in such an array. 
        ///  What would be a fast method that uses only constant space?
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public int FindMinInSortedRotated(int[] arr, int start, int last)
        {
            // This condition is needed to handle  
            // the case when array 
            // is not rotated at all 
            if (last < start)
                return arr[0];

            // If there is only one element left 
            if (last == start)
                return arr[start];

            // Find mid 
            // (start + last)/2 
            int mid = start + (last - start) / 2;

            // Check if element (mid+1) is minimum element. Consider 
            // the cases like {3, 4, 5, 1, 2} 
            if (mid < last && arr[mid + 1] < arr[mid])
                return arr[mid + 1];

            // Check if mid itself is minimum element 
            if (mid > start && arr[mid] < arr[mid - 1])
                return arr[mid];

            // Decide whether we need to go to 
            // left half or right half 
            if (arr[last] > arr[mid])
                return FindMinInSortedRotated(arr, start, mid - 1);
            return FindMinInSortedRotated(arr, mid + 1, last);
        }
    }
}
