using Algorithms;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace SortTests
{
    [TestClass]
    public class PermutationTest
    {
        [TestMethod]
        public void MoveZeroesToEnd()
        {
            int[] nums = { 5, 4, 0, 1, 0, 0, 0, 7, 6 };
            int[] expected = { 5, 4, 1, 7, 6, 0, 0, 0, 0 };
            int[] actual = nums.MoveZeroesToEnd();

            for (var i = 0; i < actual.Length; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }
        }
    }
}
