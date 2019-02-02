using Algorithms;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace SortTests
{
    [TestClass]
    public class SortTest
    {
        [TestMethod]
        public void BubbleSortTest()
        {
            int[] nums = { 5, 4, 8, 1, 2 };
            int[] expected = { 1, 2, 4, 5, 8 };
            int[] actual = nums.BubbleSort();

            Assert.IsTrue(actual.SequenceEqual(expected));
        }

        [TestMethod]
        public void InsertionSortTest()
        {
            int[] nums = { 5, 4, 8, 1, 2 };
            int[] expected = { 1, 2, 4, 5, 8 };
            int[] actual = nums.InsertionSort();

            Assert.IsTrue(actual.SequenceEqual(expected));
        }
    }
}
