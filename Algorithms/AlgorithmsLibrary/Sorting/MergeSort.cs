using System;

namespace AlgorithmsLibrary.Sorting
{
    /// <summary>
    /// Merge Sort
    ///
    /// </summary>
    public class MergeSort
    {
        /// <summary>
        /// Merge Sort
        /// </summary>
        /// <param name="arr"></param>
        public int[] MSort(int[] arr)
        {
            if (arr == null || arr.Length <= 1)
                return arr;

            int length = arr.Length;
            int middle = length / 2;

            int[] left = new int[middle];
            int[] right = new int[length - middle];

            for (int i = 0; i < middle; i++)
                left[i]=arr[i];

            for (int i = 0; i < right.Length; i++)
                right[i]=arr[middle+i];

            return Merge(MSort(left), MSort(right));

        }

        /// <summary>
        /// Merge 2 arrays
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        private int[] Merge(int[] left, int[] right)
        {
            int[] merged = new int[left.Length + right.Length];
            int rightIndex = 0;
            int leftIndex = 0;
            int currInd = 0;

            while (leftIndex < left.Length && rightIndex < right.Length)
            {
                if (left[leftIndex] < right[rightIndex])
                    merged[currInd++]=left[leftIndex++];
                else
                    merged[currInd++] = right[rightIndex++];
            }

            if (leftIndex == left.Length  && rightIndex < right.Length)
            {
                for (int i = rightIndex; i < right.Length; i++)
                    merged[currInd++] = right[rightIndex++];

            }
            else if (rightIndex == right.Length  && leftIndex < left.Length)
            {
                for (int i = leftIndex; i < left.Length; i++)
                    merged[currInd++] = left[leftIndex++];
            }
            return merged;
        }
    }
}
