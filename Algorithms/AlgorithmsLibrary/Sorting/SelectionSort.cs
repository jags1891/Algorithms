﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsLibrary.Sorting
{
    public class SelectionSort
    {
        /// <summary>
        /// Selection Sort the array
        /// </summary>
        /// <param name="arr"></param>
        public void Sort(int[] arr)
        {
            int length = arr.Length;

            for (int i = 0; i < length - 1; i++)
            {
                int low = GetSmallestValueIndex(arr, i);
                int temp = arr[low];
                arr[low] = arr[i];
                arr[i] = temp;
            }
        }

        /// <summary>
        /// GetSmallestValueIndex 
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="start"></param>
        /// <returns></returns>
        private int GetSmallestValueIndex(int[] arr, int start)
        {
            int min = arr[start];
            int minInd = start;
            for(int i=start;i<arr.Length-1; i++)
            {
                if (arr[i] == min || arr[i] < min)
                    minInd = i;

            }

            return minInd;

        }
    }
}
