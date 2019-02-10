namespace AlgorithmsLibrary.Sorting
{
    /// <summary>
    /// 
    /// </summary>
    public class InsertionSort
    {
        /// <summary>
        /// InsertionSort
        /// { 99, 44, 6, 2, 1, 5, 63, 87, 283, 4, 0}
        /// </summary>
        /// <param name="arr"></param>
        public void Sort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (arr[j - 1] > arr[j])
                    {
                        int temp = arr[j - 1];
                        arr[j - 1] = arr[j];
                        arr[j] = temp;
                    }
                }
            }

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="arr"></param>
        public void SortByShift(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < arr[i - 1])
                {
                    int curr = arr[i];
                    int insInd = i - 1;

                    for (int j = i; j >= 0; j--)
                    {
                        if (curr < arr[j])
                            insInd = j;
                    }

                    for (int k = i; k > insInd; k--)
                    {
                        arr[k] = arr[k - 1];
                    }

                    arr[insInd] = curr;
                }
            }
        }
    }
}
