using System;
namespace CSharpBasicAlgorithms.Sorters
{
    public class BubbleSort : ISort
    {
        

        public void Sort(int[] array)
        {
            for(var i = 0; i < array.Length -1; i++)
            {
                for(var j = 0; j < array.Length - 1- i; j++)
                {
                    if(array[j] > array[j + 1])
                    {
                        array.Swap(j, j + 1);
                    }
                }
            }
            
        }
    }
}
