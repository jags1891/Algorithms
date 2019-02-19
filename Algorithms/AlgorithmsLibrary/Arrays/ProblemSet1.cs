using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace AlgorithmsLibrary.Arrays
{
    /// <summary>
    /// 
    /// </summary>
    public class ProblemSet1
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public int GetMostFreqentElement(int[] arr)
        {
            if (arr == null || arr.Length == 0)
                return -1;
            else if (arr.Length == 1)
                return arr[0];

            Dictionary<int, int> dic = new Dictionary<int, int>();
            int maxKey = 0;
            int maxVal = -1;
   
            for(int i = 0; i < arr.Length; i++)
            {
                if (dic.ContainsKey(arr[i]))
                    dic[arr[i]]++;
                else
                    dic[arr[i]] = 1;

                if(dic[arr[i]]> maxVal)
                {
                    maxKey = i;
                    maxVal = dic[arr[i]];
                }
            }

            return maxKey;
        }

        /// <summary>
        /// Get common elements in 2 sorted arrays
        /// Both the input arrays are sorted
        /// </summary>
        /// <param name="arr1"></param>
        /// <param name="arr2"></param>
        /// <returns></returns>
        public int[] GetCommonElements(int[] arr1, int[] arr2)
        {
            ArrayList arrayList = new ArrayList();

            int arr1Ind = 0;
            int arr2Ind = 0;

            while(arr1Ind<arr1.Length && arr2Ind < arr2.Length)
            {
                if (arr1[arr1Ind] == arr2[arr2Ind])
                {
                    arrayList.Add(arr1[arr1Ind++]);
                    arr2Ind++;
                }
                else if (arr1[arr1Ind] > arr2[arr2Ind])
                    arr2Ind++;
                else
                    arr1Ind++;
            }

            return arrayList.OfType<int>().ToArray();

        }

        /// <summary>
        /// Rerurn true if one input array is the rotation of other.
        /// No duplicates in the arrays
        /// </summary>
        /// <param name="arr1"></param>
        /// <param name="arr2"></param>
        /// <returns></returns>
        public bool IsRotation(int[] arr1, int[] arr2)
        {
            if (arr1.Length != arr2.Length)
                return false;

            int key = arr1[0];
            int startInd = -1;

            for(int i=0; i < arr2.Length; i++)
            {
                if (arr2[i] == key)
                {
                    startInd = i;
                    break;
                } 
            }

            if (startInd == -1)
                return false;

            for(int i=0; i < arr1.Length; i++)
            {
                int j = (i + startInd) % arr1.Length;
                if (arr1[i] != arr2[j])
                    return false;
            }

            return true;
        }

    }
}
