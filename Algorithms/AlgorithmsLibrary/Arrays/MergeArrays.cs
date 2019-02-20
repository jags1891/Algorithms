namespace AlgorithmsLibrary.Arrays
{
    /// <summary>
    /// 
    /// </summary>
    public class MergeArrays
    {
        /// <summary>
        /// Given two sorted integer arrays Arr1 and Arr2, merge Arr1 and Arr2 as one sorted array.
        /// </summary>
        /// <param name="Arr1"></param>
        /// <param name="Arr2"></param>
        /// <returns></returns>
        public int[] MergeSortedArrays(int[] Arr1, int[] Arr2)
        {
            if (Arr1 == null && Arr2 == null)
                return null;
            else if (Arr1.Length == 0)
                return Arr2;
            else if (Arr2.Length == 0)
                return Arr1;

            int[] mergedArray = new int[Arr1.Length + Arr2.Length];

            int count = 0;
            int arr1Ind = 0;
            int arr2Ind = 0;


            while (count< mergedArray.Length)
            {
                if(arr1Ind>=Arr1.Length && arr2Ind<Arr2.Length) 
                {
                    mergedArray[count] = Arr2[arr2Ind];
                    arr2Ind++;
                }
                else if (arr2Ind >= Arr2.Length && arr1Ind < Arr1.Length)
                {
                    mergedArray[count] = Arr1[arr1Ind];
                    arr1Ind++;
                }
                else if( Arr1[arr1Ind]<Arr2[arr2Ind])
                {
                    mergedArray[count] = Arr1[arr1Ind];
                    arr1Ind++;
                }
                else if (Arr2[arr2Ind] < Arr1[arr1Ind])
                {
                    mergedArray[count] = Arr2[arr2Ind];
                    arr2Ind++;
                }
                else if (Arr2[arr2Ind] == Arr1[arr1Ind])
                {
                    mergedArray[count] = Arr2[arr2Ind];
                    count++;
                    mergedArray[count] = Arr1[arr1Ind];

                    arr2Ind++;
                    arr1Ind++;
                }
                count++;

            }

            return mergedArray;
        }
    }
}
