using CSharpBasicAlgorithms.Sorters;
using NUnit.Framework;

namespace CSharpBasicAlgorithms
{
    public class SortTests
    {
        int[] array;
        int[] expected = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        ISort sorter;

        [SetUp]
        public void Setup()
        {
            array = new int[] { 9, 6, 2, 5, 3, 4, 8, 1, 7 };
        }

        [Test]
        public void BubbleSort()
        {
            sorter = new BubbleSort();

            sorter.Sort(array);

            Assert.AreEqual(expected,array);
        }

        [Test]
        public void InsertionSort()
        {
            sorter = new InsertionSort();

            sorter.Sort(array);

            Assert.AreEqual(expected, array);
        }

        [Test]
        public void MergeSort()
        {
            sorter = new MergeSorter();

            sorter.Sort(array);

            Assert.AreEqual(expected, array);
        }


        [Test]
        public void QuickSort()
        {
            sorter = new QuickSort();

            sorter.Sort(array);

            Assert.AreEqual(expected, array);
        }


        [Test]
        public void CountSort()
        {
            sorter = new CounterSort();

            array = new[] { 5, 2, 9, 5, 2, 3, 5 };

            sorter.Sort(array);

            Assert.AreEqual(new[] { 2, 2, 3, 5, 5, 5, 9 }, array);
        }
    }
}