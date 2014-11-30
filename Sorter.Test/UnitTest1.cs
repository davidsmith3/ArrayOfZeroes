using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Sorter.Test {
    [TestClass]
    public class UnitTest1 {
        [TestMethod]
        public void TestEmpty() {
            SorterCS.Sorter s = new SorterCS.Sorter();
            int[] nums = new int[0];
            int[] result = s.Sort(nums);

            Assert.AreEqual(0, result.Length);
        }

        [TestMethod]
        public void TestOneElementNonZero() {
            SorterCS.Sorter s = new SorterCS.Sorter();
            int[] nums = { 1 };
            int[] result = s.Sort(nums);

            Assert.AreEqual(1, result.Length);
            Assert.AreEqual(1, result[0]);
        }

        [TestMethod]
        public void TestOneElementZero() {
            SorterCS.Sorter s = new SorterCS.Sorter();
            int[] nums = { 0 };
            int[] result = s.Sort(nums);

            Assert.AreEqual(1, result.Length);
            Assert.AreEqual(0, result[0]);
        }

        [TestMethod]
        public void TestTwoElementsInOrder() {
            SorterCS.Sorter s = new SorterCS.Sorter();
            int[] nums = { 6, 0 };
            int[] result = s.Sort(nums);

            Assert.AreEqual(2, result.Length);
            Assert.AreEqual(0, result[1]);
        }

        [TestMethod]
        public void TestTwoElementsOutOfOrder() {
            SorterCS.Sorter s = new SorterCS.Sorter();
            int[] nums = { 0, 6 };
            int[] result = s.Sort(nums);

            Assert.AreEqual(2, result.Length);
            Assert.AreEqual(0, result[1]);
        }

        [TestMethod]
        public void TestTwoElementsBothZero() {
            SorterCS.Sorter s = new SorterCS.Sorter();
            int[] nums = { 0, 0 };
            int[] result = s.Sort(nums);

            Assert.AreEqual(2, result.Length);
            Assert.AreEqual(0, result[1]);
            Assert.AreEqual(0, result[0]);
        }

        [TestMethod]
        public void TestTwoElementsBothNonZero() {
            SorterCS.Sorter s = new SorterCS.Sorter();
            int[] nums = { 2, 2 };
            int[] result = s.Sort(nums);

            Assert.AreEqual(2, result.Length);
        }

        [TestMethod]
        public void TestTypical() {
            SorterCS.Sorter s = new SorterCS.Sorter();
            int[] nums = { 1, 0, 2, 0, 0, 3, 4 };
            int[] result = s.Sort(nums);

            Assert.AreEqual(7, result.Length);
            Assert.AreEqual(0, result[6]);
            Assert.AreEqual(0, result[5]);
            Assert.AreEqual(0, result[4]);
        }

        [TestMethod]
        public void TestTypicalLong() {
            SorterCS.Sorter s = new SorterCS.Sorter();
            int[] nums = { 1, 0, 2, 0, 0, 3, 4, 2, 4, 5, 0, 2, 3, 6, 0, 2, 3, 0 };
            int[] result = s.Sort(nums);

            Assert.AreEqual(18, result.Length);
            Assert.AreEqual(0, result[17]);
            Assert.AreEqual(0, result[16]);
            Assert.AreEqual(0, result[15]);
            Assert.AreEqual(0, result[14]);
            Assert.AreEqual(0, result[13]);
            Assert.AreEqual(0, result[12]);
        }


    }
}
