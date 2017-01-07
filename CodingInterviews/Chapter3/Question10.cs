using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingInterviews.Chapter3
{
    [TestClass]
    public class Question10
    {
        /*
         * Question 10 - Given two sorted arrays, denoted as array1 and array2, please merge them into array1 and
           keep the merged array sorted. Suppose there is sufficient vacant memory at the end of array1 to accommodate elements of array2.
         */

        public void merge(int[] A, int n, int[] B, int m)
        {
            int k = m + n - 1, i = n - 1, j = m - 1;
            while (i >= 0 && j >= 0)
            {
                if (A[i] < B[j])
                {
                    A[k--] = B[j--];
                }
                else
                {
                    A[k--] = A[i--];
                }
            }

            while (i >= 0)
            {
                A[k--] = A[i--];
            }

            while (j >= 0)
            {
                A[k--] = B[j--];
            }
        }

        private bool IsSorted(int[] arr, int n)
        {
            for (int i = 1; i < n; i++)
            {
                if (arr[i - 1] > arr[i])
                    return false;
            }
            return true;
        }

        [TestMethod]
        public void TestMethod1()
        {
            int[] A = new int[6] { 1, 3, 5, 0, 0, 0 };
            int[] B = new int[] { 2, 4, 6 };
            merge(A, 3, B, 3);

            Assert.IsTrue(IsSorted(A, 6));
        }
    }
}
