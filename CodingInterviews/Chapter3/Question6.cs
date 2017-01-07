using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingInterviews.Chapter3
{
    [TestClass]
    public class Question6
    {
        /*
         * Question 6 An array contains n numbers ranging from 0 to n-1. There are some numbers duplicated in the
            array. It is not clear how many numbers are duplicated or how many times a number gets duplicated. How do you
            find a duplicated number in the array? For example, if an array of length 7 contains the numbers {2, 3, 1, 0, 2, 5,3},
            the implemented function (or method) should return either 2 or 3.
         */

        public int Solve(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; i++)
            {
                int v = arr[i] % n;

                if (arr[v] >= n)
                {
                    return v;
                }

                arr[v] += n;
            }

            return -1;
        }

        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(2, Solve(new int[] { 2, 3, 8, 0, 2, 5, 3 }));
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(-1, Solve(new int[] { 2, 3, 1, 0, 6, 5, 4 }));
        }
        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual(2, Solve(new int[] { 2, 2, 2 }));
        }

        [TestMethod]
        public void TestMethod4()
        {
            Assert.AreEqual(-1, Solve(new int[] { }));
        }
    }
}