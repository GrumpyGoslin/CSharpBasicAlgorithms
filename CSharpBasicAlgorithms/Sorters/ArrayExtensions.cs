
namespace CSharpBasicAlgorithms.Sorters
{
    public static class ArrayExtensions
    {

        public static void Swap(this int[] array, int i , int j)
        {
            var temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
        
    }
}
