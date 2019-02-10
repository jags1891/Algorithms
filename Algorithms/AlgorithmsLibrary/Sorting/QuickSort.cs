namespace AlgorithmsLibrary.Sorting
{
    /// <summary>
    /// Quick Sort
    /// </summary>
    public class QuickSort
    {
        /// <summary>
        /// Quick Sort the given array
        /// O(nlogn)
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public void Quick_Sort(int[] arr)
        {
            if (arr == null || arr.Length <= 1)
                return;

             QuickSortUtil(arr, 0, arr.Length - 1);
        }

        private void QuickSortUtil(int[] arr, int leftIndex, int rightIndex)
        {
            if (leftIndex < rightIndex)
            {
                int pivot = rightIndex;
                int partitionIndex = Partition(arr, pivot, leftIndex, rightIndex);

                QuickSortUtil(arr, leftIndex, partitionIndex-1);
                QuickSortUtil(arr, partitionIndex + 1, rightIndex);
            }

            return;
        }

        private int Partition(int[] arr, int pivot, int leftIndex, int rightIndex)
        {
            int pivotVal = arr[pivot];
            int partitionInd = leftIndex;
            for(int i=leftIndex; i<rightIndex; i++)
            {
                if (arr[i] < pivotVal)
                {
                    SwapElements(arr, i, partitionInd);
                    partitionInd++;
                } 
            }
            SwapElements(arr, rightIndex, partitionInd);
            return partitionInd;
        }

        private void SwapElements(int[] arr, int index1, int index2)
        {
            int temp = arr[index1];
            arr[index1]= arr[index2];
            arr[index2]=temp;
        }

    }
}
