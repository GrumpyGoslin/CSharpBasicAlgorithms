using System;
namespace CSharpBasicAlgorithms.Sorters
{
    public class CounterSort : ISort
    {
        public void Sort(int[] array)
        {
            int max = 0;

            for(int i =0; i < array.Length; i++)
            {
                if(array[i] > max)
                {
                    max = array[i];
                }
            }

            var aux = new int[max + 1];

            for(int i =0; i < array.Length; i++)
            {
                aux[array[i]]++;
            }

            int k = 0;

            for(int i = 0; i < aux.Length; i++)
            {
                var tmp = aux[i];

                while (tmp > 0)
                {
                    array[k] = i;

                    tmp--;
                    k++;
                }

            }

        }
    }
}
