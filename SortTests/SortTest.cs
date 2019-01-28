using Algorithms;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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
            
            for (var i = 0; i < actual.Length; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }
        }

        [TestMethod]
        public void InsertionSortTest()
        {
            int[] nums = { 5, 4, 8, 1, 2 };
            int[] expected = { 1, 2, 4, 5, 8 };
            int[] actual = nums.InsertionSort();

            for (var i = 0; i < actual.Length; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }
        }
    }
}
