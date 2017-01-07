using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingInterviews
{
    [TestClass]
    public class Question5
    {
        /*
         * Question 5 An array contains n numbers ranging from 0 to n-2. There is exactly one number duplicated in
         * the array. How do you find the duplicated number?
         * For example, if an array with length 5 contains numbers {0, 2, 1, 3, 2}, the duplicated number is 2.
         **/

        public int Solve(int[] arr)
        {
            if (arr.Length <= 1)
                return -1;

            int n = arr.Length - 1;
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }

            int uniqSum = ((n - 1) * n) / 2;
            return sum - uniqSum;
        }

        [TestMethod]
        public void TestCase1()
        {
            Assert.AreEqual(2, Solve(new int[] { 0, 2, 1, 3, 2 }));
        }

        [TestMethod]
        public void TestCase2()
        {
            Assert.AreEqual(0, Solve(new int[] { 0, 0, 1, 3, 2 }));
        }

        [TestMethod]
        public void TestCase3()
        {
            Assert.AreEqual(-1, Solve(new int[] { 0 }));
        }

        [TestMethod]
        public void TestCase4()
        {
            Assert.AreEqual(0, Solve(new int[] { 0, 0 }));
        }
    }
}