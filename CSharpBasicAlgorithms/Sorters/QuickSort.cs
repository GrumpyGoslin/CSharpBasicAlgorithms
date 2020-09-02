using System;
namespace CSharpBasicAlgorithms.Sorters
{
    public class QuickSort : ISort
    {
        

        public void Sort(int[] array)
        {
            Sort(array, 0, array.Length - 1);
        }

        public void Sort(int[] array,int start, int end)
        {
            if(start < end)
            {
                int piv = Partition(array, start, end);
                Sort(array, start, piv -1);
                Sort(array, piv + 1, end);
            }
        }

        private int Partition(int[] array, int start, int end)
        {
            var i = start + 1;
            var piv = array[start];
            for(var j = i; j <= end; j++)
            {
                if(array[j] < piv)
                {
                    array.Swap(i, j);
                    i++;
                }
            }
            i--;
            array.Swap(start, i);
            return i;
        }
    }
}
