namespace AlgorithmsLibrary.Sorting
{
    public class BubbleSort
    {
        /// <summary>
        /// Bubblesort the given array
        /// </summary>
        /// <param name="arr"></param>
        public void Sort(int[] arr)
        {
            int swapCounter = -1;
            int length = arr.Length;

            for (int i=0; i< length- 1; i++)
            {
                if (swapCounter != 0)
                {
                    swapCounter = 0;

                    for(int j=0; j < length - i - 1; j++)
                    {
                        if (arr[j] > arr[j + 1])
                        {
                            int temp = arr[j];
                            arr[j] = arr[j + 1];
                            arr[j + 1] = temp;
                            swapCounter++;
                        }
                    }
                }
            }

        }

    }
}
