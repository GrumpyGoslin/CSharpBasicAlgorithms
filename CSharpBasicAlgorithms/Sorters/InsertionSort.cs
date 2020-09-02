using System;
namespace CSharpBasicAlgorithms.Sorters
{
    public class InsertionSort : ISort
    {

        public void Sort(int[] array)
        {
            for (var i = 0; i < array.Length; i++)
            {
                var minimum = i;

                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[minimum] > array[j])
                    {
                        minimum = j;
                    }
                }

                array.Swap(i, minimum);
            }
        }
    }
}
