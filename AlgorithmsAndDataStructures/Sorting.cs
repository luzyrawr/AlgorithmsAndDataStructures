﻿using System;

namespace AlgorithmsAndDataStructures
{
    public class Sorting
    {
        public static void BubbleSort(int[] array)
        {
            for(int partIndex = array.Length - 1; partIndex > 0; partIndex--)
            {
                for(int i = 0; i < partIndex; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        Swap(array, i, i + 1);
                    }                        
                }
            }
        }

        public static void SelectionSort(int[] array)
        {
            for(int partIndex = array.Length - 1; partIndex > 0; partIndex--)
            {
                int largestElementIndex = 0;
                for(int i = 1; i <= partIndex; i++)
                {
                    if(array[i] > array[largestElementIndex])
                    {
                        largestElementIndex = i;
                    }
                }
                Swap(array, largestElementIndex, partIndex);
            }
        }

        public static void InsertionSort(int[] array)
        {
            for (int partIndex = 1; partIndex < array.Length; partIndex++)
            {
                int currentUnsorted = array[partIndex];
                int i = 0;
                for (i = partIndex; i > 0 && array[i - 1] > currentUnsorted; i--)
                {
                    array[i] = array[i - 1];
                }
                array[i] = currentUnsorted;
            }
        }

        public static void ShellSort(int[] array)
        {
            int gap = 1;
            while (gap < array.Length / 3)
                gap = 3 * gap + 1;

            while(gap >= 1)
            {
                for(int partIndex = gap; partIndex < array.Length; partIndex++)
                {
                    for (int j = partIndex; j >= gap && array[j] < array[j - gap]; j -= gap)
                    {
                        Swap(array, j, j - gap);
                    }
                }
                gap /= 3;
            }
        }

        public static void MergeSort(int[] array)
        {
            int[] aux = new int[array.Length];
            Sort(0, array.Length - 1);

            void Sort(int low, int high)
            {
                if (high <= low)
                    return;

                int mid = (high + low) / 2;
                Sort(low, mid);
                Sort(mid + 1, high);
                Merge(low, mid, high);
            }

            void Merge(int low, int mid, int high)
            {
                if (array[mid] <= array[mid + 1])
                    return;

                int i = low;
                int j = mid + 1;

                Array.Copy(array, low, aux, low, high - low + 1);

                for (int k = low; k <= high; k++)
                {
                    if (i > mid) 
                        array[k] = aux[j++];
                    else if (j > high)
                        array[k] = aux[i++];
                    else if (aux[j] < aux[i])
                        array[k] = aux[j++];
                    else
                        array[k] = aux[i++];
                }
            }
        }

        public static void Swap(int[] array, int i, int j)
        {
            if (i == j)
                return;
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }
}
