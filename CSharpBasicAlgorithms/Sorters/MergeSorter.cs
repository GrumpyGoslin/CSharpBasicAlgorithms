using System;
namespace CSharpBasicAlgorithms.Sorters
{
    public class MergeSorter :  ISort
    {
        public void Sort(int[] array)
        {
            int start = 0;
            int end = array.Length - 1;

            Sort(array, start, end);

        }

        void Merge(int[] array, int start, int mid, int end)
        {
            int i, j, k;
            int leftSize = mid - start + 1;
            int rightSize = end - mid;

 
            var leftArray = new int[leftSize];
            var rightArray = new int[rightSize] ;

            for (i = 0; i < leftSize; i++)
                leftArray[i] = array[start + i];
            for (j = 0; j < rightSize; j++)
                rightArray[j] = array[mid + 1 + j];

           
            i = 0; 
            j = 0; 
            k = start; 
            while (i < leftSize && j < rightSize)
            {
                if (leftArray[i] <= rightArray[j])
                {
                    array[k] = leftArray[i];
                    i++;
                }
                else
                {
                    array[k] = rightArray[j];
                    j++;
                }
                k++;
            }

     
            while (i < leftSize)
            {
                array[k] = leftArray[i];
                i++;
                k++;
            }

            while (j < rightSize)
            {
                array[k] = rightArray[j];
                j++;
                k++;
            }
        }

        
        void Sort(int[] array, int start, int end)
        {
            if (start < end)
            {
                var mid = (start + end) / 2;

                Sort(array, start, mid);
                Sort(array, mid + 1, end);

                Merge(array, start, mid, end);
            }
        }
    }
}
