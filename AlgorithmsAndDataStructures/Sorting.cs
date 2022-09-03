using System;

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
